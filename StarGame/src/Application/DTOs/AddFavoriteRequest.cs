using System.Text.Json.Serialization;

namespace StarGame.Application.DTOs;

public class AddFavoriteRequest
{
    public int GameId { get; set; }
    public string GameName { get; set; } = string.Empty;
    [JsonPropertyName("background_image")]
    public string GameImage { get; set; } = string.Empty;
    public decimal GameRating { get; set; }
}