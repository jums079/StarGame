using StarGame.Application.Interfaces;

namespace StarGame.API.Endpoints;

public static class GameEndpoints
{
    public static void MapGameEndpoints(this WebApplication webApplication)
    {
        webApplication.MapGet("/api/games/search/{gameName}", async (string gameName, SearchGameByNameHandler handler) =>
        {
          var game = await handler.HandleAsync(gameName);
        return Results.Ok(game);
            
        });
    }
}