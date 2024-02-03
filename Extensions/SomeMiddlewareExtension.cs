using WebApplication1.Middlewares;

namespace WebApplication1.Extensions;

public static class SomeMiddlewareExtension
{
    public static IApplicationBuilder UseSimpleMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<SimpleMiddleware>();
    }
}