using Microsoft.AspNetCore.Builder;

namespace OrderServiceApp;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => "Order Service is running...");
app.Run();