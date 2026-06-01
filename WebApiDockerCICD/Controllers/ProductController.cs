using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDockerCICD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Message = "Hello from ProductController!" });
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new { Message = $"Hello from ProductController! You requested product {id}" });
        }

        [HttpPost]
        public IActionResult Post()
        {
            // Here you would typically add the product to a database
            return Ok(new { Message = $"Product created successfully!" });
        }
    }
}
