using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DockerApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {    
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ApplicationDbContext context,ILogger<ProductController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var appName=Environment.GetEnvironmentVariable("App_Name");
            _logger.LogInformation($"Serving request using {appName}");
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }
    }
}
