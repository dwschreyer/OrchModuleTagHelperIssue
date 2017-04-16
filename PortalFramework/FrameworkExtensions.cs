using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace PortalFramework
{
    public static class FrameworkExtensions
    {
        public static void AddSatelliteAssemblyTagHelpers(this IServiceProvider serviceProvider, string assemblyName)
        {
            var partManager = serviceProvider.GetRequiredService<ApplicationPartManager>();
            partManager.ApplicationParts.Add(new AssemblyPart(
                Assembly.Load(new AssemblyName(assemblyName))));
        }
    }
}
