﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToetsendRekenen
{    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string[] Instellingenarray = (string[])Session["subcategoriearray"];
            if (Instellingenarray != null)
            {
                int firstnumber = Convert.ToInt16(Instellingenarray[2]);
                

                Label1.Text = Convert.ToString(firstnumber);
                Label2.Text = Convert.ToString(Instellingenarray[3]);





            }
            else
            {
                Response.Redirect("/Home.aspx");
            }
            
        }
    }
}
