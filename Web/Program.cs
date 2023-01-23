using MathService;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => "10! = "
+ FactorialService.GetFactorialValueOf(10));
app.Run();

