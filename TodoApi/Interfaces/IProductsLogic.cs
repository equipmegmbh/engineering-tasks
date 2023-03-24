using TodoApi.Model;

public interface IProductsLogic
{
    Task<IEnumerable<Product>> GetProducts(); 
}