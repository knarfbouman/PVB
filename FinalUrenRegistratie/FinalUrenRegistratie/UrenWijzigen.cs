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
    public partial class UrenWijzigen : Form
    {
        UrenregistratieEntities urent = new UrenregistratieEntities();
        DateTime huidig = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

        public UrenWijzigen()
        {
            InitializeComponent();
        }

        private void btnOverzicht_Click(object sender, EventArgs e)
        {
            Close();
            UrenOverzicht uoverzicht = new UrenOverzicht();
            uoverzicht.Show();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Close();
            Home home = new Home();
            home.Show();
        }

        private void cmbGebruiker_Click(object sender, EventArgs e)
        {
            cmbTaak.DataSource = null;
            cmbProject.DataSource = null;
            cmbTaak.Items.Clear();
            cmbProject.Items.Clear();

            SqlConnection sqlconn = new SqlConnection(@"data source=MICHAEL-LAPTOP\SQLEXPRESS;initial catalog=Urenregistratie;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot");
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand("Select DISTINCT U.UserID, U.gebruikersnaam FROM UsersProjectenLijst UPL INNER JOIN Users U ON U.UserId = UPL.UserId", sqlconn);
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

        private void cmbTaak_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"data source=MICHAEL-LAPTOP\SQLEXPRESS;initial catalog=Urenregistratie;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot");
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand("SELECT T.TakenID, t.taak from UsersProjectenLijst UPL INNER JOIN Taken T ON T.takenId = UPL.TakenId WHERE userId= '" + cmbGebruiker.SelectedValue + "'", sqlconn);
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

        private void UrenWijzigen_Load(object sender, EventArgs e)
        {
            cmbProject.Enabled = false;
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void cmbTaak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTaak.Items.Count > 0 && cmbTaak.SelectedValue != null)
            {
                SqlConnection sqlconn = new SqlConnection(@"data source=MICHAEL-LAPTOP\SQLEXPRESS;initial catalog=Urenregistratie;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot");
                sqlconn.Open();
                SqlCommand sqlcom = new SqlCommand("SELECT DISTINCT P.projectId, p.projectNaam from UsersProjectenLijst UPL INNER JOIN Projecten P ON P.projectId = UPL.projectId WHERE UPL.takenId= " + cmbTaak.SelectedValue + "", sqlconn);
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

                SqlConnection sqlconn1 = new SqlConnection(@"data source=MICHAEL-LAPTOP\SQLEXPRESS;initial catalog=Urenregistratie;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot");
                sqlconn1.Open();
                SqlCommand sqlcom1 = new SqlCommand("SELECT * FROM Uren WHERE takenId= " + cmbTaak.SelectedValue + "", sqlconn1);
                SqlDataReader reader1;

                reader1 = sqlcom1.ExecuteReader();

                while (reader1.Read())
                {
                    int userprojectid = Convert.ToInt16(reader1.GetInt32(1));
                    DateTime datum = reader1.GetDateTime(5); 
                    int uren = Convert.ToInt16(reader1.GetInt32(6));
                    string omschrijving = reader1.GetString(7);

                    lblId.Text = userprojectid.ToString();
                    dtpDatum.Value = datum;
                    tbUren.Text = uren.ToString();
                    tbUrenVerantwoording.Text = omschrijving;
                }
                sqlconn1.Close();
            }
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt16(cmbProject.SelectedValue);
                Uren uur = urent.Uren.First(i => i.projectId == id);

                uur.userProjectId = Convert.ToInt16(lblId.Text);
                uur.userId = Convert.ToInt16(cmbGebruiker.SelectedValue);
                uur.projectId = Convert.ToInt16(cmbProject.SelectedValue);
                uur.takenId = Convert.ToInt16(cmbTaak.SelectedValue);
                uur.datum = Convert.ToDateTime(dtpDatum.Value);
                uur.uren1 = Convert.ToInt16(tbUren.Text);
                uur.urenVerantwoording = tbUrenVerantwoording.Text;

                urent.SaveChanges();

                MessageBox.Show("Taak is gewijzigd");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
