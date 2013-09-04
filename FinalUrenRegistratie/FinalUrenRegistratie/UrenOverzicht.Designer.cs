namespace FinalUrenRegistratie
{
    partial class UrenOverzicht
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrenOverzicht));
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnHome = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.urenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.cmbTaak = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGebruiker = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUren = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Location = new System.Drawing.Point(167, 453);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(129, 90);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTerug.BackgroundImage")));
            this.btnTerug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTerug.Location = new System.Drawing.Point(13, 453);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(129, 90);
            this.btnTerug.TabIndex = 4;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // urenBindingSource
            // 
            this.urenBindingSource.DataMember = "Uren";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(944, 377);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Project";
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(72, 23);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(158, 24);
            this.cmbProject.TabIndex = 7;
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged_1);
            this.cmbProject.Click += new System.EventHandler(this.cmbProject_Click);
            // 
            // cmbTaak
            // 
            this.cmbTaak.FormattingEnabled = true;
            this.cmbTaak.Location = new System.Drawing.Point(398, 23);
            this.cmbTaak.Name = "cmbTaak";
            this.cmbTaak.Size = new System.Drawing.Size(158, 24);
            this.cmbTaak.TabIndex = 9;
            this.cmbTaak.SelectedIndexChanged += new System.EventHandler(this.cmbTaak_SelectedIndexChanged_1);
            this.cmbTaak.Click += new System.EventHandler(this.cmbTaak_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Taak";
            // 
            // cmbGebruiker
            // 
            this.cmbGebruiker.FormattingEnabled = true;
            this.cmbGebruiker.Location = new System.Drawing.Point(799, 23);
            this.cmbGebruiker.Name = "cmbGebruiker";
            this.cmbGebruiker.Size = new System.Drawing.Size(158, 24);
            this.cmbGebruiker.TabIndex = 11;
            this.cmbGebruiker.SelectedIndexChanged += new System.EventHandler(this.cmbGebruiker_SelectedIndexChanged_1);
            this.cmbGebruiker.Click += new System.EventHandler(this.cmbGebruiker_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(722, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gebruiker";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Totaal Uren";
            // 
            // tbUren
            // 
            this.tbUren.Location = new System.Drawing.Point(410, 487);
            this.tbUren.Name = "tbUren";
            this.tbUren.Size = new System.Drawing.Size(130, 22);
            this.tbUren.TabIndex = 13;
            // 
            // UrenOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 553);
            this.Controls.Add(this.tbUren);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbGebruiker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTaak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnTerug);
            this.Name = "UrenOverzicht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uren Overzicht";
            this.Load += new System.EventHandler(this.UrenOverzicht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.BindingSource urenBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.ComboBox cmbTaak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGebruiker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUren;
    }
}