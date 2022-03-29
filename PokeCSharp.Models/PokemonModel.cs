using System.ComponentModel.DataAnnotations;

namespace PokeCSharp.Models;

public class PokemonModel
{
    
    [Required]
    public int PokemonId { get; set; }

    [Required]
    public string PokemonName { get; set; } = string.Empty;

    [Required]
    public int Height { get; set; }

    [Required]
    public int Weight { get; set; }

    [Required]
    public int BaseExperience { get; set; }

    [Required]
    public int Order { get; set; }

    [Required]
    public bool IsDefault { get; set; }
}
