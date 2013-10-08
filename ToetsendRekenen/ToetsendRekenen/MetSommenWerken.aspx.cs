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
                string aantalgoed = (this.Request.Form.Get("inputaantalgoed"));
                Session.Add("aantalgoedsession", aantalgoed);
                string[] subcategoriearray = (string[])Session["subcategoriearray"];
                string categorie = subcategoriearray[4];
                string subcategorie = subcategoriearray[1];

                SqlConnection sqlConn = new SqlConnection(@"data source=www.dbss.nl;initial catalog=PVB1314-004;persist security info=True;user id=frmiok;password=ROC;MultipleActiveResultSets=True;App=EntityFramework&quot;");
                //SqlCommand sqlComm = new SqlCommand("INSERT INTO Scores (Categorienaam, Subcategorienaam, Score, Datum) Values ('" + subcategoriearray[1] + "' , '"
                //+ subcategoriearray[5] + "' , '" + Convert.ToInt32(aantalgoed) * 2 + "' , '" + DateTime.Now + "'", sqlConn);
                SqlCommand sqlComm = new SqlCommand();
                sqlComm.Connection = sqlConn;
                sqlComm.CommandText = "INSERT INTO Scores(Categorienaam, Subcategorienaam, Score, Datum) VALUES(@param1, @param2, @param3, @param4)";
                sqlComm.Parameters.AddWithValue("@param1", categorie);
                sqlComm.Parameters.AddWithValue("@param2", subcategorie);
                sqlComm.Parameters.AddWithValue("@param3", Convert.ToInt32(aantalgoed) * 2);
                sqlComm.Parameters.AddWithValue("@param4", DateTime.Now);  

                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();

                Response.Redirect("/Leerlingresultaat.aspx");

        }

    }
}