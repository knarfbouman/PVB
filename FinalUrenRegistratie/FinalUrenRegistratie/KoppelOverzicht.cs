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
    public partial class KoppelOverzicht : Form
    {
        public KoppelOverzicht()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
            GebruikerKoppel gkoppel = new GebruikerKoppel();
            gkoppel.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Close();
            Home home = new Home();
            home.Show();
        }

        private void KoppelOverzicht_Load(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"data source=MICHAEL-LAPTOP\SQLEXPRESS;initial catalog=Urenregistratie;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot");
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand("SELECT userProjectId, U.gebruikersNaam, P.projectNaam, T.taak FROM dbo.UsersProjectenLijst Ur INNER JOIN Users U ON U.userId = Ur.userId INNER JOIN Projecten P ON P.projectId = Ur.projectId INNER JOIN Taken T ON T.takenId = Ur.takenId", sqlconn);
            SqlDataReader reader;

            reader = sqlcom.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dataGridView1.DataSource = dt;

            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
