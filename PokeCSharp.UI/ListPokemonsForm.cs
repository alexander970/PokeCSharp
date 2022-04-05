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


        pokemonDataGridView.AutoGenerateColumns = true;
        pokemonDataGridView.DataSource = pokemons;
    }
}
