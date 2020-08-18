using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.Backoffice.Api.Application
{
    public static class ApplicationSetup
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(System.Reflection.Assembly.GetExecutingAssembly());
        }
    }
}
