using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Northwind.Backoffice.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureLogging(configuration => 
                    {
                        configuration.ClearProviders();
                        configuration.AddConsole();
                        configuration.AddDebug();
                    });
                    webBuilder.UseStartup<Startup>();
                });
    }
}
