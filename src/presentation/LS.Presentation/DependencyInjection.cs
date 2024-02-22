using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LS.Infrastracture;
using LS.Presentation.HostedServices;
namespace LS.Presentation
{
    
    public static class DependencyInjection
    {
        public static async Task StartApplication(string[]? args)
        {

            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

            builder.Services.AddInfrastracture();
            builder.Services.AddHostedServiceWorker();
            IHost host = builder.Build();

            await host.RunAsync();
        }
        public static IServiceCollection AddHostedServiceWorker(this IServiceCollection 
            services)
        {
            services.AddHostedService<HostedServiceWorker>();
            return services;
        }
    }
}
