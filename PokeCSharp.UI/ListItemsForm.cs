using PokeCSharp.DataAccess;
using PokeCSharp.Models;

namespace PokeCSharp.UI;

public partial class ListItemsForm : Form
{
    public ListItemsForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        List<ItemModel> items = SqliteDataAccess.GetAllItems();

        this.dataGridView.AutoGenerateColumns = true;
        this.dataGridView.DataSource = items;
    }
}
