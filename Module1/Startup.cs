using Microsoft.AspNetCore.Modules;
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using System.Reflection;
using PortalFramework;

namespace Module1
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IMyRepository, MyRepository>();
        }

        public override void Configure(IApplicationBuilder app, IRouteBuilder routes, IServiceProvider serviceProvider)
        {
            serviceProvider.AddSatelliteAssemblyTagHelpers("ClTagHelpers");

            routes.MapAreaRoute(
                "Module1Home",
                "Module1",
                "",
                new { controller = "Home", action = "Index" }
                );
        }
    }
}
