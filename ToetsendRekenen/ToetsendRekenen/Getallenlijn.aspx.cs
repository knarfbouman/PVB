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
                string subcategorie = Instellingenarray[1];
                if (subcategorie == "Getallen")
                {

                    
                    //Pijl.CssClass = "eerste";
                    double firstnumber = 0;
                    double lastnumber = Convert.ToInt16(Instellingenarray[3]);
                    Random randomer = new Random();
                   
                    int randomlastnumber = randomer.Next(Convert.ToInt16( firstnumber), Convert.ToInt16( lastnumber));
                    do
                    {
                        randomlastnumber = randomer.Next(Convert.ToInt16(firstnumber), Convert.ToInt16(lastnumber));
                    }
                    while (randomlastnumber < 4);
                    double getal1 = Convert.ToDouble(randomlastnumber * 0.3);
                    double getal2 = Convert.ToDouble(randomlastnumber * 0.5);
                    double getal3 = Convert.ToDouble(randomlastnumber * 0.8);
                    double verlijkgetal1 = Math.Floor(getal1);
                    double verlijkgetal2 = Math.Floor(getal2);
                    double verlijkgetal3 = Math.Floor(getal3);

                    int randompijl = randomer.Next(1, 7);
                    if (randompijl == 1)
                    {
                        Pijl.CssClass = "eerste";
                    }
                    if (randompijl == 2)
                    {
                        Pijl.CssClass = "tweede";
                    }
                    if (randompijl == 3)
                    {
                        Pijl.CssClass = "vierde";
                    }
                    if (randompijl == 4)
                    {
                        Pijl.CssClass = "zesde";
                    }
                    if (randompijl == 5)
                    {
                        Pijl.CssClass = "zevende";
                    }
                    if (randompijl == 6)
                    {
                        Pijl.CssClass = "negende";
                    }

                    Response.Write(randompijl);

                    do
                    {
                        randomlastnumber = randomer.Next(Convert.ToInt16(firstnumber), Convert.ToInt16(lastnumber));

                        getal1 = Convert.ToDouble(randomlastnumber * 0.3);
                        getal2 = Convert.ToDouble(randomlastnumber * 0.5);
                        getal3 = Convert.ToDouble(randomlastnumber * 0.8);
                        verlijkgetal1 = Math.Floor(getal1);
                        verlijkgetal2 = Math.Floor(getal2);
                        verlijkgetal3 = Math.Floor(getal3);



                    }

                    while (verlijkgetal1 != getal1 || verlijkgetal2 != getal2 || verlijkgetal3 != getal3 || randomlastnumber == 0);
                    Label1.Text = Convert.ToString(firstnumber);
                    Label2.Text = Convert.ToString(randomlastnumber);
                    Label4.Text = Convert.ToString(getal1);
                    Label5.Text = Convert.ToString(getal2);
                    Label3.Text = Convert.ToString(getal3);

                }
                if (subcategorie == "Kommagetallen")
                {

                    int firstnumber = Convert.ToInt16(Instellingenarray[2]);
                    int lastnumber = Convert.ToInt16(Instellingenarray[3]);
                    Random randomer = new Random();
                    int randomlastnumber = randomer.Next(firstnumber, lastnumber);
                    do
                    {
                        randomlastnumber = randomer.Next(firstnumber, lastnumber);
                    }
                    while (randomlastnumber < 4);


                    Label1.Text = Convert.ToString(firstnumber);
                    Label2.Text = Convert.ToString(randomlastnumber);
                    Label4.Text = Convert.ToString(randomlastnumber * 0.3);
                    Label5.Text = Convert.ToString(randomlastnumber * 0.5);
                    Label3.Text = Convert.ToString(randomlastnumber * 0.8);
                }
                





            }
            else
            {
                Response.Redirect("/Home.aspx");
            }
            
        }
    }
}
