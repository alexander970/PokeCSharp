using PokeCSharp.DataAccess;
using PokeCSharp.Models;

namespace PokeCSharp.UI;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        List<PokemonModel> pokemons = SqliteDataAccess.LoadPokemons();


        pokemonDataGridView.AutoGenerateColumns = true;
        pokemonDataGridView.DataSource = pokemons;
    }
}
