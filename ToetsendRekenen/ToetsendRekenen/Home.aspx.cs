﻿using System;
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
            Response.Redirect("/opdracht1.aspx");
        }
    }
}