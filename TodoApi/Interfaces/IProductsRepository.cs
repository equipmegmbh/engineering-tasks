using TodoApi.Model;

public interface IProductsRepository
{
    Task<IEnumerable<Product>> GetProducts(); 
}