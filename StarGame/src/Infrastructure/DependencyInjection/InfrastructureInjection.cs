using Microsoft.Extensions.DependencyInjection;
using StarGame.Application.Interfaces;
using StarGame.Infrastructure.Providers;

namespace StarGame.Infrastructure.DependencyInjection;

public static class InfrastructureInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services)
    {
        services.AddHttpClient<IRawgApiProvider, RawgApiProvider>();

        return services;
    }
}