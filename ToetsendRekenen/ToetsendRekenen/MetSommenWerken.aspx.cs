﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToetsendRekenen
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        public int getalslider1;
        public int getalslider2;

        protected void Page_Load(object sender, EventArgs e)
        {
            string[] subcategoriearray = (string[])Session["subcategoriearray"];

            string slidergetal1 = subcategoriearray[2];
            string slidergetal2 = subcategoriearray[3];

            getalslider1 = Convert.ToInt32(slidergetal1);
            getalslider2 = Convert.ToInt32(slidergetal2);
        }

    }
}