using TodoApi.Model;

public interface IProductsLogic
{
    Task<IEnumerable<Product>> GetProducts(Guid customerSid, string language, int pageSize = 50, int pageNumber = 1, string sort = "name", string order = "asc"); 
}