using Microsoft.AspNetCore.Mvc;

namespace MyWebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/product
        [HttpGet]
        public IActionResult GetProducts()
        {
            // Logic to retrieve products
            return Ok();
        }

        // Additional actions can be added here
    }
}
