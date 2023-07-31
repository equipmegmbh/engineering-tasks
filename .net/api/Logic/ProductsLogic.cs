using TodoApi.Model;

public class ProductsLogic : IProductsLogic
{
    private readonly IProductsRepository _repository;

    public ProductsLogic(IProductsRepository repository)
    {
        _repository = repository;        
    }

    //  Add repository call
    public async Task<IEnumerable<Product>> GetProducts(Guid customerSid, string language, int pageSize = 50, int pageNumber = 1, string sort = "name", string order = "asc")
    {
        return await _repository.GetProducts(customerSid, language, pageSize, pageNumber, sort, order);
    }
}