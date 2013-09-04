using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalUrenRegistratie
{
    public partial class ProjectWijzigen : Form
    {
        UrenregistratieEntities urent = new UrenregistratieEntities();

        public ProjectWijzigen()
        {
            InitializeComponent();
        }

        private void btnWijzgen_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbProjectnaam.Text != "" && tbProjectomschrijving.Text != "" && dtpBegin.ToString() != null && dtpEind.ToString() != null)
                {
                    Projecten project = urent.Projecten.First(i => i.projectNaam == tbProjectnaam.Text);

                    project.projectNaam = tbProjectnaam.Text;
                    project.projectOmschrijving = tbProjectomschrijving.Text;
                    project.beginDatum = Convert.ToDateTime(dtpBegin.Text);
                    project.eindDatum = Convert.ToDateTime(dtpEind.Text);
                    project.afgesloten = cbAfgesloten.Checked;

                    urent.SaveChanges();

                    lblError.Text = "";

                    MessageBox.Show("Het project is gewijzigd");

                    cmbProject.Text = null;
                    tbProjectnaam.Text = "";
                    tbProjectomschrijving.Text = "";
                    dtpBegin.Value = DateTime.Now;
                    dtpEind.Value = DateTime.Now; 
                    cbAfgesloten.Checked = false;
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

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"data source=MICHAEL-LAPTOP\SQLEXPRESS;initial catalog=Urenregistratie;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot");
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand("SELECT * from Projecten where projectNaam= '" + cmbProject.Text + "'", sqlconn);
            SqlDataReader reader;

            reader = sqlcom.ExecuteReader();

            while (reader.Read())
            {
                string projectnaam = reader.GetString(1);
                string projectomschrijving = reader.GetString(2);
                DateTime begindatum = reader.GetDateTime(3);
                DateTime einddatum = reader.GetDateTime(4);
                bool afgesloten = reader.GetBoolean(5);

                tbProjectnaam.Text = projectnaam;
                tbProjectomschrijving.Text = projectomschrijving;
                dtpBegin.Value = begindatum;
                dtpBegin.Enabled = false;
                dtpEind.Value = einddatum;
                cbAfgesloten.Checked = Convert.ToBoolean(afgesloten);
            }
            sqlconn.Close();
        }

        private void cmbProject_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"data source=MICHAEL-LAPTOP\SQLEXPRESS;initial catalog=Urenregistratie;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot");
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand("SELECT projectId, projectNaam from Projecten", sqlconn);
            SqlDataReader reader;

            reader = sqlcom.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("projectId", typeof(string));
            dt.Columns.Add("projectNaam", typeof(string));
            dt.Load(reader);

            cmbProject.ValueMember = "projectId";
            cmbProject.DisplayMember = "projectNaam";
            cmbProject.DataSource = dt;

            sqlconn.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Close();
            Home home = new Home();
            home.Show();
        }

        private void btnOverzicht_Click(object sender, EventArgs e)
        {
            Close();
            ProjectenOverzicht poverzicht = new ProjectenOverzicht();
            poverzicht.Show();
        }

        private void ProjectWijzigen_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

    }
}
