namespace FinalUrenRegistratie
{
    partial class GebruikerWijzigen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GebruikerWijzigen));
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbGebruiker = new System.Windows.Forms.ComboBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnFoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.tbControle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPermissie = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnWijzigen = new System.Windows.Forms.Button();
            this.tbWachtwoord = new System.Windows.Forms.TextBox();
            this.tbGebruikersnaam = new System.Windows.Forms.TextBox();
            this.tbAchternaam = new System.Windows.Forms.TextBox();
            this.tbVoornaam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOverzicht = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerwijderen.BackgroundImage")));
            this.btnVerwijderen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVerwijderen.Location = new System.Drawing.Point(467, 183);
            this.btnVerwijderen.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(92, 83);
            this.btnVerwijderen.TabIndex = 86;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 85;
            this.label7.Text = "Gebruiker";
            // 
            // cmbGebruiker
            // 
            this.cmbGebruiker.FormattingEnabled = true;
            this.cmbGebruiker.Location = new System.Drawing.Point(132, 12);
            this.cmbGebruiker.Name = "cmbGebruiker";
            this.cmbGebruiker.Size = new System.Drawing.Size(160, 24);
            this.cmbGebruiker.TabIndex = 84;
            this.cmbGebruiker.SelectedIndexChanged += new System.EventHandler(this.cmbGebruiker_SelectedIndexChanged);
            this.cmbGebruiker.Enter += new System.EventHandler(this.cmbGebruiker_Enter);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Location = new System.Drawing.Point(581, 183);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(92, 83);
            this.btnHome.TabIndex = 83;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(353, 157);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 82;
            // 
            // btnFoto
            // 
            this.btnFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFoto.BackgroundImage")));
            this.btnFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFoto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFoto.Location = new System.Drawing.Point(16, 183);
            this.btnFoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(108, 83);
            this.btnFoto.TabIndex = 81;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(132, 145);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(4);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(161, 121);
            this.pbFoto.TabIndex = 80;
            this.pbFoto.TabStop = false;
            // 
            // tbControle
            // 
            this.tbControle.Location = new System.Drawing.Point(513, 83);
            this.tbControle.Margin = new System.Windows.Forms.Padding(4);
            this.tbControle.Name = "tbControle";
            this.tbControle.PasswordChar = '*';
            this.tbControle.Size = new System.Drawing.Size(160, 22);
            this.tbControle.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 78;
            this.label6.Text = "Herhaal wachtwoord";
            // 
            // cmbPermissie
            // 
            this.cmbPermissie.FormattingEnabled = true;
            this.cmbPermissie.Items.AddRange(new object[] {
            "Gebruiker",
            "ProjectLeider"});
            this.cmbPermissie.Location = new System.Drawing.Point(513, 112);
            this.cmbPermissie.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPermissie.Name = "cmbPermissie";
            this.cmbPermissie.Size = new System.Drawing.Size(160, 24);
            this.cmbPermissie.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 76;
            this.label5.Text = "Permissie";
            // 
            // btnWijzigen
            // 
            this.btnWijzigen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWijzigen.BackgroundImage")));
            this.btnWijzigen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWijzigen.Location = new System.Drawing.Point(356, 183);
            this.btnWijzigen.Margin = new System.Windows.Forms.Padding(4);
            this.btnWijzigen.Name = "btnWijzigen";
            this.btnWijzigen.Size = new System.Drawing.Size(92, 83);
            this.btnWijzigen.TabIndex = 75;
            this.btnWijzigen.Text = "Wijzigen";
            this.btnWijzigen.UseVisualStyleBackColor = true;
            this.btnWijzigen.Click += new System.EventHandler(this.btnWijzigen_Click);
            // 
            // tbWachtwoord
            // 
            this.tbWachtwoord.Location = new System.Drawing.Point(513, 52);
            this.tbWachtwoord.Margin = new System.Windows.Forms.Padding(4);
            this.tbWachtwoord.Name = "tbWachtwoord";
            this.tbWachtwoord.PasswordChar = '*';
            this.tbWachtwoord.Size = new System.Drawing.Size(160, 22);
            this.tbWachtwoord.TabIndex = 74;
            // 
            // tbGebruikersnaam
            // 
            this.tbGebruikersnaam.Location = new System.Drawing.Point(132, 113);
            this.tbGebruikersnaam.Margin = new System.Windows.Forms.Padding(4);
            this.tbGebruikersnaam.Name = "tbGebruikersnaam";
            this.tbGebruikersnaam.Size = new System.Drawing.Size(160, 22);
            this.tbGebruikersnaam.TabIndex = 73;
            // 
            // tbAchternaam
            // 
            this.tbAchternaam.Location = new System.Drawing.Point(132, 83);
            this.tbAchternaam.Margin = new System.Windows.Forms.Padding(4);
            this.tbAchternaam.Name = "tbAchternaam";
            this.tbAchternaam.Size = new System.Drawing.Size(160, 22);
            this.tbAchternaam.TabIndex = 72;
            // 
            // tbVoornaam
            // 
            this.tbVoornaam.Location = new System.Drawing.Point(132, 51);
            this.tbVoornaam.Margin = new System.Windows.Forms.Padding(4);
            this.tbVoornaam.Name = "tbVoornaam";
            this.tbVoornaam.Size = new System.Drawing.Size(160, 22);
            this.tbVoornaam.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 70;
            this.label4.Text = "Wachtwoord";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "Gebruikersnaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "Achternaam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "Voornaam";
            // 
            // btnOverzicht
            // 
            this.btnOverzicht.Location = new System.Drawing.Point(513, 9);
            this.btnOverzicht.Margin = new System.Windows.Forms.Padding(4);
            this.btnOverzicht.Name = "btnOverzicht";
            this.btnOverzicht.Size = new System.Drawing.Size(160, 28);
            this.btnOverzicht.TabIndex = 87;
            this.btnOverzicht.Text = "Overzicht Gebruikers";
            this.btnOverzicht.UseVisualStyleBackColor = true;
            this.btnOverzicht.Click += new System.EventHandler(this.btnOverzicht_Click);
            // 
            // GebruikerWijzigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 280);
            this.Controls.Add(this.btnOverzicht);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbGebruiker);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.tbControle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbPermissie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnWijzigen);
            this.Controls.Add(this.tbWachtwoord);
            this.Controls.Add(this.tbGebruikersnaam);
            this.Controls.Add(this.tbAchternaam);
            this.Controls.Add(this.tbVoornaam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GebruikerWijzigen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gebruiker Wijzigen";
            this.Load += new System.EventHandler(this.GebruikerWijzigen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGebruiker;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox tbControle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPermissie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWijzigen;
        private System.Windows.Forms.TextBox tbWachtwoord;
        private System.Windows.Forms.TextBox tbGebruikersnaam;
        private System.Windows.Forms.TextBox tbAchternaam;
        private System.Windows.Forms.TextBox tbVoornaam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOverzicht;
    }
}