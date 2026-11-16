using StarGame.Application.DTOs;
using StarGame.Application.Interfaces;

namespace StarGame.Application.Handlers;

public class AddFavoriteHandler
{
    private readonly IFavoriteRepository _repository;

    public AddFavoriteHandler(IFavoriteRepository repository)
    {
        _repository = repository;
    }

    public bool Handle(AddFavoriteRequest request)
    {
        var favorites = _repository.GetAll();
        bool exists = favorites.Any(favorite => favorite.GameId == request.GameId);

        if (!exists)
        {
            _repository.Add(request);
        }

        return !exists;
    }
}