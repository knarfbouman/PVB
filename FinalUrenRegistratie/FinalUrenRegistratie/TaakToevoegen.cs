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
    public partial class TaakToevoegen : Form
    {
        UrenregistratieEntities urent = new UrenregistratieEntities();

        public TaakToevoegen()
        {
            InitializeComponent();
        }

        private void btnVoegtoe_Click(object sender, EventArgs e)
        {
            Taken taken = new Taken();

            try
            {
                if (tbTaaknaam.Text == "" || tbTaakomschrijving.Text == "")
                {
                    lblError.Text = "Er zijn een of meerder velden niet ingevuld";
                }
                else
                {
                    taken.taak = tbTaaknaam.Text;
                    taken.taakOmschrijving = tbTaakomschrijving.Text;

                    string projectnaam = cmbProject.SelectedValue.ToString();

                    var projectid = from proj in urent.Projecten
                                    where proj.projectNaam == projectnaam
                                    select proj.projectId;

                    foreach (var projid in projectid)
                    {
                        taken.projectId = projid;
                    }

                    urent.Taken.Add(taken);
                    urent.SaveChanges();

                    MessageBox.Show("Taak is toegevoegd");

                    cmbProject.Text = "";
                    tbTaaknaam.Text = "";
                    tbTaakomschrijving.Text = "";
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

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = cmbProject.SelectedValue.ToString();
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

            cmbProject.ValueMember = "projectNaam";
            cmbProject.DisplayMember = "projectNaam";
            cmbProject.DataSource = dt;

            sqlconn.Close();
        }

        private void TaakToevoegen_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
