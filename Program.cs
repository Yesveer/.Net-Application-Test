using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Define a route for the root URL
app.MapGet("/", () => "Hello, World! Welcome to my ASP.NET Core app.");

// Run the application on port 5001
app.Run("http://0.0.0.0:5001");

