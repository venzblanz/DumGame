namespace MyBlazorAppBlanza.Models;

public class Game
{
    public int GameId { get; set; }
    public string GameName { get; set; } = string.Empty;
    public string ThumbnailImg { get; set; } = string.Empty;
    public string Route { get; set; } = string.Empty;

    // One game has many scores
    public List<Score> Scores { get; set; } = new();
}
