namespace FinalUrenRegistratie
{
    partial class TaakWijzigen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaakWijzigen));
            this.cmbTaken = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.tbTaakomschrijving = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnWijzigen = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOverzicht = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTaken
            // 
            this.cmbTaken.FormattingEnabled = true;
            this.cmbTaken.Location = new System.Drawing.Point(167, 60);
            this.cmbTaken.Name = "cmbTaken";
            this.cmbTaken.Size = new System.Drawing.Size(265, 24);
            this.cmbTaken.TabIndex = 78;
            this.cmbTaken.SelectedIndexChanged += new System.EventHandler(this.cmbTaken_SelectedIndexChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(164, 247);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 77;
            // 
            // tbTaakomschrijving
            // 
            this.tbTaakomschrijving.Location = new System.Drawing.Point(167, 105);
            this.tbTaakomschrijving.Margin = new System.Windows.Forms.Padding(4);
            this.tbTaakomschrijving.Multiline = true;
            this.tbTaakomschrijving.Name = "tbTaakomschrijving";
            this.tbTaakomschrijving.Size = new System.Drawing.Size(265, 123);
            this.tbTaakomschrijving.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 75;
            this.label2.Text = "Taak omschrijving";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 74;
            this.label3.Text = "Taken";
            // 
            // btnWijzigen
            // 
            this.btnWijzigen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWijzigen.BackgroundImage")));
            this.btnWijzigen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWijzigen.Location = new System.Drawing.Point(167, 247);
            this.btnWijzigen.Margin = new System.Windows.Forms.Padding(4);
            this.btnWijzigen.Name = "btnWijzigen";
            this.btnWijzigen.Size = new System.Drawing.Size(116, 81);
            this.btnWijzigen.TabIndex = 73;
            this.btnWijzigen.Text = "Wijzigen";
            this.btnWijzigen.UseVisualStyleBackColor = true;
            this.btnWijzigen.Click += new System.EventHandler(this.btnWijzigen_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Location = new System.Drawing.Point(316, 247);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(116, 81);
            this.btnHome.TabIndex = 72;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // cmbProject
            // 
            this.cmbProject.DisplayMember = "projectNaam";
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(167, 13);
            this.cmbProject.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(265, 24);
            this.cmbProject.TabIndex = 71;
            this.cmbProject.ValueMember = "projectNaam";
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged);
            this.cmbProject.Click += new System.EventHandler(this.cmbProject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "Project";
            // 
            // btnOverzicht
            // 
            this.btnOverzicht.Location = new System.Drawing.Point(14, 300);
            this.btnOverzicht.Margin = new System.Windows.Forms.Padding(4);
            this.btnOverzicht.Name = "btnOverzicht";
            this.btnOverzicht.Size = new System.Drawing.Size(116, 28);
            this.btnOverzicht.TabIndex = 79;
            this.btnOverzicht.Text = "Overzicht";
            this.btnOverzicht.UseVisualStyleBackColor = true;
            this.btnOverzicht.Click += new System.EventHandler(this.btnOverzicht_Click);
            // 
            // TaakWijzigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 344);
            this.Controls.Add(this.btnOverzicht);
            this.Controls.Add(this.cmbTaken);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.tbTaakomschrijving);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnWijzigen);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.label1);
            this.Name = "TaakWijzigen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taak Wijzigen";
            this.Load += new System.EventHandler(this.TaakWijzigen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTaken;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox tbTaakomschrijving;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnWijzigen;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOverzicht;
    }
}