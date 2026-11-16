using StarGame.Application.DTOs;
using StarGame.Application.Interfaces;

namespace StarGame.Infrastructure.Repositories;

public class InMemoryFavoriteRepository : IFavoriteRepository
{
    private readonly List<AddFavoriteRequest> _favorites = new();
    
    
    public void Add(AddFavoriteRequest favorite)
    {
        _favorites.Add(favorite);
    }

    public List<AddFavoriteRequest> GetAll()
    {
        return _favorites;
    }

    public void Remove(int gameId)
    {
        _favorites.RemoveAll(favorite => favorite.GameId == gameId);
    }
}