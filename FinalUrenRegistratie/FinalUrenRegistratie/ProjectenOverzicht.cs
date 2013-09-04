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
    public partial class ProjectenOverzicht : Form
    {
        public ProjectenOverzicht()
        {
            InitializeComponent();
        }

        private void ProjectenOverzicht_Load(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"data source=MICHAEL-LAPTOP\SQLEXPRESS;initial catalog=Urenregistratie;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot");
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand("SELECT projectId, projectNaam , projectOmschrijving , beginDatum , eindDatum , afgesloten FROM dbo.Projecten", sqlconn);
            SqlDataReader reader;

            reader = sqlcom.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dataGridView1.DataSource = dt;

            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
            ProjectWijzigen pwijzigen = new ProjectWijzigen();
            pwijzigen.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Close();
            Home home = new Home();
            home.Show();
        }
    }
}
