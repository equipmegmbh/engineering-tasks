using TodoApi.Model;

public class ProductsRepository : IProductsRepository
{
    public ProductsRepository()
    {
    }

    public async Task<IEnumerable<Product>> GetProducts()
    {
        throw new NotImplementedException();
    }
}