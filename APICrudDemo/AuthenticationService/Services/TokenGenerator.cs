using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace AuthenticationService.Services
{
    public class TokenGenerator : ITokenGenerator
    {
        public string GenerateToken(string email,string role)
        {
            //  var claims = new[] {new Claim(ClaimTypes.Email, email)};

            var claims = new[] { new Claim(ClaimTypes.Email, email), new Claim(ClaimTypes.Role, role) };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("This is my UST Teams Training Secret Key"));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer:"authapi",
                audience:"learnerapi",
                claims:claims,
                signingCredentials:credentials,
                expires: System.DateTime.Now.AddMinutes(30)
                );

            var response = new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token)
            };

            return JsonConvert.SerializeObject(response);
        }
    }
}
