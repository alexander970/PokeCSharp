namespace PokeCSharp.UI;

partial class ListPokemonsForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.pokemonDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pokemonDataGridView
            // 
            this.pokemonDataGridView.AllowUserToAddRows = false;
            this.pokemonDataGridView.AllowUserToDeleteRows = false;
            this.pokemonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pokemonDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pokemonDataGridView.Location = new System.Drawing.Point(0, 0);
            this.pokemonDataGridView.Name = "pokemonDataGridView";
            this.pokemonDataGridView.ReadOnly = true;
            this.pokemonDataGridView.RowHeadersWidth = 49;
            this.pokemonDataGridView.RowTemplate.Height = 28;
            this.pokemonDataGridView.Size = new System.Drawing.Size(800, 450);
            this.pokemonDataGridView.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pokemonDataGridView);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PokeCSharp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataGridView)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private DataGridView pokemonDataGridView;
}
