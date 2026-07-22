using StarGame.Application.DTOs;
using StarGame.Application.Interfaces;

public class SearchGameByNameHandler
{
    private readonly IRawgApiProvider _rawgApiProvider;

    public SearchGameByNameHandler(IRawgApiProvider rawgApiProvider)
    {
        _rawgApiProvider = rawgApiProvider;
    }

    public async Task<GameResponseDto> HandleAsync(string gameName)
    {
        return await _rawgApiProvider.SearchGamesByNameAsync(gameName);
    }
}