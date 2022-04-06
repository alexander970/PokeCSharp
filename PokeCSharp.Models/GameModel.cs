using System.ComponentModel.DataAnnotations;

namespace PokeCSharp.Models;
public class GameModel
{
    [Required]
    public int GameId { get; set; }

    [Required]
    public string GameName { get; set; } = default!;
}
