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

            if (head == "Opdracht 1")
            {
                SubCategorie.Items.Clear();
                SubCategorie.Items.Add("Erbijsommen");
                SubCategorie.Items.Add("Erafsommen");
                SubCategorie.Items.Add("Deelsommen");
                SubCategorie.Items.Add("Keersommen");
                SubCategorie.Items.Add("Gemixed");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string getal1 = (this.Request.Form.Get("labeltest"));
           string getal2 = (this.Request.Form.Get("getal2"));
           if ( Convert.ToString( RadioButtonList1.SelectedItem) != "" && Convert.ToString( SubCategorie.SelectedItem) !="")
           {

               

               string[] Subcatergoriearray = new string[4] { RadioButtonList1.SelectedItem.Text, SubCategorie.SelectedItem.Text, getal1, getal2 };
               
               Session.Add("subcategoriearray", Subcatergoriearray);
           }
           else
           {
               Response.Write("<script>alert('Je bent iets vergeten te selecteren!');</script>");
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