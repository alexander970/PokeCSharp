using PokeCSharp.DataAccess;
using PokeCSharp.Models;

namespace PokeCSharp.UI;

public partial class ListGamesForm : Form
{
    public ListGamesForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        List<GameModel> games = SqliteDataAccess.GetAllGames();

        this.dataGridView.AutoGenerateColumns = true;
        this.dataGridView.DataSource = games;
    }
}
