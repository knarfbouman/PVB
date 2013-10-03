using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToetsendRekenen
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        public int aantalgoed;
        protected void Page_Load(object sender, EventArgs e)
        {
            string aantalGoedUitSessie = (string)Session["aantalgoedsession"];

            aantalgoed = Convert.ToInt32(aantalGoedUitSessie);

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/home.aspx");
        }
    }
}