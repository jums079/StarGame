
using StarGame.Application.DTOs;
using StarGame.Application.Interfaces;

namespace StarGame.Infrastructure.Providers;

public class RawgApiProvider : IRawgApiProvider
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey; 
    
    public RawgApiProvider(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _apiKey = configuration["RawgApi:ApiKey"] ?? string.Empty;
    }

    public async Task<GameResponseDto> SearchGamesByNameAsync (string gameName)
    {
        var httpResponse = await _httpClient.GetAsync($"https://api.rawg.io/api/games?search={gameName}&key={_apiKey}");
        
        httpResponse.EnsureSuccessStatusCode(); 
        
        var gameResponseDto = await httpResponse.Content.ReadFromJsonAsync<GameResponseDto>();
        
        return gameResponseDto ?? new GameResponseDto();
    }
}