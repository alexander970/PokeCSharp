using System.ComponentModel.DataAnnotations;

namespace PokeCSharp.Models;
public class LocationModel
{
    [Required]
    public int LocationId { get; set; }
    [Required]
    public string LocationName { get; set; } = default!;
}
