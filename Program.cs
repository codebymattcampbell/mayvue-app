using Microsoft.AspNetCore.Builder;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();

app.MapGet("/", () => "Hello from .NET Core Web App! Blue-Green ready.");

app.Run();
