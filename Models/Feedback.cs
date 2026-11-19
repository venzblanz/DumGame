using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace MyBlazorAppBlanza.Models;

[Table("feedbacks")]
public class Feedback : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    [Column("feedback_name")]
    public string FeedbackName { get; set; } = "Anonymous";

    [Column("rating")]
    public int Rating { get; set; }

    [Column("feedback_comment")]
    public string FeedbackComment { get; set; } = "";

    [Column("date_submitted")]
    public DateTime DateSubmitted { get; set; } = DateTime.UtcNow;

    [Column("user_id")]
    public long? UserId { get; set; }     // nullable — anonymous feedback is fine

    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }
}