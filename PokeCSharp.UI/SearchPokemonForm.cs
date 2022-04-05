using PokeCSharp.DataAccess;
using PokeCSharp.Models;
using PokeCSharp.UI.Properties;
using System.Resources;

namespace PokeCSharp.UI;
public partial class SearchPokemonForm : Form
{
    public SearchPokemonForm()
    {
        InitializeComponent();
    }

    private static Image GetPokemonImage(int pokemonId)
    {
        ResourceManager resourceManager = Resources.ResourceManager;
        object? pokemonImageObject = resourceManager.GetObject($"_{pokemonId}");

        Image pokemonImage = (pokemonImageObject != null)
            ? (Image)pokemonImageObject
            : Resources._0;
        return pokemonImage;
    }

    private void SearchPokemon()
    {
        string pokemonName = this.searchBox.Text;
        PokemonModel? pokemon = SqliteDataAccess.SearchPokemon(pokemonName);

        if (pokemon != null)
        {
            Image pokemonImage = GetPokemonImage(pokemon.PokemonId);

            this.pokemonName.Text = pokemon.PokemonName;
            this.pokemonHeight.Value = pokemon.Height;
            this.pokemonWeight.Value = pokemon.Weight;
            this.pokemonBaseExperience.Value = pokemon.BaseExperience;
            this.pokemonOrder.Value = pokemon.Order;
            this.pokemonIsDefault.Checked = pokemon.IsDefault;
            this.pokemonImage.Image = pokemonImage;

        }
        else
        {
            Image pokemonImage = Resources._0;

            this.pokemonName.Text = "";
            this.pokemonHeight.Value = 0;
            this.pokemonWeight.Value = 0;
            this.pokemonBaseExperience.Value = 0;
            this.pokemonOrder.Value = 0;
            this.pokemonIsDefault.Checked = false;
            this.pokemonImage.Image = pokemonImage;

        }
    }

   

    private void SearchPokemonForm_Load(object sender, EventArgs e)
    {

    }

    private void searchBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void searchButton_Click(object sender, EventArgs e)
    {
        SearchPokemon();
    }

    
}
