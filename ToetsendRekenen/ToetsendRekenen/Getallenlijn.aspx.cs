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
            
           
           if (IsPostBack == false)
           {
               Session.Add("aantalvragen", 0);
               int aantalvragen = 0;
               lblvragen.Text = "Vraag " + aantalvragen + " van 50";
           }
            double goedantwoord;
            double foutantwoord1;
            double foutantwoord2;
            double foutantwoord3;
            
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
                    double pijlgetal = 0;
                    

                    int randompijl = randomer.Next(1, 7);
                        if (randompijl == 1)
                        {
                            Pijl.CssClass = "eerste";
                            pijlgetal = randomlastnumber * 0.1;
                            
                        }
                        if (randompijl == 2)
                        {
                            Pijl.CssClass = "tweede";
                            pijlgetal = randomlastnumber * 0.2;
                        }
                        if (randompijl == 3)
                        {
                            Pijl.CssClass = "vierde";
                            pijlgetal = randomlastnumber * 0.4;
                        }
                        if (randompijl == 4)
                        {
                            Pijl.CssClass = "zesde";
                            pijlgetal = randomlastnumber * 0.6;
                        }
                        if (randompijl == 5)
                        {
                            Pijl.CssClass = "zevende";
                            pijlgetal = randomlastnumber * 0.7;
                        }
                        if (randompijl == 6)
                        {
                            Pijl.CssClass = "negende";
                            pijlgetal = randomlastnumber * 0.9;
                        }
                        double nietpijlgetal = Math.Floor(pijlgetal);
                        

                    do
                    {
                        randomlastnumber = randomer.Next(Convert.ToInt16(firstnumber), Convert.ToInt16(lastnumber));

                        getal1 = Convert.ToDouble(randomlastnumber * 0.3);
                        getal2 = Convert.ToDouble(randomlastnumber * 0.5);
                        getal3 = Convert.ToDouble(randomlastnumber * 0.8);
                        verlijkgetal1 = Math.Floor(getal1);
                        verlijkgetal2 = Math.Floor(getal2);
                        verlijkgetal3 = Math.Floor(getal3);
                        randompijl = randomer.Next(1, 7);
                        if (randompijl == 1)
                        {
                            Pijl.CssClass = "eerste";
                            pijlgetal = randomlastnumber * 0.1;
                        }
                        if (randompijl == 2)
                        {
                            Pijl.CssClass = "tweede";
                            pijlgetal = randomlastnumber * 0.2;
                        }
                        if (randompijl == 3)
                        {
                            Pijl.CssClass = "vierde";
                            pijlgetal = randomlastnumber * 0.4;
                        }
                        if (randompijl == 4)
                        {
                            Pijl.CssClass = "zesde";
                            pijlgetal = randomlastnumber * 0.6;
                        }
                        if (randompijl == 5)
                        {
                            Pijl.CssClass = "zevende";
                            pijlgetal = randomlastnumber * 0.7;
                        }
                        if (randompijl == 6)
                        {
                            Pijl.CssClass = "negende";
                            pijlgetal = randomlastnumber * 0.9;
                        }
                         nietpijlgetal = Math.Floor(pijlgetal);
                         


                    }

                    while (verlijkgetal1 != getal1 || verlijkgetal2 != getal2 || verlijkgetal3 != getal3 || randomlastnumber == 0 || nietpijlgetal != pijlgetal );

                    goedantwoord = pijlgetal;
                    do
                    {
                        int randomfoutgetal = randomer.Next(1, 6);
                        int randomfoutgetal2 = randomer.Next(2, 7);
                        double randomfoutgetal3 = randomer.Next(1, 10);
                        double komma = randomfoutgetal3 / 10;
                        foutantwoord1 = goedantwoord - randomfoutgetal;
                        foutantwoord2 = goedantwoord + randomfoutgetal2;
                        foutantwoord3 = Math.Round( goedantwoord * komma);
                    }
                    while (foutantwoord1 == goedantwoord || foutantwoord2 == goedantwoord || foutantwoord3 == goedantwoord || foutantwoord1 == foutantwoord2 || foutantwoord2 == foutantwoord3 || foutantwoord1 == foutantwoord3 || foutantwoord1 < 1 || foutantwoord2 < 1 || foutantwoord3 < 1 || foutantwoord1 > randomlastnumber || foutantwoord2 > randomlastnumber || foutantwoord3 > randomlastnumber || foutantwoord1 == randomlastnumber || foutantwoord2 == randomlastnumber || foutantwoord3 == randomlastnumber);
                    

                    Label1.Text = Convert.ToString(firstnumber);
                    Label2.Text = Convert.ToString(randomlastnumber);
                    Label4.Text = Convert.ToString(getal1);
                    Label5.Text = Convert.ToString(getal2);
                    Label3.Text = Convert.ToString(getal3);

                    int randompositie1;
                    int randompositie2;
                    int randompositie3;
                    int randompositie4;

                    do
                    {
                        randompositie1 = randomer.Next(0, 5);
                    }
                    while (randompositie1 == 0);
                    do
                    {
                        randompositie2 = randomer.Next(0, 5);

                    }
                    while (randompositie2 == 0 || randompositie2 == randompositie1);

                    do
                    {
                        randompositie3 = randomer.Next(0, 5);

                    }
                    while (randompositie3 == 0 || randompositie3 == randompositie2 || randompositie3 == randompositie1);
                    do
                    {
                        randompositie4 = randomer.Next(0, 5);

                    }
                    while (randompositie4 == 0 || randompositie4 == randompositie2 || randompositie4 == randompositie1 || randompositie4 == randompositie3);
                    if (IsPostBack == false)
                    {
                        RadioButtonList1.Items.Add(Convert.ToString(0));
                        RadioButtonList1.Items.Add(Convert.ToString(0));
                        RadioButtonList1.Items.Add(Convert.ToString(0));
                        RadioButtonList1.Items.Add(Convert.ToString(0));
                    }
                    RadioButtonList1.Items[randompositie1 -1].Text = Convert.ToString(foutantwoord1);
                    RadioButtonList1.Items[randompositie2 -1].Text = Convert.ToString(foutantwoord2);
                    RadioButtonList1.Items[randompositie3 - 1].Text = Convert.ToString(foutantwoord3);
                    RadioButtonList1.Items[randompositie4 -1].Text = Convert.ToString(goedantwoord);

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

        protected void nextbutton_Click(object sender, EventArgs e)
        {
            if (IsPostBack == true)
            {
                int aantalvragen = Convert.ToInt16(Session["aantalvragen"]);
                aantalvragen++;
                lblvragen.Text = "Vraag " + aantalvragen + " van 50";
                Session["aantalvragen"] = aantalvragen;
                
            }
        }
    }
}
