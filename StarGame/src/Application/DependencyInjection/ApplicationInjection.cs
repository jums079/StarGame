using Microsoft.Extensions.DependencyInjection;

namespace StarGame.Application.DependencyInjection;

public static class ApplicationInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        services.AddScoped<SearchGameByNameHandler>();

        return services;
    }
}