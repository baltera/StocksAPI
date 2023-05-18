using Microsoft.AspNetCore.Mvc;

namespace Stocks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHealth()
        {
            return Ok(new
            {
                message = "Endpoint working fine."
            });
        }
    }
}
