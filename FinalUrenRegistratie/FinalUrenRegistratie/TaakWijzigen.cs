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
    public partial class TaakWijzigen : Form
    {
        UrenregistratieEntities urent = new UrenregistratieEntities();

        public TaakWijzigen()
        {
            InitializeComponent();
        }

        private void btnWijzigen_Click(object sender, EventArgs e)
        {
            try
            {
                Taken taak = urent.Taken.First(i => i.taak == cmbTaken.Text);

                taak.projectId = Convert.ToInt16(cmbProject.SelectedValue);
                taak.taak = cmbTaken.SelectedItem.ToString();
                taak.taakOmschrijving = tbTaakomschrijving.Text;

                urent.SaveChanges();

                MessageBox.Show("Taak is gewijzigd");

                cmbProject.Text = null;
                cmbTaken.Text = null;
                tbTaakomschrijving.Text = "";
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
            cmbTaken.Items.Clear();
            cmbTaken.Text = "";
            SqlConnection sqlconn = new SqlConnection(@"data source=MICHAEL-LAPTOP\SQLEXPRESS;initial catalog=Urenregistratie;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot");
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand("SELECT * from Taken where projectId= '" + cmbProject.SelectedValue + "'", sqlconn);
            SqlDataReader reader;
            reader = sqlcom.ExecuteReader();

            while (reader.Read())
            {
                string taaknaam = reader.GetString(2);
                cmbTaken.Items.Add(taaknaam);
            }

            sqlconn.Close();
        }

        private void cmbProject_Click(object sender, EventArgs e)
        {
            cmbTaken.Items.Clear();
            cmbTaken.Text = "";
            SqlConnection sqlconn = new SqlConnection(@"data source=MICHAEL-LAPTOP\SQLEXPRESS;initial catalog=Urenregistratie;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot");
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand("SELECT * from Projecten", sqlconn);
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

        private void btnOverzicht_Click(object sender, EventArgs e)
        {
            Close();
            TakenOverzicht toverzicht = new TakenOverzicht();
            toverzicht.Show();
        }

        private void cmbTaken_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"data source=MICHAEL-LAPTOP\SQLEXPRESS;initial catalog=Urenregistratie;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot");
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand("SELECT * from Taken where taak= '" + cmbTaken.SelectedItem + "'", sqlconn);
            SqlDataReader reader;
            reader = sqlcom.ExecuteReader();

            while (reader.Read())
            {
                string taakomschrijving = reader.GetString(3);
                tbTaakomschrijving.Text = taakomschrijving;
            }

            sqlconn.Close();
        }

        private void TaakWijzigen_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
