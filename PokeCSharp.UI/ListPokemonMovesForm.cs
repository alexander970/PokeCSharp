using PokeCSharp.DataAccess;
using PokeCSharp.Models;

namespace PokeCSharp.UI;

public partial class ListPokemonMovesForm : Form
{
    public ListPokemonMovesForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        List<PokemonMoveModel> pokemonMoves = SqliteDataAccess.GetAllPokemonsMoves();

        this.dataGridView.AutoGenerateColumns = true;
        this.dataGridView.DataSource = pokemonMoves;
    }
}
