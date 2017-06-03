using System.Globalization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;

namespace BoasPraticasAspNetCore.Middlewares
{
    public class CultureMiddleware
    {
        private readonly RequestDelegate _next;

        public CultureMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext context)
        {
            var requestCultureFeature = context.Request.GetDisplayUrl().Split('/')[3];

            if (!string.IsNullOrWhiteSpace(requestCultureFeature))
            {
                var culture = new CultureInfo(requestCultureFeature);

                CultureInfo.CurrentCulture = culture;
                CultureInfo.CurrentUICulture = culture;
            }

            return _next(context);
        }
    }
}
