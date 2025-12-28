using Application.Interfaces.Services;
using Application.Services;
using Infrastructure.Security;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<ITokenGenerator, JwtTokenGenerator>();
