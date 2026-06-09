using StarGame.Domain.Enum;

namespace StarGame.Domain.Entities;

public class GameEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public GameStatusEnum Status { get; set; }
    public decimal? Nota { get; set; }
    public DateTime CreatedAt { get; set; }
}