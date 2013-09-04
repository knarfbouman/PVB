namespace FinalUrenRegistratie
{
    partial class ProjectToevoegen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectToevoegen));
            this.btnVoegtoe = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // btnVoegtoe
            // 
            this.btnVoegtoe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoegtoe.BackgroundImage")));
            this.btnVoegtoe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoegtoe.Location = new System.Drawing.Point(164, 289);
            this.btnVoegtoe.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoegtoe.Name = "btnVoegtoe";
            this.btnVoegtoe.Size = new System.Drawing.Size(116, 74);
            this.btnVoegtoe.TabIndex = 62;
            this.btnVoegtoe.Text = "Voeg toe";
            this.btnVoegtoe.UseVisualStyleBackColor = true;
            this.btnVoegtoe.Click += new System.EventHandler(this.btnVoegtoe_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(160, 289);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 61;
            // 
            // dtpEind
            // 
            this.dtpEind.Location = new System.Drawing.Point(164, 246);
            this.dtpEind.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEind.Name = "dtpEind";
            this.dtpEind.Size = new System.Drawing.Size(265, 22);
            this.dtpEind.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "Einddatum";
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(164, 203);
            this.dtpBegin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(265, 22);
            this.dtpBegin.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Begindatum";
            // 
            // tbProjectomschrijving
            // 
            this.tbProjectomschrijving.Location = new System.Drawing.Point(164, 59);
            this.tbProjectomschrijving.Margin = new System.Windows.Forms.Padding(4);
            this.tbProjectomschrijving.Multiline = true;
            this.tbProjectomschrijving.Name = "tbProjectomschrijving";
            this.tbProjectomschrijving.Size = new System.Drawing.Size(265, 123);
            this.tbProjectomschrijving.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Project omschrijving";
            // 
            // tbProjectnaam
            // 
            this.tbProjectnaam.Location = new System.Drawing.Point(164, 13);
            this.tbProjectnaam.Margin = new System.Windows.Forms.Padding(4);
            this.tbProjectnaam.Name = "tbProjectnaam";
            this.tbProjectnaam.Size = new System.Drawing.Size(265, 22);
            this.tbProjectnaam.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Projectnaam";
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Location = new System.Drawing.Point(313, 289);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(116, 74);
            this.btnHome.TabIndex = 52;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // ProjectToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 375);
            this.Controls.Add(this.btnVoegtoe);
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
            this.Name = "ProjectToevoegen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Toevoegen";
            this.Load += new System.EventHandler(this.ProjectToevoegen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoegtoe;
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
    }
}