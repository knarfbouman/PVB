using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToetsendRekenen
{
    public partial class WebForm5 : System.Web.UI.Page
    {

        Entities TREnt = new Entities();

        protected void Page_Load(object sender, EventArgs e)
        {   

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var login = from i in TREnt.Admin
                        where i.Gebruikersnaam == tbUsername.Text && i.Wachtwoord == tbPassword.Text
                        select i;

            int aantal = login.Count();
            if (aantal != 1)
            {
                lblError.Text = "Gebruikersnaam of Wachtwoord ongeldig.";
            }
            else
            {
                Session["Admin"] = "Admin";
                Response.Redirect("/AdminView.aspx");
            }
        }


    }
}