using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToetsendRekenen
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            opdrachtlbl.Text = Convert.ToString(Session["header"]);
            //todo: if session header = "" then redirect to home page
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

           
                lejbel.Text = RadioButtonList1.SelectedItem.Text;
                lejbel.Text+= ", " +  SubCategorie.SelectedItem.Text;
                lejbel.Text += ", "  ;
            }

        protected void SubCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SubCategorie_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}