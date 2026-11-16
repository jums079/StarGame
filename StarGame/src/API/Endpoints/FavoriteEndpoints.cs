using StarGame.Application.DTOs;
using StarGame.Application.Handlers;

namespace StarGame.API.Endpoints;

public static class FavoriteEndpoints
{
    public static void MapFavoriteEndpoints(this WebApplication app)
    {
        app.MapPost("/api/games/favorites", (AddFavoriteRequest request, AddFavoriteHandler handler) =>
        {
            
            var result = handler.Handle(request);

            if (!result)
            {
                return Results.Conflict("Voce está tentando duplicar um jogo");
            }

            return Results.Ok(result);
        });
    }
}