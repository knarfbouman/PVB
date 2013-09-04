using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalUrenRegistratie
{
    public partial class ProjectToevoegen : Form
    {
        UrenregistratieEntities urent = new UrenregistratieEntities();

        public ProjectToevoegen()
        {
            InitializeComponent();
        }

        private void btnVoegtoe_Click(object sender, EventArgs e)
        {
            Projecten project = new Projecten();

            try
            {
                if (tbProjectnaam.Text != "" && tbProjectomschrijving.Text != "" && dtpBegin.ToString() != null && dtpEind.ToString() != null)
                {
                    project.projectNaam = tbProjectnaam.Text;
                    project.projectOmschrijving = tbProjectomschrijving.Text;
                    project.beginDatum = Convert.ToDateTime(dtpBegin.Text);
                    project.eindDatum = Convert.ToDateTime(dtpEind.Text);

                    urent.Projecten.Add(project);
                    urent.SaveChanges();

                    lblError.Text = "";

                    MessageBox.Show("Het project is toegevoegd");

                    tbProjectnaam.Text = "";
                    tbProjectomschrijving.Text = "";
                    dtpBegin.Value = DateTime.Now;
                    dtpEind.Value = DateTime.Now; 
                }
                else
                {
                    lblError.Text = "Niet alle velden zijn ingevuld";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Close();
            Home home = new Home();
            home.Show();
        }

        private void ProjectToevoegen_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
