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
    public partial class UrenOverzicht : Form
    {
        public UrenOverzicht()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
            UrenWijzigen uwijzigen = new UrenWijzigen();
            uwijzigen.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Close();
            Home home = new Home();
            home.Show();
        }

        private void UrenOverzicht_Load(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"data source=MICHAEL-LAPTOP\SQLEXPRESS;initial catalog=Urenregistratie;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot");
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand("SELECT urenId, userProjectId, U.gebruikersNaam, P.projectNaam, T.taak, datum, uren, urenVerantwoording FROM dbo.Uren Ur INNER JOIN Users U ON U.userId = Ur.userId INNER JOIN Projecten P ON P.projectId = Ur.projectId INNER JOIN Taken T ON T.takenId = Ur.takenId", sqlconn);
            SqlDataReader reader;

            reader = sqlcom.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dataGridView1.DataSource = dt;

            tbUren.Enabled = false;
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
            }
            tbUren.Text = sum.ToString();
        }

        private void cmbProject_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            cmbGebruiker.Text = "";
            cmbTaak.Text = "";
            tbUren.Text = "";

            SqlConnection sqlconn = new SqlConnection(@"data source=MICHAEL-LAPTOP\SQLEXPRESS;initial catalog=Urenregistratie;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot");
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand("SELECT projectId, projectNaam from Projecten", sqlconn);
            SqlDataReader reader;

            reader = sqlcom.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("projectId", typeof(string));
            dt.Columns.Add("projectnaam", typeof(string));
            dt.Load(reader);

            cmbProject.ValueMember = "projectId";
            cmbProject.DisplayMember = "projectnaam";
            cmbProject.DataSource = dt;

            sqlconn.Close();

        }

        private void cmbTaak_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            cmbGebruiker.Text = "";
            cmbProject.Text = "";
            tbUren.Text = "";

            SqlConnection sqlconn = new SqlConnection(@"data source=MICHAEL-LAPTOP\SQLEXPRESS;initial catalog=Urenregistratie;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot");
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand("SELECT takenId, taak from Taken", sqlconn);
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

        private void cmbGebruiker_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            cmbProject.Text = "";
            cmbTaak.Text = "";
            tbUren.Text = "";

            SqlConnection sqlconn = new SqlConnection(@"data source=MICHAEL-LAPTOP\SQLEXPRESS;initial catalog=Urenregistratie;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot");
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand("SELECT userId, gebruikersnaam from Users", sqlconn);
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

        private void cmbProject_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"data source=MICHAEL-LAPTOP\SQLEXPRESS;initial catalog=Urenregistratie;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot");
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand("SELECT DISTINCT P.projectNaam, U.gebruikersNaam, T.taak, uren FROM dbo.Uren Ur INNER JOIN Users U ON U.userId = Ur.userId INNER JOIN Projecten P ON P.projectId = Ur.projectId INNER JOIN Taken T ON T.takenId = Ur.takenId WHERE Ur.projectId= " + cmbProject.SelectedValue + "", sqlconn);
            SqlDataReader reader;

            reader = sqlcom.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dataGridView1.DataSource = dt;
            sqlconn.Close();

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            tbUren.Text = sum.ToString();
        }

        private void cmbTaak_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"data source=MICHAEL-LAPTOP\SQLEXPRESS;initial catalog=Urenregistratie;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot");
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand("SELECT DISTINCT T.taak, P.projectNaam, U.gebruikersNaam, uren FROM dbo.Uren Ur INNER JOIN Users U ON U.userId = Ur.userId INNER JOIN Projecten P ON P.projectId = Ur.projectId INNER JOIN Taken T ON T.takenId = Ur.takenId WHERE Ur.takenId= " + cmbTaak.SelectedValue + "", sqlconn);
            SqlDataReader reader;

            reader = sqlcom.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dataGridView1.DataSource = dt;
            sqlconn.Close();

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            tbUren.Text = sum.ToString();
        }

        private void cmbGebruiker_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"data source=MICHAEL-LAPTOP\SQLEXPRESS;initial catalog=Urenregistratie;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot");
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand("SELECT DISTINCT U.gebruikersNaam, T.taak, P.projectNaam, uren FROM dbo.Uren Ur INNER JOIN Users U ON U.userId = Ur.userId INNER JOIN Projecten P ON P.projectId = Ur.projectId INNER JOIN Taken T ON T.takenId = Ur.takenId WHERE Ur.userId= " + cmbGebruiker.SelectedValue + "", sqlconn);
            SqlDataReader reader;

            reader = sqlcom.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dataGridView1.DataSource = dt;
            sqlconn.Close();

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            tbUren.Text = sum.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}
