namespace MyBlazorAppBlanza.Models;

public class Feedback
{
    public int FeedbackId { get; set; }
    public string FeedbackName { get; set; } = string.Empty;
    public int Rating { get; set; }
    public string FeedbackComment { get; set; } = string.Empty;
    public DateTime DateSubmitted { get; set; } = DateTime.Now;

    // Optional link to a user (null = anonymous feedback)
    public int? UserId { get; set; }
    public User? User { get; set; }
}