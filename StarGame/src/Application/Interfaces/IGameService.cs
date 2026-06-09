using StarGame.Application.DTOs;

namespace StarGame.Application.Interfaces;

public interface IGameService
{
    Task<GameResponseDto> SearchGamesByNameAsync(string gameName);
}