using StarGame.Application.DTOs;
using StarGame.Application.Interfaces;

namespace StarGame.Application.Services;

public class GameService : IGameService
{
    
    private readonly IRawgApiProvider _rawgApiProvider;
    
    public GameService(IRawgApiProvider rawgApiProvider)
    {
        _rawgApiProvider = rawgApiProvider;
    }
    
    public async Task<GameResponseDto> SearchGamesByNameAsync(string gameName)
    {
        
      return  await _rawgApiProvider.SearchGamesByNameAsync(gameName);
    }
}