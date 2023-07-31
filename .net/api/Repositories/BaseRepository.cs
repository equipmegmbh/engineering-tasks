using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System;
using System.Threading.Tasks;

namespace TodoApi.Repositories
{
    public class BaseRepository : IDisposable
    {
        protected IConfiguration _configuration;
        protected SqlConnection _connection;
        private readonly ILogger<BaseRepository> _logger;
        private string _source;

	    public BaseRepository(IConfiguration configuration, ILogger<BaseRepository> logger)
        {
            _configuration = configuration;
            _logger = logger;

            _logger.LogInformation("BaseRepository ctor() | {0}", _source);          

        }    
        
        protected async Task<SqlConnection> GetDatabaseConnection(string source = String.Empty)
        {
            _source = source;

            _logger.LogInformation("GetDatabaseConnection | {0}", _source);            

            var connection = new SqlConnection(_configuration["endpoints:sql:designer"]);

            try
            {
                await connection.OpenAsync();
            }
            catch (System.Exception e)
            {
                _logger.LogError(e, "GetDatabaseConnection | Error opening db connection  to {0} exception : {1}", _configuration["endpoints:sql:designer"], e.Message);

                if (e.InnerException != null)
                {
                    _logger.LogError(e.InnerException, "GetDatabaseConnection | Inner Exception {0}", e.InnerException.Message);                    
                }

                throw;
            }

            return connection;
        }

        private void Connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {   
            _logger.LogInformation("Connection_StateChange | {0} | {1} => {2}", _source, e.OriginalState.ToString(), e.CurrentState.ToString());                     
        }
     
        private void Connection_Disposed(object sender, EventArgs e)
        {
            _logger.LogInformation("Connection_Disposed | {0}", _source);            
        }

        void IDisposable.Dispose()
        {
            if (_connection != null)
            {
                _connection.Dispose();
            }
        }
    }
}
