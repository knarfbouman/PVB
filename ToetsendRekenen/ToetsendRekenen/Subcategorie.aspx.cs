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
                
                SubCategorie.Items.Remove("optie 1");
                SubCategorie.Items.Remove("optie 2");
                SubCategorie.Items.Remove("optie 3");
                SubCategorie.Items.Remove("optie 4");
                SubCategorie.Items.Remove("optie 5");
                SubCategorie.Items.Add("Erbijsommen");
                SubCategorie.Items.Add("Erafsommen");
                SubCategorie.Items.Add("Deelsommen");
                SubCategorie.Items.Add("Keersommen");
                SubCategorie.Items.Add("Gemixed");
               
            }


            if (head == "Opdracht 2")
            {

                SubCategorie.Items.Remove("optie 1");
                SubCategorie.Items.Remove("optie 2");
                SubCategorie.Items.Remove("optie 3");
                SubCategorie.Items.Remove("optie 4");
                SubCategorie.Items.Remove("optie 5");
                SubCategorie.Items.Add("Getallen");
                SubCategorie.Items.Add("Kommagetallen");
                SubCategorie.Items.Add("Breuken");        
                SubCategorie.Items.Add("Gemixed");

            }
                
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string header = Convert.ToString(Session["header"]);
            string getal1 = (this.Request.Form.Get("labeltest"));
           string getal2 = (this.Request.Form.Get("getal2"));
           string testhest = Convert.ToString(RadioButtonList1.SelectedItem);
           string subcat = Convert.ToString(SubCategorie.SelectedItem);
           if ( testhest != "" && subcat !="")
           {

               

               string[] Subcatergoriearray = new string[4] { RadioButtonList1.SelectedItem.Text, SubCategorie.SelectedItem.Text, getal1, getal2 };
               
               Session.Add("subcategoriearray", Subcatergoriearray);
               if (header == "Opdracht 1")
               {
                   Response.Redirect("/MetSommenWerken.aspx");
               }

               if (header == "Opdracht 2")
               {
                   Response.Redirect("/Tijdlijn.aspx");
               }

           }
           else
           {
               string head = Convert.ToString(Session["header"]);
               if (head == "Opdracht 1")
               {

                   SubCategorie.Items.Remove("Erbijsommen");
                   SubCategorie.Items.Remove("Erafsommen");
                   SubCategorie.Items.Remove("Deelsommen");
                   SubCategorie.Items.Remove("Keersommen");
                   SubCategorie.Items.Remove("Gemixed");
               }
               if (head == "Opdracht 2")
               {
                   SubCategorie.Items.Remove("Getallen");
                   SubCategorie.Items.Remove("Kommagetallen");
                   SubCategorie.Items.Remove("Breuken");
                   SubCategorie.Items.Remove("Gemixed");
               }
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