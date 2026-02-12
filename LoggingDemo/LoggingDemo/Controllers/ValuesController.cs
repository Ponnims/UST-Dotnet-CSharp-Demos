using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoggingDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            this.logger = logger;
        }

        [HttpGet("log-information")]
        public IActionResult LogInformation()
        {
            logger.LogInformation("This is an information log. This is successfully executed");
            return Ok("Information log has been written successfully.");
        }

        [HttpGet("log-warning")]
        public IActionResult LogWarning()
        {
            logger.LogWarning("This is a warning log. ");
            return Ok("Warning log has been written successfully.");
        }

        [HttpGet("log-error")]
        public IActionResult LogError()
        {
            try
            {
                int x = 10, y = 0;
                int result = x / y; // This will throw a DivideByZeroException
                return Ok($"The result of division is {result}");
            }
            catch (DivideByZeroException ex)
            {
                logger.LogError(ex, "An error occurred while dividing numbers.");
                return StatusCode(500, "Error Logged Successfully");
            }
        }
    }
}
