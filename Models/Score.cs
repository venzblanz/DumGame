namespace MyBlazorAppBlanza.Models;

public class Score
{
    public int ScoreId { get; set; }

    // Named Points because a class can't have a member with the same name as itself
    public int Points { get; set; }
    public DateTime DatePlayed { get; set; } = DateTime.Now;

    // Foreign keys: this score belongs to one user and one game
    public int UserId { get; set; }
    public User? User { get; set; }

    public int GameId { get; set; }
    public Game? Game { get; set; }
}
