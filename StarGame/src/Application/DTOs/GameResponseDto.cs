using System.Text.Json.Serialization;

namespace StarGame.Application.DTOs;

public class GameItemDto
{
     public int Id { get; set; }
     public string Name { get; set; } = string.Empty;
     [JsonPropertyName("background_image")]
     public string BackgroundImage {get; set;} = string.Empty;
     public decimal Rating { get; set; }
}

public class GameResponseDto
{
    public int Count { get; set; }
    public string Next { get; set; } = string.Empty;
    public string Previous { get; set; } = string.Empty;

    [JsonPropertyName("results")]
    public List<GameItemDto> Results { get; set; } = new List<GameItemDto>();
    
}