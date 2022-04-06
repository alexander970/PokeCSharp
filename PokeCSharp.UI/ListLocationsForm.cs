using PokeCSharp.DataAccess;
using PokeCSharp.Models;

namespace PokeCSharp.UI;

public partial class ListLocationsForm : Form
{
    public ListLocationsForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        List<LocationModel> locations = SqliteDataAccess.GetAllLocations();

        this.dataGridView.AutoGenerateColumns = true;
        this.dataGridView.DataSource = locations;
    }
}
