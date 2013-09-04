namespace FinalUrenRegistratie
{
    partial class TaakToevoegen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaakToevoegen));
            this.lblError = new System.Windows.Forms.Label();
            this.tbTaakomschrijving = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTaaknaam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoegtoe = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(160, 247);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 68;
            // 
            // tbTaakomschrijving
            // 
            this.tbTaakomschrijving.Location = new System.Drawing.Point(163, 105);
            this.tbTaakomschrijving.Margin = new System.Windows.Forms.Padding(4);
            this.tbTaakomschrijving.Multiline = true;
            this.tbTaakomschrijving.Name = "tbTaakomschrijving";
            this.tbTaakomschrijving.Size = new System.Drawing.Size(265, 123);
            this.tbTaakomschrijving.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 66;
            this.label2.Text = "Taak omschrijving";
            // 
            // tbTaaknaam
            // 
            this.tbTaaknaam.Location = new System.Drawing.Point(163, 56);
            this.tbTaaknaam.Margin = new System.Windows.Forms.Padding(4);
            this.tbTaaknaam.Name = "tbTaaknaam";
            this.tbTaaknaam.Size = new System.Drawing.Size(265, 22);
            this.tbTaaknaam.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "Taaknaam";
            // 
            // btnVoegtoe
            // 
            this.btnVoegtoe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoegtoe.BackgroundImage")));
            this.btnVoegtoe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoegtoe.Location = new System.Drawing.Point(163, 247);
            this.btnVoegtoe.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoegtoe.Name = "btnVoegtoe";
            this.btnVoegtoe.Size = new System.Drawing.Size(116, 81);
            this.btnVoegtoe.TabIndex = 63;
            this.btnVoegtoe.Text = "Voeg toe";
            this.btnVoegtoe.UseVisualStyleBackColor = true;
            this.btnVoegtoe.Click += new System.EventHandler(this.btnVoegtoe_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Location = new System.Drawing.Point(312, 247);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(116, 81);
            this.btnHome.TabIndex = 62;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // cmbProject
            // 
            this.cmbProject.DisplayMember = "projectNaam";
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(163, 13);
            this.cmbProject.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(265, 24);
            this.cmbProject.TabIndex = 61;
            this.cmbProject.ValueMember = "projectNaam";
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged);
            this.cmbProject.Click += new System.EventHandler(this.cmbProject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Project";
            // 
            // TaakToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 340);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.tbTaakomschrijving);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTaaknaam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVoegtoe);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.label1);
            this.Name = "TaakToevoegen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taak Toevoegen";
            this.Load += new System.EventHandler(this.TaakToevoegen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox tbTaakomschrijving;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTaaknaam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoegtoe;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.Label label1;
    }
}