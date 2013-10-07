using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToetsendRekenen
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        Entities TRend = new Entities();

        public int getalslider1;
        public int getalslider2;
        public string moeilijkheidsgraad;

        protected void Page_Load(object sender, EventArgs e)
        {
            string[] subcategoriearray = (string[])Session["subcategoriearray"];

            string slidergetal1 = subcategoriearray[2];
            string slidergetal2 = subcategoriearray[3];
            string moeilijkheidsgraadsession = subcategoriearray[0];

            getalslider1 = Convert.ToInt32(slidergetal1);
            getalslider2 = Convert.ToInt32(slidergetal2);
            moeilijkheidsgraad = moeilijkheidsgraadsession;
        }

        protected void naarResultaat_Click(object sender, EventArgs e)
        {
            try
            {
                string aantalgoed = (this.Request.Form.Get("inputaantalgoed"));

                Session.Add("aantalgoedsession", aantalgoed);


                string[] subcategoriearray = (string[])Session["subcategoriearray"];

                string[] databasetest = string[null, subcategoriearray[5], subcategoriearray[1], aantalgoed, DateTime.Now];

                TRend.Scores.Add(databasetest);

                Response.Redirect("/Leerlingresultaat.aspx");
            }
            catch(Exception)
            {
                Response.Write("<script>alert('Er is iets fout gegaan!');</script>");
            }
        }

    }
}