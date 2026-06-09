using StarGame.Application.DTOs;

namespace StarGame.Application.Interfaces;

public interface IRawgApiProvider
{
    Task<GameResponseDto> SearchGamesByNameAsync(string gameName);
    
}