using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoggingDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("error")]
        public IActionResult GetError()
        {
            throw new Exception("This is a test exception to demonstrate global error handling.");
        }

        [HttpGet("success")]
        public IActionResult GetSuccess()
        {
            return Ok("This is a successful response to demonstrate normal operation.");
        }
    }
}
