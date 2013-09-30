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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            
                lejbel.Text = RadioButtonList1.SelectedItem.Text;
            
            }

        protected void SubCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}