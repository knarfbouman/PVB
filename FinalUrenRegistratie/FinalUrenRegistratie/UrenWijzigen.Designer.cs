namespace FinalUrenRegistratie
{
    partial class UrenWijzigen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrenWijzigen));
            this.btnOverzicht = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnhome = new System.Windows.Forms.Button();
            this.tbUrenVerantwoording = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUren = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Datum = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.cmbTaak = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGebruiker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOverzicht
            // 
            this.btnOverzicht.Location = new System.Drawing.Point(14, 391);
            this.btnOverzicht.Name = "btnOverzicht";
            this.btnOverzicht.Size = new System.Drawing.Size(106, 28);
            this.btnOverzicht.TabIndex = 47;
            this.btnOverzicht.Text = "Overzicht";
            this.btnOverzicht.UseVisualStyleBackColor = true;
            this.btnOverzicht.Click += new System.EventHandler(this.btnOverzicht_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(100, 94);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 17);
            this.lblId.TabIndex = 46;
            this.lblId.Visible = false;
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(158, 88);
            this.cmbProject.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(255, 24);
            this.cmbProject.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Project";
            // 
            // btnhome
            // 
            this.btnhome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhome.BackgroundImage")));
            this.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnhome.Location = new System.Drawing.Point(307, 342);
            this.btnhome.Margin = new System.Windows.Forms.Padding(4);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(104, 77);
            this.btnhome.TabIndex = 43;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // tbUrenVerantwoording
            // 
            this.tbUrenVerantwoording.Location = new System.Drawing.Point(156, 191);
            this.tbUrenVerantwoording.Margin = new System.Windows.Forms.Padding(4);
            this.tbUrenVerantwoording.Multiline = true;
            this.tbUrenVerantwoording.Name = "tbUrenVerantwoording";
            this.tbUrenVerantwoording.Size = new System.Drawing.Size(255, 143);
            this.tbUrenVerantwoording.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Urenverantwoording";
            // 
            // tbUren
            // 
            this.tbUren.Location = new System.Drawing.Point(158, 159);
            this.tbUren.Margin = new System.Windows.Forms.Padding(4);
            this.tbUren.Name = "tbUren";
            this.tbUren.Size = new System.Drawing.Size(255, 22);
            this.tbUren.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Uren";
            // 
            // Datum
            // 
            this.Datum.AutoSize = true;
            this.Datum.Location = new System.Drawing.Point(11, 127);
            this.Datum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(49, 17);
            this.Datum.TabIndex = 38;
            this.Datum.Text = "Datum";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(158, 120);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(255, 22);
            this.dtpDatum.TabIndex = 37;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnToevoegen.BackgroundImage")));
            this.btnToevoegen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnToevoegen.Location = new System.Drawing.Point(156, 342);
            this.btnToevoegen.Margin = new System.Windows.Forms.Padding(4);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(106, 77);
            this.btnToevoegen.TabIndex = 36;
            this.btnToevoegen.Text = "Wijzigen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // cmbTaak
            // 
            this.cmbTaak.FormattingEnabled = true;
            this.cmbTaak.Location = new System.Drawing.Point(158, 54);
            this.cmbTaak.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTaak.Name = "cmbTaak";
            this.cmbTaak.Size = new System.Drawing.Size(255, 24);
            this.cmbTaak.TabIndex = 35;
            this.cmbTaak.SelectedIndexChanged += new System.EventHandler(this.cmbTaak_SelectedIndexChanged);
            this.cmbTaak.Click += new System.EventHandler(this.cmbTaak_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Taak";
            // 
            // cmbGebruiker
            // 
            this.cmbGebruiker.FormattingEnabled = true;
            this.cmbGebruiker.Location = new System.Drawing.Point(158, 13);
            this.cmbGebruiker.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGebruiker.Name = "cmbGebruiker";
            this.cmbGebruiker.Size = new System.Drawing.Size(255, 24);
            this.cmbGebruiker.TabIndex = 33;
            this.cmbGebruiker.Click += new System.EventHandler(this.cmbGebruiker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Gebruiker";
            // 
            // UrenWijzigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 432);
            this.Controls.Add(this.btnOverzicht);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.tbUrenVerantwoording);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUren);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.cmbTaak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbGebruiker);
            this.Controls.Add(this.label1);
            this.Name = "UrenWijzigen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uren Wijzigen";
            this.Load += new System.EventHandler(this.UrenWijzigen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOverzicht;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.TextBox tbUrenVerantwoording;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUren;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Datum;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.ComboBox cmbTaak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGebruiker;
        private System.Windows.Forms.Label label1;
    }
}