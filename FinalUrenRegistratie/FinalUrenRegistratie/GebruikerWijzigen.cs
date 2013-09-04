using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalUrenRegistratie
{
    public partial class GebruikerWijzigen : Form
    {
        UrenregistratieEntities urent = new UrenregistratieEntities();
        public OpenFileDialog ofd = new OpenFileDialog();

        #region Methodes
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        #endregion

        public GebruikerWijzigen()
        {
            InitializeComponent();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            ofd.Title = "Open Afbeelding";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbFoto.Image = Image.FromFile(ofd.FileName);
                pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnWijzigen_Click(object sender, EventArgs e)
        {
            string fileName = ofd.FileName;
            byte[] imageData = new byte[0];
            if (!string.IsNullOrEmpty(fileName))
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    imageData = new byte[fs.Length];
                    fs.Read(imageData, 0, (int)fs.Length);
                }
            }
            try
            {
                if (tbGebruikersnaam.Text == "" || tbAchternaam.Text == "" || tbVoornaam.Text == "" || tbWachtwoord.Text == "" || tbControle.Text == "")
                {
                    lblError.Text = "Er zijn een of meerdere velden niet ingevuld";
                }
                else if (tbWachtwoord.Text != tbControle.Text)
                {
                    lblError.Text = "De wachtwoorden komen niet overeen";
                }
                else
                {
                    Users gebruiker = urent.Users.First(i => i.gebruikersnaam == tbGebruikersnaam.Text);

                    gebruiker.voornaam = tbVoornaam.Text;
                    gebruiker.achternaam = tbAchternaam.Text;
                    gebruiker.gebruikersnaam = tbGebruikersnaam.Text;
                    gebruiker.wachtwoord = tbWachtwoord.Text;
                    gebruiker.permissie = cmbPermissie.Text;

                    if (!string.IsNullOrEmpty(fileName))
                    {
                        gebruiker.foto = imageToByteArray(pbFoto.Image);
                    }

                    urent.SaveChanges();

                    lblError.Text = "";

                    MessageBox.Show("De gebruiker is gewijzigd");

                    cmbGebruiker.Text = null;
                    tbVoornaam.Text = "";
                    tbAchternaam.Text = "";
                    tbGebruikersnaam.Text = "";
                    tbWachtwoord.Text = "";
                    tbControle.Text = "";
                    cmbPermissie.Text = null;
                    pbFoto.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            try
            {
                Users gebruiker = urent.Users.First(i => i.gebruikersnaam == tbGebruikersnaam.Text);
                urent.Users.Remove(gebruiker);
                urent.SaveChanges();

                lblError.Text = "";

                MessageBox.Show("De gebruiker is verwijderd");

                cmbGebruiker.Text = null;
                tbVoornaam.Text = "";
                tbAchternaam.Text = "";
                tbGebruikersnaam.Text = "";
                tbWachtwoord.Text = "";
                tbControle.Text = "";
                cmbPermissie.Text = null;
                pbFoto.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            cmbGebruiker.Text = null;
            tbVoornaam.Text = "";
            tbAchternaam.Text = "";
            tbGebruikersnaam.Text = "";
            tbWachtwoord.Text = "";
            tbControle.Text = "";
            cmbPermissie.Text = null;
            pbFoto.Image = null;

            Close();
            Home home = new Home();
            home.Show();
        }

        private void GebruikerWijzigen_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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

            while (reader.Read())
            {
                string voornaam = reader.GetString(1);
                string achternaam = reader.GetString(2);
                string gebruikersnaam = reader.GetString(3);
                string wachtwoord = reader.GetString(4);
                string permissie = reader.GetString(5);
                byte[] buffer = new byte[3000000];
                long lenght = 0;
                Image foto = null;

                try
                {
                    lenght = reader.GetBytes(6, 0, buffer, 0, 3000000);
                }
                catch
                {

                }
                finally
                {
                    if (lenght != 0)
                    {
                        foto = byteArrayToImage(buffer);
                    }
                }

                tbVoornaam.Text = voornaam;
                tbAchternaam.Text = achternaam;
                tbGebruikersnaam.Text = gebruikersnaam;
                tbWachtwoord.Text = wachtwoord;
                tbControle.Text = wachtwoord;
                cmbPermissie.Text = permissie;

                if (foto != null)
                {
                    pbFoto.Image = foto;
                }

                if (foto == null)
                {
                    pbFoto.Image = null;
                }

                this.pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            }

            sqlconn.Close();   
        }

        private void cmbGebruiker_Enter(object sender, EventArgs e)
        {
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

        private void btnOverzicht_Click(object sender, EventArgs e)
        {
            Close();
            GebruikersOverzicht goverzicht = new GebruikersOverzicht();
            goverzicht.Show();
        }
    }
}
