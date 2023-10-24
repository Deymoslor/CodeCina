using CodeCina.Application.Interfaces;
using CodeCina.Infraestructure.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CodeCina.Infraestructure.Services
{

    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CodeCinaContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("CodeCina"));
            });


            services.AddScoped<IApplicationDbContext, CodeCinaContext>();

            return services;
        }

    }

}
