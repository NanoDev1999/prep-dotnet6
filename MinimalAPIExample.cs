// Minimal API with Routing
// program.cs
var builder = WebApplication.CreateBuilder(args);
app.MapGet("/hello", () => "Hello World");
app.Run();