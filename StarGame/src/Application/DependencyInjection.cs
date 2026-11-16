using StarGame.Application.Handlers;
using StarGame.Application.Interfaces;
using StarGame.Application.Services;

namespace StarGame.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        services.AddScoped<IGameService, GameService>();
        services.AddScoped<AddFavoriteHandler>();

        return services;
    }
}