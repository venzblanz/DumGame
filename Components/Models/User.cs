namespace MyBlazorAppBlanza.Components.Models;

public class User
{
    public int UserId { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string PlayerName { get; set; } = string.Empty;

    // One user has many scores and can leave many feedback entries
    public List<Score> Scores { get; set; } = new();
    public List<Feedback> Feedbacks { get; set; } = new();
}
