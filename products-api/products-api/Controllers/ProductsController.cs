using Microsoft.AspNetCore.Mvc;
using products_api.Models;

namespace products_api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{

    public ProductsController()
    {
        
    }

    [HttpGet]
    public IEnumerable<Product> Get()
    {
        return new List<Product>
        {
            new()
            {
                Id = 1,
                Name = "Tatascan 125ml",
                Description = "Es una bebida de x y y para l z y u",
                Category = 1,
                Price = 20,
                ImageUrl = "https://www.tatascan.com/wp-content/uploads/2020/10/100ml.png"
            },
            new()
            {
                Id = 2,
                Name = "Tatascan 250ml",
                Description = "Es una bebida de x y y para l z y u",
                Category = 1,
                Price = 38,
                ImageUrl = "https://www.tatascan.com/wp-content/uploads/2020/10/250ml.png"
            },
            new()
            {
                Id = 3,
                Name = "Tatascan 1000ml",
                Description = "Es una bebida de x y y para l z y u",
                Category = 1,
                Price = 80,
                ImageUrl = "https://www.tatascan.com/wp-content/uploads/2020/10/1000ml.png"
            },
        };
    }
}