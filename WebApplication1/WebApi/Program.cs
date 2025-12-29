using Application.Users;
using Domain.Interfaces;
using Infrastructure.Repositories;
using Domain.Entities;

var builder = WebApplication.CreateBuilder(args);

// 指定 port
builder.WebHost.UseUrls("http://localhost:7000", "https://localhost:7001");

// 註冊 Controller
builder.Services.AddControllers();

// 註冊 Application 與 Repository
builder.Services.AddScoped<CheckUserExists>();
builder.Services.AddScoped<IUserRepository, FakeUserRepository>();

var app = builder.Build();

// 必須加這行才能讓 Controller 路由生效
app.MapControllers();

app.Run();
