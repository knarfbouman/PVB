using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToetsendRekenen
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        Entities TRend = new Entities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void naarResultaat_Click(object sender, EventArgs e)
        {
            string aantalgoed = (this.Request.Form.Get("inputaantalgoed"));
            Session.Add("aantalgoedsession", aantalgoed);
            string categorie = "Klokkijken";
            string subcategorieFromArray = "Analoog";

            SqlConnection sqlConn = new SqlConnection(@"data source=www.dbss.nl;initial catalog=PVB1314-004;persist security info=True;user id=frmiok;password=ROC;MultipleActiveResultSets=True;App=EntityFramework&quot;");
            //SqlCommand sqlComm = new SqlCommand("INSERT INTO Scores (Categorienaam, Subcategorienaam, Score, Datum) Values ('" + subcategoriearray[1] + "' , '"
            //+ subcategoriearray[5] + "' , '" + Convert.ToInt32(aantalgoed) * 2 + "' , '" + DateTime.Now + "'", sqlConn);
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;
            sqlComm.CommandText = "INSERT INTO Scores(Categorienaam, Subcategorienaam, Score, Datum) VALUES(@param1, @param2, @param3, @param4)";
            sqlComm.Parameters.AddWithValue("@param1", categorie);
            sqlComm.Parameters.AddWithValue("@param2", subcategorieFromArray);
            sqlComm.Parameters.AddWithValue("@param3", Convert.ToInt32(aantalgoed) * 2);
            sqlComm.Parameters.AddWithValue("@param4", DateTime.Now);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

            Response.Redirect("/Leerlingresultaat.aspx");

        }
    }
}