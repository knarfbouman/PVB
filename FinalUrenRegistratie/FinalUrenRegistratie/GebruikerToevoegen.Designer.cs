namespace FinalUrenRegistratie
{
    partial class GebruikerToevoegen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GebruikerToevoegen));
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnHome = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnFoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.tbControle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPermissie = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.tbWachtwoord = new System.Windows.Forms.TextBox();
            this.tbGebruikersnaam = new System.Windows.Forms.TextBox();
            this.tbAchternaam = new System.Windows.Forms.TextBox();
            this.tbVoornaam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Location = new System.Drawing.Point(538, 143);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(105, 84);
            this.btnHome.TabIndex = 63;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(354, 123);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 62;
            // 
            // btnFoto
            // 
            this.btnFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFoto.BackgroundImage")));
            this.btnFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFoto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFoto.Location = new System.Drawing.Point(17, 144);
            this.btnFoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(105, 84);
            this.btnFoto.TabIndex = 61;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(133, 107);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(4);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(161, 121);
            this.pbFoto.TabIndex = 60;
            this.pbFoto.TabStop = false;
            // 
            // tbControle
            // 
            this.tbControle.Location = new System.Drawing.Point(483, 41);
            this.tbControle.Margin = new System.Windows.Forms.Padding(4);
            this.tbControle.Name = "tbControle";
            this.tbControle.PasswordChar = '*';
            this.tbControle.Size = new System.Drawing.Size(160, 22);
            this.tbControle.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "Herhaal wachtwoord";
            // 
            // cmbPermissie
            // 
            this.cmbPermissie.FormattingEnabled = true;
            this.cmbPermissie.Items.AddRange(new object[] {
            "Gebruiker",
            "ProjectLeider"});
            this.cmbPermissie.Location = new System.Drawing.Point(483, 70);
            this.cmbPermissie.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPermissie.Name = "cmbPermissie";
            this.cmbPermissie.Size = new System.Drawing.Size(160, 24);
            this.cmbPermissie.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Permissie";
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnToevoegen.BackgroundImage")));
            this.btnToevoegen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnToevoegen.Location = new System.Drawing.Point(326, 143);
            this.btnToevoegen.Margin = new System.Windows.Forms.Padding(4);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(105, 84);
            this.btnToevoegen.TabIndex = 55;
            this.btnToevoegen.Text = "Voeg toe";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // tbWachtwoord
            // 
            this.tbWachtwoord.Location = new System.Drawing.Point(483, 10);
            this.tbWachtwoord.Margin = new System.Windows.Forms.Padding(4);
            this.tbWachtwoord.Name = "tbWachtwoord";
            this.tbWachtwoord.PasswordChar = '*';
            this.tbWachtwoord.Size = new System.Drawing.Size(160, 22);
            this.tbWachtwoord.TabIndex = 54;
            // 
            // tbGebruikersnaam
            // 
            this.tbGebruikersnaam.Location = new System.Drawing.Point(133, 75);
            this.tbGebruikersnaam.Margin = new System.Windows.Forms.Padding(4);
            this.tbGebruikersnaam.Name = "tbGebruikersnaam";
            this.tbGebruikersnaam.Size = new System.Drawing.Size(160, 22);
            this.tbGebruikersnaam.TabIndex = 53;
            // 
            // tbAchternaam
            // 
            this.tbAchternaam.Location = new System.Drawing.Point(133, 45);
            this.tbAchternaam.Margin = new System.Windows.Forms.Padding(4);
            this.tbAchternaam.Name = "tbAchternaam";
            this.tbAchternaam.Size = new System.Drawing.Size(160, 22);
            this.tbAchternaam.TabIndex = 52;
            // 
            // tbVoornaam
            // 
            this.tbVoornaam.Location = new System.Drawing.Point(133, 13);
            this.tbVoornaam.Margin = new System.Windows.Forms.Padding(4);
            this.tbVoornaam.Name = "tbVoornaam";
            this.tbVoornaam.Size = new System.Drawing.Size(160, 22);
            this.tbVoornaam.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Wachtwoord";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Gebruikersnaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Achternaam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Voornaam";
            // 
            // GebruikerToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 244);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.tbControle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbPermissie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.tbWachtwoord);
            this.Controls.Add(this.tbGebruikersnaam);
            this.Controls.Add(this.tbAchternaam);
            this.Controls.Add(this.tbVoornaam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GebruikerToevoegen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gebruiker Toevoegen";
            this.Load += new System.EventHandler(this.GebruikerToevoegen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox tbControle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPermissie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.TextBox tbWachtwoord;
        private System.Windows.Forms.TextBox tbGebruikersnaam;
        private System.Windows.Forms.TextBox tbAchternaam;
        private System.Windows.Forms.TextBox tbVoornaam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}