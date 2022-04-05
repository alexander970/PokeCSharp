using System.ComponentModel.DataAnnotations;

namespace PokeCSharp.Models;
public class RegionModel
{
    [Required]
    public int RegionId { get; set; }

    [Required]
    public string RegionName { get; set; } = default!;
}
