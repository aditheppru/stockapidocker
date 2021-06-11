using Microsoft.AspNetCore.Mvc;

namespace StockApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                Id = "1",
                Name = "Dell Computer"
            });
        }
    }
}
