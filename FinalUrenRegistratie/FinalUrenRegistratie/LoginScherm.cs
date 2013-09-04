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
    public partial class LoginScherm : Form
    {
        UrenregistratieEntities urent = new UrenregistratieEntities();

        #region Methodes
        private void LogInUser()
        {
            var login = from i in urent.Users
                        where i.gebruikersnaam == tbUsername.Text && i.wachtwoord == tbPassword.Text
                        select i;

            foreach (var persoon in login)
            {
                Program.Users = persoon;
            }

            int aantal = login.Count();
            if (aantal != 1)
            {
                MessageBox.Show("Gebruikersnaam of wachtwoord ongeldig.", "Ongeldig login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblError.Text = "Wachtwoord vergeten?";
            }
            else
            {
                Home home = new Home();
                home.Show();
                Hide();
            }
        }
        #endregion

        public LoginScherm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LogInUser();
        }

        private void lblError_MouseHover(object sender, EventArgs e)
        {
            lblError.ForeColor = Color.Blue;
            Font style = new Font(lblError.Font, FontStyle.Underline);
            lblError.Font = style;
        }

        private void lblError_MouseLeave(object sender, EventArgs e)
        {
            lblError.ForeColor = Color.Black;
            Font style = new Font(lblError.Font, FontStyle.Regular);
            lblError.Font = style;
        }

        private void lblError_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Neem contact op met de Administrator: Administrator@project.nl", "Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
            {
                LogInUser();
            }
        }

        private void LoginScherm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
