using TodoApi.Model;

public class ProductsRepository : IProductsRepository
{
    public ProductsRepository()
    {
    }

    //  Add some kind of return data. 
    //  - In memory with raw data structures
    //  - In Memory with EF or anay other ORM
    //  - SQLLite, SQL Express or Postgres support
    public async Task<IEnumerable<Product>> GetProducts()
    {
        throw new NotImplementedException();
    }
}