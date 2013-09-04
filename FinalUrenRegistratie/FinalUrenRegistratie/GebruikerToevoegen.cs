using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalUrenRegistratie
{
    public partial class GebruikerToevoegen : Form
    {
        UrenregistratieEntities urent = new UrenregistratieEntities();
        public OpenFileDialog ofd = new OpenFileDialog();
        public Users gebruiker = new Users();

        public GebruikerToevoegen()
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

        private void btnToevoegen_Click(object sender, EventArgs e)
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
                if (tbGebruikersnaam.Text == "" || tbAchternaam.Text == "" || tbVoornaam.Text == "" || tbWachtwoord.Text == "" || tbControle.Text == "" || cmbPermissie.SelectedItem == null)
                {
                    lblError.Text = "Er zijn een of meerdere velden niet ingevuld";
                }
                else if (tbWachtwoord.Text != tbControle.Text)
                {
                    lblError.Text = "De wachtwoorden komen niet overeen";
                }
                else
                {
                    gebruiker.voornaam = tbVoornaam.Text;
                    gebruiker.achternaam = tbAchternaam.Text;
                    gebruiker.gebruikersnaam = tbGebruikersnaam.Text;
                    gebruiker.wachtwoord = tbWachtwoord.Text;
                    gebruiker.permissie = cmbPermissie.SelectedItem.ToString();
                    gebruiker.foto = imageData;
                    urent.Users.Add(gebruiker);
                    urent.SaveChanges();

                    lblError.Text = "";

                    MessageBox.Show("De gebruiker is toegevoegd");

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

        private void btnHome_Click(object sender, EventArgs e)
        {
            Close();
            Home home = new Home();
            home.Show();
        }

        private void GebruikerToevoegen_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

    }
}
