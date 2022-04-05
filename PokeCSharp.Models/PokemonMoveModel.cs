using System.ComponentModel.DataAnnotations;

namespace PokeCSharp.Models;
public class PokemonMoveModel
{
    [Required]
    public int PokemonMoveId { get; set; }

    [Required]
    public string PokemonMoveIdentifier { get; set; } = default!;
}
