using Microsoft.AspNetCore.Builder;
using Northwind.Backoffice.Web.Middleware;

namespace Northwind.Backoffice.Web.Extensions
{
    public static class RequestResponseLoggingMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestResponseLogging(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestResponseLoggingMiddleware>();
        }
    }
}
