using StarGame.Application.Interfaces;

namespace StarGame.API.Endpoints;

public static class GameEndpoints
{
    public static void MapGameEndpoints(this WebApplication webApplication)
    {
        
        webApplication.MapGet("/api/games/{gameName}", async (string gameName, IGameService gameService) =>
        {
          var game = await gameService.SearchGamesByNameAsync(gameName);
        return Results.Ok(game);
            
        });
    }
}