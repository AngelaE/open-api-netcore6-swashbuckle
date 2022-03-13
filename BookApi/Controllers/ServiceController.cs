using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        [HttpGet]
        [Route("ping")]
        public ActionResult Ping()
        {
            return Ok("Service is up");
        }
    }
}
