using LS.Application.Common.Interfaces.Repositories;
using LS.Application.Common.Interfaces.Services;
using LS.Infrastracture.Persistence.Repositories;
using LS.Infrastracture.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LS.Infrastracture
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastracture
            (this IServiceCollection services)
        {
            services.AddScoped<IRectangleRepository, RectangleRepository>();
            services.AddScoped<IRectangleService, RectangleService>();
           

            return services;

        }

    }
}
