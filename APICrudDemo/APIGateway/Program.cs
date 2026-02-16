using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using System.Text;


var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("Ocelot.json");
builder.Services.AddOcelot();


var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("This is my UST Teams Training Secret Key"));
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer("token",op => op.TokenValidationParameters = new TokenValidationParameters()
{
    ValidateAudience = true,
    ValidateIssuer = true,
    ValidateIssuerSigningKey = true,

    ValidAudience = "learnerapi",
    ValidIssuer = "authapi",
    IssuerSigningKey = key
});




var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();
app.UseOcelot().Wait();
app.MapGet("/", () => "Hello World!");

app.Run();
