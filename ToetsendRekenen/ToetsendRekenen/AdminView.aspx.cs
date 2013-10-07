using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToetsendRekenen
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        Entities TREnt = new Entities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"] != "Admin")
            {
                //Response.Redirect("/Login.aspx");
            }

            ddlMaand.Items.Insert(0, new ListItem("Selecteer Maand", string.Empty));
        }

        protected void btnWijzig_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbOudWachtwoord.Text == "" || tbNieuwWachtwoord.Text == "" || tbNieuwWachtwoord2.Text == "")
                {
                    lblError.Text = "Er zijn een of meerdere velden niet ingevuld";
                }
                else if (tbNieuwWachtwoord.Text != tbNieuwWachtwoord2.Text)
                {
                    lblError.Text = "De wachtwoorden komen niet overeen";
                }
                else
                {
                    Admin admin = TREnt.Admin.First(i => i.Wachtwoord == tbOudWachtwoord.Text);

                    admin.Wachtwoord = tbNieuwWachtwoord2.Text;

                    TREnt.SaveChanges();

                    lblError.Text = "Het wachtwoord is gewijzigd";

                    tbOudWachtwoord.Text = "";
                    tbNieuwWachtwoord.Text = "";
                    tbNieuwWachtwoord2.Text = "";
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
            }
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Login.aspx");
            Session.Abandon();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string van = (this.Request.Form.Get("textbox2"));
            string tot = (this.Request.Form.Get("textbox3"));

            //TREnt.BetweenDates(van, tot);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"data source=www.dbss.nl;initial catalog=PVB1314-004;persist security info=True;user id=frmiok;password=ROC;MultipleActiveResultSets=True;App=EntityFramework&quot;");
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand("SELECT Datepart(mm," , sqlconn);
            //+ ddlMaand.SelectedValue + ""
            SqlDataReader reader;
            DataTable dt = new DataTable();
            reader = sqlcom.ExecuteReader();

            
            dt.Load(reader);

            DataGrid.DataSource = dt;
            DataGrid.DataBind();
            sqlconn.Close();

        }
    }
}