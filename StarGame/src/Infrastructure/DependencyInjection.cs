using StarGame.Application.Interfaces;
using StarGame.Infrastructure.Providers;
using StarGame.Infrastructure.Repositories;

namespace StarGame.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services)
    {
        services.AddHttpClient<IRawgApiProvider, RawgApiProvider>();
        services.AddSingleton<IFavoriteRepository, InMemoryFavoriteRepository>();

        return services;
    }
}