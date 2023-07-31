using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
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

    /// <summary>       
    [HttpGet(Name = "GetProducts")]
    public async Task<IActionResult> Get([FromQuery(Name = "customer")] Guid customerSid, [FromQuery(Name = "ln")] string language, [FromQuery] int pageSize = 50,
            [FromQuery] int pageNumber = 1, [FromQuery] string sort = "name", [FromQuery] string order = "asc")
    {
        var result = await _productsLogic.GetProducts(customerSid, language, pageSize, pageNumber, sort, order);

        return Ok(result);
    }        
}
