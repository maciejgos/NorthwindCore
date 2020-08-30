using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Hosting;
using Northwind.Backoffice.Api.Application;
using Northwind.Backoffice.Infrastructure;
using Northwind.Backoffice.Infrastructure.Data;

namespace Northwind.Backoffice.Api
{
    public class Startup
    {
        private const string ConnectionStringName = "DefaultConnection";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplicationInsightsTelemetry(Configuration["APPINSIGHTS_INSTRUMENTATIONKEY"]);
         
            services.AddInfrastructure(Configuration.GetConnectionString(ConnectionStringName));
            services.AddApplication();

            services.AddControllers();

            services.AddHealthChecks()
                    .AddCheck("live", () => HealthCheckResult.Unhealthy("Application is not responding"))
                    .AddDbContextCheck<NorthwindContext>("db", HealthStatus.Degraded, new[] { "ready" });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHealthChecks("/health/ready", new Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions()
                {
                    Predicate = (check) => check.Tags.Contains("ready")
                });
                endpoints.MapHealthChecks("/health/live", new Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions()
                {
                    Predicate = _ => false
                });
            });
        }
    }
}
