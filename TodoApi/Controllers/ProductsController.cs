using Microsoft.AspNetCore.Mvc;
using TodoApi.Model;

namespace TodoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductsLogic _productsLogic;

    //  Configure logging
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger, IProductsLogic logic)
    {
        _logger = logger;
        
        _productsLogic = logic;
    }

    //  Extend the basic get route with: 
    //   - query parameters
    //   - error & https status handling 
    //   - logging etc
    [HttpGet(Name = "GetProducts")]
    public async Task<IActionResult> Get()
    {
        var result = await _productsLogic.GetProducts();

        return Ok(result);
    }        
}
