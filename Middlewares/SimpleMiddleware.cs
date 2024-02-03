namespace WebApplication1.Middlewares;

public class SimpleMiddleware
{
    private readonly RequestDelegate _next;

    public SimpleMiddleware(RequestDelegate next)
    {
        this._next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        await context.Response.WriteAsync("<div>Hello from SimpleMiddleware</div>");
        await this._next(context);
        await context.Response.WriteAsync("<div>Return from SimpleMiddleware</div>");
    }
}