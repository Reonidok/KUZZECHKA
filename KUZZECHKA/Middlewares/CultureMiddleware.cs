using Microsoft.AspNetCore.Localization;
using System.Globalization;

namespace KUZZECHKA.Middlewares
{
    public class CultureMiddleware
    {
        private readonly RequestDelegate _next;

        public CultureMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var cultureCookie = context.Request.Cookies["culture"];
            if (!string.IsNullOrWhiteSpace(cultureCookie))
            {
                var culture = new CultureInfo(cultureCookie);

                CultureInfo.CurrentCulture = culture;
                CultureInfo.CurrentUICulture = culture;
            }

            await _next(context);
        }
    }
}
