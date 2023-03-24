using Microsoft.AspNetCore.Mvc;
using TodoApi.Model;

namespace TodoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductsLogic _productsLogic;

    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger, IProductsLogic logic)
    {
        _logger = logger;
        
        _productsLogic = logic;
    }

    [HttpGet(Name = "GetProducts")]
    public async Task<IActionResult> Get()
    {
        var result = await _productsLogic.GetProducts();

        return Ok(result);
    }        
}
