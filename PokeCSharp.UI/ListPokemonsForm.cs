using PokeCSharp.DataAccess;
using PokeCSharp.Models;

namespace PokeCSharp.UI;

public partial class ListPokemonsForm : Form
{
    public ListPokemonsForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        List<PokemonModel> pokemons = SqliteDataAccess.GetAllPokemons();


        this.pokemonDataGridView.AutoGenerateColumns = true;
        this.pokemonDataGridView.DataSource = pokemons;
    }
}
