using LearnerAPI;
using LearnerAPI.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<LearnerDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")));
builder.Services.AddConsulConfig(builder.Configuration);

//var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("This is my UST Teams Training Secret Key"));
//builder.Services.AddAuthentication(options =>
//{
//    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//}).AddJwtBearer(op => op.TokenValidationParameters = new TokenValidationParameters()
//{
//    ValidateAudience=true,
//    ValidateIssuer=true,
//    ValidateIssuerSigningKey=true,
    
//    ValidAudience="learnerapi",
//    ValidIssuer="authapi",
//    IssuerSigningKey=key
//});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseConsul(builder.Configuration);
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
