using TodoApi.Model;

namespace TodoApi.Repositories
{

    public class ProductsRepository : BaseRepository, IProductsRepository
    {
        public ProductsRepository()
        {
        }

        //  Add some kind of return data. 
        //  - In memory with raw data structures
        //  - In Memory with EF or anay other ORM
        //  - SQLLite, SQL Express or Postgres support
        public async Task<IEnumerable<Product>> GetProducts(Guid customerSid, string language, int pageSize = 50, int pageNumber = 1, string sort = "name", string order = "asc")
        {
            throw new NotImplementedException();
        }
    }

}