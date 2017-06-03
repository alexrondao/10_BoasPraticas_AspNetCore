using Microsoft.AspNetCore.Builder;

namespace BoasPraticasAspNetCore.Middlewares
{
    public static class CultureMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestCulture(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CultureMiddleware>();
        }
    }
}