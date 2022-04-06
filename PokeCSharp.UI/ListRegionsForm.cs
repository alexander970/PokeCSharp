using PokeCSharp.DataAccess;
using PokeCSharp.Models;

namespace PokeCSharp.UI;

public partial class ListRegionsForm : Form
{
    public ListRegionsForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        List<RegionModel> regions = SqliteDataAccess.GetAllRegions();

        this.dataGridView.AutoGenerateColumns = true;
        this.dataGridView.DataSource = regions;
    }
}
