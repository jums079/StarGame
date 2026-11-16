using StarGame.Application.DTOs;

namespace StarGame.Application.Interfaces;

public interface IFavoriteRepository
{
    void Add(AddFavoriteRequest favorite);
    List <AddFavoriteRequest> GetAll();
    void Remove(int gameId);
}