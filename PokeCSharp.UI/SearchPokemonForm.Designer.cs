namespace PokeCSharp.UI;

partial class SearchPokemonForm
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pokemonName = new System.Windows.Forms.TextBox();
            this.pokemonHeight = new System.Windows.Forms.NumericUpDown();
            this.pokemonWeight = new System.Windows.Forms.NumericUpDown();
            this.pokemonBaseExperience = new System.Windows.Forms.NumericUpDown();
            this.pokemonOrder = new System.Windows.Forms.NumericUpDown();
            this.pokemonIsDefault = new System.Windows.Forms.CheckBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.pokemonImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBaseExperience)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(62, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.PlaceholderText = "Pokemon name";
            this.searchBox.Size = new System.Drawing.Size(274, 26);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Base experience";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Order";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Is Default";
            // 
            // pokemonName
            // 
            this.pokemonName.Location = new System.Drawing.Point(239, 213);
            this.pokemonName.Name = "pokemonName";
            this.pokemonName.ReadOnly = true;
            this.pokemonName.Size = new System.Drawing.Size(144, 26);
            this.pokemonName.TabIndex = 8;
            // 
            // pokemonHeight
            // 
            this.pokemonHeight.Location = new System.Drawing.Point(239, 245);
            this.pokemonHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pokemonHeight.Name = "pokemonHeight";
            this.pokemonHeight.Size = new System.Drawing.Size(144, 26);
            this.pokemonHeight.TabIndex = 9;
            // 
            // pokemonWeight
            // 
            this.pokemonWeight.Location = new System.Drawing.Point(239, 284);
            this.pokemonWeight.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.pokemonWeight.Name = "pokemonWeight";
            this.pokemonWeight.Size = new System.Drawing.Size(144, 26);
            this.pokemonWeight.TabIndex = 10;
            // 
            // pokemonBaseExperience
            // 
            this.pokemonBaseExperience.Location = new System.Drawing.Point(239, 322);
            this.pokemonBaseExperience.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.pokemonBaseExperience.Name = "pokemonBaseExperience";
            this.pokemonBaseExperience.Size = new System.Drawing.Size(144, 26);
            this.pokemonBaseExperience.TabIndex = 11;
            // 
            // pokemonOrder
            // 
            this.pokemonOrder.Location = new System.Drawing.Point(239, 356);
            this.pokemonOrder.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.pokemonOrder.Name = "pokemonOrder";
            this.pokemonOrder.Size = new System.Drawing.Size(144, 26);
            this.pokemonOrder.TabIndex = 12;
            // 
            // pokemonIsDefault
            // 
            this.pokemonIsDefault.AutoSize = true;
            this.pokemonIsDefault.Location = new System.Drawing.Point(242, 397);
            this.pokemonIsDefault.Name = "pokemonIsDefault";
            this.pokemonIsDefault.Size = new System.Drawing.Size(15, 14);
            this.pokemonIsDefault.TabIndex = 13;
            this.pokemonIsDefault.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(342, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(144, 28);
            this.searchButton.TabIndex = 14;
            this.searchButton.Text = "Search pokemon";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // pokemonImage
            // 
            this.pokemonImage.Image = global::PokeCSharp.UI.Properties.Resources._0;
            this.pokemonImage.Location = new System.Drawing.Point(184, 77);
            this.pokemonImage.Name = "pokemonImage";
            this.pokemonImage.Size = new System.Drawing.Size(96, 96);
            this.pokemonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pokemonImage.TabIndex = 15;
            this.pokemonImage.TabStop = false;
            // 
            // SearchPokemonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 479);
            this.Controls.Add(this.pokemonImage);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.pokemonIsDefault);
            this.Controls.Add(this.pokemonOrder);
            this.Controls.Add(this.pokemonBaseExperience);
            this.Controls.Add(this.pokemonWeight);
            this.Controls.Add(this.pokemonHeight);
            this.Controls.Add(this.pokemonName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBox);
            this.Name = "SearchPokemonForm";
            this.Text = "SearchPokemonForm";
            this.Load += new System.EventHandler(this.SearchPokemonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pokemonHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBaseExperience)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox searchBox;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private TextBox pokemonName;
    private NumericUpDown pokemonHeight;
    private NumericUpDown pokemonWeight;
    private NumericUpDown pokemonBaseExperience;
    private NumericUpDown pokemonOrder;
    private CheckBox pokemonIsDefault;
    private Button searchButton;
    private PictureBox pokemonImage;
}
