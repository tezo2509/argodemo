using Microsoft.AspNetCore.Mvc;

namespace DockerApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Get() {
            return Ok("Welcome to Products service");
        }

    }
}
