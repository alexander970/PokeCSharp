using PokeCSharp.DataAccess;
using PokeCSharp.Models;

namespace PokeCSharp.UI;

public partial class ListPokemonTypesForm : Form
{
    public ListPokemonTypesForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        List<PokemonTypeModel> pokemonTypes = SqliteDataAccess.GetAllPokemonTypes();


        this.dataGridView.AutoGenerateColumns = true;
        this.dataGridView.DataSource = pokemonTypes;
    }
}
