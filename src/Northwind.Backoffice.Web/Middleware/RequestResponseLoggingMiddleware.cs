using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Northwind.Backoffice.Web.Middleware
{
    public class RequestResponseLoggingMiddleware
    {
        private readonly ILogger _logger;
        private readonly RequestDelegate _next;

        public RequestResponseLoggingMiddleware(RequestDelegate requestDelegate, ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<RequestResponseLoggingMiddleware>();
            _next = requestDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            var watch = new Stopwatch();

            watch.Start();

            await LogRequest(context);
            await LogResponse(context);

            watch.Stop();

            _logger.LogInformation($"HTTP (Request/Response) call performance {watch.ElapsedMilliseconds} ms.");
        }

        private async Task LogResponse(HttpContext context)
        {
            await _next.Invoke(context);

            _logger.LogInformation("Response {statusCode}", context.Response?.StatusCode);
        }

        private Task LogRequest(HttpContext context)
        {
            _logger.LogInformation("Request {method} {url} => {statusCode}",
                                   context.Request?.Method,
                                   context.Request?.Path.Value,
                                   context.Response?.StatusCode);

            return Task.CompletedTask;
        }
    }
}
