namespace FinalUrenRegistratie
{
    partial class ProjectWijzigen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectWijzigen));
            this.label6 = new System.Windows.Forms.Label();
            this.cbAfgesloten = new System.Windows.Forms.CheckBox();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnWijzgen = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.dtpEind = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProjectomschrijving = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProjectnaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnOverzicht = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 324);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 81;
            this.label6.Text = "Afgesloten";
            // 
            // cbAfgesloten
            // 
            this.cbAfgesloten.AutoSize = true;
            this.cbAfgesloten.Location = new System.Drawing.Point(165, 324);
            this.cbAfgesloten.Name = "cbAfgesloten";
            this.cbAfgesloten.Size = new System.Drawing.Size(18, 17);
            this.cbAfgesloten.TabIndex = 80;
            this.cbAfgesloten.UseVisualStyleBackColor = true;
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(165, 12);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(265, 24);
            this.cmbProject.TabIndex = 79;
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged);
            this.cmbProject.Click += new System.EventHandler(this.cmbProject_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 78;
            this.label5.Text = "Project";
            // 
            // btnWijzgen
            // 
            this.btnWijzgen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWijzgen.BackgroundImage")));
            this.btnWijzgen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWijzgen.Location = new System.Drawing.Point(165, 362);
            this.btnWijzgen.Margin = new System.Windows.Forms.Padding(4);
            this.btnWijzgen.Name = "btnWijzgen";
            this.btnWijzgen.Size = new System.Drawing.Size(116, 74);
            this.btnWijzgen.TabIndex = 77;
            this.btnWijzgen.Text = "Wijzigen";
            this.btnWijzgen.UseVisualStyleBackColor = true;
            this.btnWijzgen.Click += new System.EventHandler(this.btnWijzgen_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(162, 362);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 76;
            // 
            // dtpEind
            // 
            this.dtpEind.Location = new System.Drawing.Point(165, 280);
            this.dtpEind.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEind.Name = "dtpEind";
            this.dtpEind.Size = new System.Drawing.Size(265, 22);
            this.dtpEind.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 280);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 74;
            this.label4.Text = "Einddatum";
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(165, 237);
            this.dtpBegin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(265, 22);
            this.dtpBegin.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 72;
            this.label3.Text = "Begindatum";
            // 
            // tbProjectomschrijving
            // 
            this.tbProjectomschrijving.Location = new System.Drawing.Point(165, 93);
            this.tbProjectomschrijving.Margin = new System.Windows.Forms.Padding(4);
            this.tbProjectomschrijving.Multiline = true;
            this.tbProjectomschrijving.Name = "tbProjectomschrijving";
            this.tbProjectomschrijving.Size = new System.Drawing.Size(265, 123);
            this.tbProjectomschrijving.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 70;
            this.label2.Text = "Project omschrijving";
            // 
            // tbProjectnaam
            // 
            this.tbProjectnaam.Location = new System.Drawing.Point(165, 47);
            this.tbProjectnaam.Margin = new System.Windows.Forms.Padding(4);
            this.tbProjectnaam.Name = "tbProjectnaam";
            this.tbProjectnaam.Size = new System.Drawing.Size(265, 22);
            this.tbProjectnaam.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "Projectnaam";
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Location = new System.Drawing.Point(314, 362);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(116, 74);
            this.btnHome.TabIndex = 67;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnOverzicht
            // 
            this.btnOverzicht.Location = new System.Drawing.Point(314, 317);
            this.btnOverzicht.Margin = new System.Windows.Forms.Padding(4);
            this.btnOverzicht.Name = "btnOverzicht";
            this.btnOverzicht.Size = new System.Drawing.Size(116, 28);
            this.btnOverzicht.TabIndex = 82;
            this.btnOverzicht.Text = "Overzicht Projecten";
            this.btnOverzicht.UseVisualStyleBackColor = true;
            this.btnOverzicht.Click += new System.EventHandler(this.btnOverzicht_Click);
            // 
            // ProjectWijzigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 447);
            this.Controls.Add(this.btnOverzicht);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbAfgesloten);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnWijzgen);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dtpEind);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpBegin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbProjectomschrijving);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbProjectnaam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHome);
            this.Name = "ProjectWijzigen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Wijzigen";
            this.Load += new System.EventHandler(this.ProjectWijzigen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbAfgesloten;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWijzgen;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DateTimePicker dtpEind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbProjectomschrijving;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProjectnaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnOverzicht;
    }
}