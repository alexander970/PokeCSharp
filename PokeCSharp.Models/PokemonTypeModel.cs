using System.ComponentModel.DataAnnotations;

namespace PokeCSharp.Models;
public class PokemonTypeModel
{
    [Required]
    public int PokemonTypeId { get; set; }

    [Required]
    public string PokemonTypeIdentifier { get; set; } = default!;
}
