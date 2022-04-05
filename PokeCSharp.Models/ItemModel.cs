using System.ComponentModel.DataAnnotations;

namespace PokeCSharp.Models;
public class ItemModel
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string ItemIdentifier { get; set; } = default!;
}
