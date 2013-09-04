using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalUrenRegistratie
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblGebruikersnaam.Text = Program.Users.voornaam;
            lblPermissie.Text = Program.Users.permissie;

            try
            {
                if (Program.Users.permissie == "Admin          ")
                {
                    btnGebruikertoevoegen.Enabled = true;
                    btnProjecttoevoegen.Enabled = true;
                    btnTaaktoevoegen.Enabled = true;
                    btnGebruikerwijzigen.Enabled = true;
                    btnProjectwijzigen.Enabled = true;
                    btnTaakwijzigen.Enabled = true;
                    BtnUrenToevoegen.Enabled = true;
                    btnWijzigUren.Enabled = true;
                }
                else if (Program.Users.permissie == "ProjectLeider  ")
                {
                    btnGebruikertoevoegen.Enabled = false;
                    btnProjecttoevoegen.Enabled = true;
                    btnTaaktoevoegen.Enabled = true;
                    btnGebruikerwijzigen.Enabled = false;
                    btnProjectwijzigen.Enabled = true;
                    btnTaakwijzigen.Enabled = true;
                    BtnUrenToevoegen.Enabled = true;
                    btnWijzigUren.Enabled = true;
                }
                else
                {
                    btnGebruikertoevoegen.Enabled = false;
                    btnProjecttoevoegen.Enabled = false;
                    btnTaaktoevoegen.Enabled = false;
                    btnGebruikerwijzigen.Enabled = false;
                    btnProjectwijzigen.Enabled = false;
                    btnTaakwijzigen.Enabled = false;
                    BtnUrenToevoegen.Enabled = true;
                    btnWijzigUren.Enabled = true;
                }

                this.ControlBox = false;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lblAfmelden_Click(object sender, EventArgs e)
        {
            Close();
            LoginScherm login = new LoginScherm();
            login.Show();
        }

        private void btnGebruikertoevoegen_Click(object sender, EventArgs e)
        {
            Close();
            GebruikerToevoegen gtoevoegen = new GebruikerToevoegen();
            gtoevoegen.Show();
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGebruikerwijzigen_Click(object sender, EventArgs e)
        {
            Close();
            GebruikerWijzigen gwijzigen = new GebruikerWijzigen();
            gwijzigen.Show();
        }

        private void btnProjecttoevoegen_Click(object sender, EventArgs e)
        {
            Close();
            ProjectToevoegen ptoevoegen = new ProjectToevoegen();
            ptoevoegen.Show();
        }

        private void btnProjectwijzigen_Click(object sender, EventArgs e)
        {
            Close();
            ProjectWijzigen pwijzigen = new ProjectWijzigen();
            pwijzigen.Show();
        }

        private void btnTaaktoevoegen_Click(object sender, EventArgs e)
        {
            Close();
            TaakToevoegen ttoevoegen = new TaakToevoegen();
            ttoevoegen.Show();
        }

        private void btnTaakwijzigen_Click(object sender, EventArgs e)
        {
            Close();
            TaakWijzigen twijzigen = new TaakWijzigen();
            twijzigen.Show();
        }

        private void Btnurentoevoegen_Click(object sender, EventArgs e)
        {
            Close();
            UrenToevoegen utoev = new UrenToevoegen();
            utoev.Show();
        }

        private void btnWijzigUren_Click(object sender, EventArgs e)
        {
            Close();
            UrenWijzigen uwijzigen = new UrenWijzigen();
            uwijzigen.Show();
        }

        private void btnAfmelden_Click(object sender, EventArgs e)
        {
            Close();
            LoginScherm login = new LoginScherm();
            login.Show();
        }

    }
}
