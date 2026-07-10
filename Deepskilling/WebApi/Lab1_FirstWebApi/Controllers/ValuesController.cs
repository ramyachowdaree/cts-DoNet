using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lab1_FirstWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        static List<string> products = new List<string>()
        {
            "Laptop",
            "Mouse",
            "Keyboard"
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(products);
        }

        [HttpPost]
        public IActionResult Post(string product)
        {
            products.Add(product);
            return Ok("Product Added Successfully");
        }
    }
}