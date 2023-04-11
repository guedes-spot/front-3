using Microsoft.EntityFrameworkCore;
using Teste.Infrastructure.Persistence;
using Teste.Domain.Interfaces.Services;
using Teste.Infrastructure.Services;

namespace Teste.Infrastructure;

[ExcludeFromCodeCoverage]
public static class DependencyInjection
{
    public static IServiceCollection AddNpgsql(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContextPool<ApplicationDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("Connection"),
            sqlOpetions => sqlOpetions.CommandTimeout(3)));

        return services;
    }
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IHelloWorldService, HelloWorldService>();
        services.AddNpgsql(configuration);
        return services;
    }
}