using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToetsendRekenen
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Opdracht1_Click(object sender, EventArgs e)
        {
            Session.Add("header", Opdracht1.Text);
            Response.Redirect("/Subcategorie.aspx");
        }

        protected void Opdracht2_Click(object sender, EventArgs e)
        {
            Session.Add("header", Opdracht2.Text);
            Response.Redirect("/Subcategorie.aspx");
        }

        protected void Opdracht3_Click(object sender, EventArgs e)
        {
            Session.Add("header", Opdracht3.Text);
            Response.Redirect("/Subcategorie.aspx");
        }

        protected void Opdracht4_Click(object sender, EventArgs e)
        {
            Session.Add("header", Opdracht4.Text);
            Response.Redirect("/Subcategorie.aspx");
        }

        protected void Opdracht5_Click(object sender, EventArgs e)
        {
            Session.Add("header", Opdracht5.Text);
            Response.Redirect("/Subcategorie.aspx");
        }

        protected void Opdracht6_Click(object sender, EventArgs e)
        {
            Session.Add("header", Opdracht6.Text);
            Response.Redirect("/Subcategorie.aspx");
        }

        protected void Opdracht7_Click(object sender, EventArgs e)
        {
            Session.Add("header", Opdracht7.Text);
            Response.Redirect("/Subcategorie.aspx");
        }

        protected void Opdracht8_Click(object sender, EventArgs e)
        {
            Session.Add("header", Opdracht8.Text);
            Response.Redirect("/Subcategorie.aspx");
        }

        protected void Adminbutton_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Login.aspx");
        }
    }
}