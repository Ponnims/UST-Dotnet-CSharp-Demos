using AuthenticationService.Models;
using AuthenticationService.Repository;
using AuthenticationService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository repo;
        private readonly ITokenGenerator tokengen;

        public AuthController(IUserRepository repo, ITokenGenerator tokengen)
        {
            this.repo = repo;
            this.tokengen = tokengen;
        }

        [HttpPost("Register")]
        public IActionResult Register(User user)
        {
            {
                repo.Register(user);
                return Ok("User REgisterde Successfully");

            }
        }

        [HttpPost]
        [Route("Login")]

        public IActionResult Login(User user)
        {
            var res = repo.Login(user);
            if(res!=null)
            {
                return Ok(tokengen.GenerateToken(user.Email,res.Role));
            }
            else
            {
                return StatusCode(401, "Invalid Credentials");
            }
        }
    }
}
