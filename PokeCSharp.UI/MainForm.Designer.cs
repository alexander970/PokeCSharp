namespace PokeCSharp.UI;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pokemonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listPokemonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokemonsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // pokemonsToolStripMenuItem
            // 
            this.pokemonsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listPokemonsToolStripMenuItem,
            this.searchPokemonToolStripMenuItem});
            this.pokemonsToolStripMenuItem.Name = "pokemonsToolStripMenuItem";
            this.pokemonsToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.pokemonsToolStripMenuItem.Text = "Pokemons";
            // 
            // listPokemonsToolStripMenuItem
            // 
            this.listPokemonsToolStripMenuItem.Name = "listPokemonsToolStripMenuItem";
            this.listPokemonsToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.listPokemonsToolStripMenuItem.Text = "List pokemons";
            this.listPokemonsToolStripMenuItem.Click += new System.EventHandler(this.listPokemonsToolStripMenuItem_Click);
            // 
            // searchPokemonToolStripMenuItem
            // 
            this.searchPokemonToolStripMenuItem.Name = "searchPokemonToolStripMenuItem";
            this.searchPokemonToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.searchPokemonToolStripMenuItem.Text = "Search pokemon";
            this.searchPokemonToolStripMenuItem.Click += new System.EventHandler(this.searchPokemonToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem pokemonsToolStripMenuItem;
    private ToolStripMenuItem listPokemonsToolStripMenuItem;
    private ToolStripMenuItem searchPokemonToolStripMenuItem;
}
