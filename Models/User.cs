using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace MyBlazorAppBlanza.Models;

[Table("users")]
public class User : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    [Column("username")]
    public string Username { get; set; } = "";

    [Column("password")]
    public string Password { get; set; } = "";

    [Column("player_name")]
    public string PlayerName { get; set; } = "";
}