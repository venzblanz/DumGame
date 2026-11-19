using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace MyBlazorAppBlanza.Models;

[Table("scores")]
public class Score : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    [Column("points")]
    public int Points { get; set; }

    [Column("date_played")]
    public DateTime DatePlayed { get; set; } = DateTime.UtcNow;

    [Column("user_id")]
    public long UserId { get; set; }

    [Column("game_id")]
    public long GameId { get; set; }

    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }   // null = active, filled = soft-deleted
}