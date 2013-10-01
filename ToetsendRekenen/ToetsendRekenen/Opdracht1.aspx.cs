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
            string head = Convert.ToString(Session["header"]);
            opdrachtlbl.Text = head;
          
            
            if (head == "")
            {
                Response.Redirect("/home.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string getal1 = (this.Request.Form.Get("labeltest"));
           string getal2 = (this.Request.Form.Get("getal2"));
           if ( Convert.ToString( RadioButtonList1.SelectedItem) != "" && Convert.ToString( SubCategorie.SelectedItem) !="")
           {

               lejbel.Text = RadioButtonList1.SelectedItem.Text;
               lejbel.Text += ", " + SubCategorie.SelectedItem.Text;
               lejbel.Text += ", " + getal1;
               lejbel.Text += ", " + getal2;
           }
           else
           {
               
           }
            }

        protected void SubCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SubCategorie_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}