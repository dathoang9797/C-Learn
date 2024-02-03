using WebApplication1.Extensions;
using WebApplication1.Middlewares;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("<div>Hello from middleware 1</div>");
    await next.Invoke();
    await context.Response.WriteAsync("<div>Return from middleware 1</div>");
});

app.UseSimpleMiddleware();

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("<div>Hello from middleware 2</div>");
    await next.Invoke();
    await context.Response.WriteAsync("<div>Return from middleware 2</div>");
});

app.Run(async context => { await context.Response.WriteAsync("<div>Hello from middleware 3</div>"); });

app.Run();