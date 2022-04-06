using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeCSharp.UI;
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void listPokemonsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ListPokemonsForm listPokemonsForm = new ListPokemonsForm();

        listPokemonsForm.ShowDialog(this);

        listPokemonsForm.Dispose();
    }

    private void searchPokemonToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SearchPokemonForm searchPokemonForm = new SearchPokemonForm();

        searchPokemonForm.ShowDialog(this);

        searchPokemonForm.Dispose();
    }

    private void listTypesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ListPokemonTypesForm listPokemonTypesForm = new ListPokemonTypesForm();

        listPokemonTypesForm.ShowDialog(this);

        listPokemonTypesForm.Dispose();
    }

    private void listMovesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ListPokemonMovesForm listPokemonMovesForm = new ListPokemonMovesForm();

        listPokemonMovesForm.ShowDialog(this);

        listPokemonMovesForm.Dispose();
    }

    private void listGamesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ListGamesForm listGamesForm = new ListGamesForm();

        listGamesForm.ShowDialog(this);

        listGamesForm.Dispose();
    }

    private void listRegionsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ListRegionsForm listRegionForm = new ListRegionsForm();

        listRegionForm.ShowDialog(this);

        listRegionForm.Dispose();
    }

    private void listLocationsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ListLocationsForm listLocationsForm = new ListLocationsForm();

        listLocationsForm.ShowDialog(this);

        listLocationsForm.Dispose();
    }

    private void listItemsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ListItemsForm listItemsForm = new ListItemsForm();

        listItemsForm.ShowDialog(this);

        listItemsForm.Dispose();
    }
}
