namespace FinalUrenRegistratie
{
    partial class GebruikerKoppel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GebruikerKoppel));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.cmbTaak = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGebruiker = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnOverzicht = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project";
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(152, 13);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(246, 24);
            this.cmbProject.TabIndex = 1;
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged);
            this.cmbProject.Click += new System.EventHandler(this.cmbProject_Click);
            // 
            // cmbTaak
            // 
            this.cmbTaak.FormattingEnabled = true;
            this.cmbTaak.Location = new System.Drawing.Point(152, 61);
            this.cmbTaak.Name = "cmbTaak";
            this.cmbTaak.Size = new System.Drawing.Size(246, 24);
            this.cmbTaak.TabIndex = 3;
            this.cmbTaak.Click += new System.EventHandler(this.cmbTaak_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Taak";
            // 
            // cmbGebruiker
            // 
            this.cmbGebruiker.FormattingEnabled = true;
            this.cmbGebruiker.Location = new System.Drawing.Point(152, 106);
            this.cmbGebruiker.Name = "cmbGebruiker";
            this.cmbGebruiker.Size = new System.Drawing.Size(246, 24);
            this.cmbGebruiker.TabIndex = 5;
            this.cmbGebruiker.SelectedIndexChanged += new System.EventHandler(this.cmbGebruiker_SelectedIndexChanged);
            this.cmbGebruiker.Click += new System.EventHandler(this.cmbGebruiker_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gebruiker";
            // 
            // btnhome
            // 
            this.btnhome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhome.BackgroundImage")));
            this.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnhome.Location = new System.Drawing.Point(294, 199);
            this.btnhome.Margin = new System.Windows.Forms.Padding(4);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(104, 76);
            this.btnhome.TabIndex = 29;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnToevoegen.BackgroundImage")));
            this.btnToevoegen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnToevoegen.Location = new System.Drawing.Point(152, 199);
            this.btnToevoegen.Margin = new System.Windows.Forms.Padding(4);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(106, 76);
            this.btnToevoegen.TabIndex = 28;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnOverzicht
            // 
            this.btnOverzicht.Location = new System.Drawing.Point(13, 148);
            this.btnOverzicht.Margin = new System.Windows.Forms.Padding(4);
            this.btnOverzicht.Name = "btnOverzicht";
            this.btnOverzicht.Size = new System.Drawing.Size(106, 28);
            this.btnOverzicht.TabIndex = 30;
            this.btnOverzicht.Text = "Overzicht";
            this.btnOverzicht.UseVisualStyleBackColor = true;
            this.btnOverzicht.Click += new System.EventHandler(this.btnOverzicht_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTerug.BackgroundImage")));
            this.btnTerug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTerug.Location = new System.Drawing.Point(16, 199);
            this.btnTerug.Margin = new System.Windows.Forms.Padding(4);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(106, 76);
            this.btnTerug.TabIndex = 31;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // GebruikerKoppel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 286);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnOverzicht);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.cmbGebruiker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTaak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.label1);
            this.Name = "GebruikerKoppel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gebruiker Koppel";
            this.Load += new System.EventHandler(this.GebruikerKoppel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.ComboBox cmbTaak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGebruiker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnOverzicht;
        private System.Windows.Forms.Button btnTerug;
    }
}