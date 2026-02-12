using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SerilogDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SerlogdemooController : ControllerBase
    {
        private readonly ILogger<SerlogdemooController> logger;

        public SerlogdemooController(ILogger<SerlogdemooController> logger)
        {
            this.logger = logger;
        }

        [HttpGet("info")]
        public IActionResult GetInfo()
        {
            logger.LogInformation("This is an informational message using Serilog");
            return Ok("Information logged into a file called log.txt.");
        }

        [HttpGet("error")]
        public IActionResult GetError()
        {
            try
            {
                int a = 100, b = 0;
                int res= a / b;
                return Ok(res);
            }
            catch
            {
                logger.LogError("An error occurred in your API");
                return StatusCode(500, "An error occurred. Please check the logs for details.");
            }
        }
    }
}
