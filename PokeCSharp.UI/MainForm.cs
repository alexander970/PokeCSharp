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
        ListPokemonsForm pokemonForm = new ListPokemonsForm();

        pokemonForm.ShowDialog(this);

        pokemonForm.Dispose();
    }

    private void searchPokemonToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SearchPokemonForm searchPokemonForm = new SearchPokemonForm();

        searchPokemonForm.ShowDialog(this);

        searchPokemonForm.Dispose();
    }
}
