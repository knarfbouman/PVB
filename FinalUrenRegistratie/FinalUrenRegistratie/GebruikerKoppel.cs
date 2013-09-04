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
    public partial class GebruikerKoppel : Form
    {
        UrenregistratieEntities urent = new UrenregistratieEntities();
        
        public GebruikerKoppel()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Close();
            Home home = new Home();
            home.Show();
        }

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTaak.DataSource = null;
            SqlConnection sqlconn = new SqlConnection(@"data source=MICHAEL-LAPTOP\SQLEXPRESS;initial catalog=Urenregistratie;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot");
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand("SELECT * from Taken where projectId= '" + cmbProject.SelectedValue + "'", sqlconn);
            SqlDataReader reader;
            reader = sqlcom.ExecuteReader();
            sqlconn.Close();
        }

        private void cmbProject_Click(object sender, EventArgs e)
        {
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

        private void cmbGebruiker_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = @"data source=MICHAEL-LAPTOP\SQLEXPRESS;initial catalog=Urenregistratie;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot";
            string query = "SELECT * from Users where gebruikersnaam= '" + cmbGebruiker.Text + "'";
            SqlConnection sqlconn = new SqlConnection(constring);
            SqlCommand sqlcom = new SqlCommand(query, sqlconn);
            SqlDataReader reader;

            sqlconn.Open();
            reader = sqlcom.ExecuteReader();
            sqlconn.Close(); 
        }

        private void cmbGebruiker_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"data source=MICHAEL-LAPTOP\SQLEXPRESS;initial catalog=Urenregistratie;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot");
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand("SELECT * from Users", sqlconn);
            SqlDataReader reader;

            reader = sqlcom.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("userId", typeof(string));
            dt.Columns.Add("gebruikersnaam", typeof(string));
            dt.Load(reader);

            cmbGebruiker.ValueMember = "userId";
            cmbGebruiker.DisplayMember = "gebruikersnaam";
            cmbGebruiker.DataSource = dt;

            sqlconn.Close();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            UsersProjectenLijst uproject = new UsersProjectenLijst();

            uproject.projectId = Convert.ToInt16(cmbProject.SelectedValue);
            uproject.takenId = Convert.ToInt16(cmbTaak.SelectedValue);
            uproject.userId = Convert.ToInt16(cmbGebruiker.SelectedValue);

            urent.UsersProjectenLijst.Add(uproject);
            urent.SaveChanges();

            MessageBox.Show("De gebruiker is gekoppeld");

            cmbProject.Text = null;
            cmbTaak.Text = null;
            cmbGebruiker.Text = null;
        }

        private void cmbTaak_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"data source=MICHAEL-LAPTOP\SQLEXPRESS;initial catalog=Urenregistratie;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot");
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand("SELECT * from Taken where projectId= '" + cmbProject.SelectedValue + "'", sqlconn);
            SqlDataReader reader;

            reader = sqlcom.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("takenId", typeof(string));
            dt.Columns.Add("taak", typeof(string));
            dt.Load(reader);

            cmbTaak.ValueMember = "takenId";
            cmbTaak.DisplayMember = "taak";
            cmbTaak.DataSource = dt;

            sqlconn.Close();
        }

        private void btnOverzicht_Click(object sender, EventArgs e)
        {
            Close();
            KoppelOverzicht koverzicht = new KoppelOverzicht();
            koverzicht.Show();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
            UrenToevoegen utoevoegen = new UrenToevoegen();
            utoevoegen.Show();
        }

        private void GebruikerKoppel_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
