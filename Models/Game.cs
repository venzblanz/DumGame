using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace MyBlazorAppBlanza.Models;

[Table("games")]
public class Game : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    [Column("game_name")]
    public string GameName { get; set; } = "";

    [Column("thumbnail_img")]
    public string ThumbnailImg { get; set; } = "";

    [Column("route")]
    public string Route { get; set; } = "";
}