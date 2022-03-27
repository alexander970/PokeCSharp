namespace PokeCSharp.Models
{
    public class PokemonModel
    {
        public int Id { get; set; }
        public string? Identifier { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int BaseExperience { get; set; }
        public int Order { get; set; }
        public bool IsDefault { get; set; }


    }
}
