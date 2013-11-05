using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToetsendRekenen
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            string[] Instellingenarray = (string[])Session["subcategoriearray"];

            if (!IsPostBack)
            {




                if (Instellingenarray != null)
                {
                    string subcategorie = Instellingenarray[1];



                    //Pijl.CssClass = "eerste";
                    double firstnumber = 0;
                    double lastnumber = Convert.ToInt16(Instellingenarray[3]);
                    Random randomer = new Random();


                    int randomlastnumber = randomer.Next(Convert.ToInt16(firstnumber), Convert.ToInt16(lastnumber));







                    #region getallen

                    if (subcategorie == "Getallen")
                    {
                        double goedantwoord;
                        double foutantwoord1;
                        double foutantwoord2;
                        double foutantwoord3;

                        if (Convert.ToInt16(Session["aantalvragen"]) != 0)
                        {
                            int aantalvragen = Convert.ToInt16(Session["aantalvragen"]);
                            lblvragen.Text = "Vraag " + aantalvragen + " van 50";
                        }
                        else
                        {
                            lblvragen.Text = "Vraag " + 1 + " van 50";
                            Session["aantalvragen"] = 1;
                        }


                        if (Convert.ToString(Convert.ToString(Session["aantalvragengoed"])) != null)
                        {
                            int aantalvragen = Convert.ToInt16(Session["aantalvragen"]);
                            int aantalvragengoed = Convert.ToInt16(Session["aantalvragengoed"]);
                            lblgoed.Text = aantalvragengoed + "/" + (aantalvragen - 1) + " goed";
                            if (aantalvragengoed == 10 || aantalvragengoed > 10 && aantalvragengoed < 20)
                            {
                                sterren.ImageUrl = "~/Images/ster.jpg";
                            }
                            if (aantalvragengoed == 20 || aantalvragengoed > 20 && aantalvragengoed < 30)
                            {
                                sterren.ImageUrl = "~/Images/2sterren.jpg";
                            }
                            if (aantalvragengoed == 30 || aantalvragengoed > 30 && aantalvragengoed < 40)
                            {
                                sterren.ImageUrl = "~/Images/3sterren.jpg";
                            }
                            if (aantalvragengoed == 40 || aantalvragengoed > 40 && aantalvragengoed < 50)
                            {
                                sterren.ImageUrl = "~/Images/4sterren.jpg";
                            }
                            if (aantalvragengoed == 50)
                            {
                                sterren.ImageUrl = "~/Images/5sterren.jpg";
                            }

                        }
                        else
                        {
                            int aantalvragen = Convert.ToInt16(Session["aantalvragen"]);

                        }


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
                        double nietpijlgetal;

                        #region pijlpositie
                        do
                        {
                            randomlastnumber = randomer.Next(Convert.ToInt16(firstnumber), Convert.ToInt16(lastnumber));

                            getal1 = Convert.ToDouble(randomlastnumber * 0.3);
                            getal2 = Convert.ToDouble(randomlastnumber * 0.5);
                            getal3 = Convert.ToDouble(randomlastnumber * 0.8);
                            verlijkgetal1 = Math.Floor(getal1);
                            verlijkgetal2 = Math.Floor(getal2);
                            verlijkgetal3 = Math.Floor(getal3);
                            int randompijl = randomer.Next(1, 9);
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
                            if (randompijl == 7)
                            {
                                Pijl.CssClass = "derde";
                                pijlgetal = randomlastnumber * 0.3;
                            }
                            if (randompijl == 8)
                            {
                                Pijl.CssClass = "achtste";
                                pijlgetal = randomlastnumber * 0.8;
                            }
                            nietpijlgetal = Math.Floor(pijlgetal);



                        }

                        while (verlijkgetal1 != getal1 || verlijkgetal2 != getal2 || verlijkgetal3 != getal3 || randomlastnumber == 0 || nietpijlgetal != pijlgetal || pijlgetal < 2);
                        #endregion


                        goedantwoord = pijlgetal;
                        Session.Add("goedantwoord", goedantwoord);
                        #region geneerfouteantwoorden
                        do
                        {
                            int randomfoutgetal = randomer.Next(1, 6);
                            int randomfoutgetal2 = randomer.Next(2, 7);
                            double randomfoutgetal3 = randomer.Next(1, 10);
                            double komma = randomfoutgetal3 / 10;
                            foutantwoord1 = goedantwoord + randomfoutgetal;
                            foutantwoord2 = goedantwoord + randomfoutgetal2;
                            foutantwoord3 = Math.Round(goedantwoord * komma);
                        }
                        while (foutantwoord1 == goedantwoord || foutantwoord2 == goedantwoord || foutantwoord3 == goedantwoord || foutantwoord1 == foutantwoord2 || foutantwoord2 == foutantwoord3 || foutantwoord1 == foutantwoord3 || foutantwoord1 < 1 || foutantwoord2 < 1 || foutantwoord3 < 1 || foutantwoord1 == randomlastnumber || foutantwoord2 == randomlastnumber || foutantwoord3 == randomlastnumber);
                        #endregion

                        Label1.Text = Convert.ToString(firstnumber);
                        Label2.Text = Convert.ToString(randomlastnumber);

                        Label5.Text = Convert.ToString(getal2);

                        #region antwoordenpositioneren
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
                            RadioButtonList1.Items[randompositie1 - 1].Text = Convert.ToString(foutantwoord1);
                            RadioButtonList1.Items[randompositie2 - 1].Text = Convert.ToString(foutantwoord2);
                            RadioButtonList1.Items[randompositie3 - 1].Text = Convert.ToString(foutantwoord3);
                            RadioButtonList1.Items[randompositie4 - 1].Text = Convert.ToString(goedantwoord);

                        }


                        nietpijlgetal = Math.Floor(pijlgetal);


                        #endregion






                    }

                    #endregion




                    #region kommagetallen

                    if (subcategorie == "Kommagetallen")
                    {

                        

                            double goedantwoord;
                            double foutantwoord1;
                            double foutantwoord2;
                            double foutantwoord3;

                            if (Convert.ToInt16(Session["aantalvragen"]) != 0)
                            {
                                int aantalvragen = Convert.ToInt16(Session["aantalvragen"]);
                                lblvragen.Text = "Vraag " + aantalvragen + " van 50";
                            }
                            else
                            {
                                lblvragen.Text = "Vraag " + 1 + " van 50";
                                Session["aantalvragen"] = 1;
                            }


                            if (Convert.ToString(Convert.ToString(Session["aantalvragengoed"])) != null)
                            {
                                int aantalvragen = Convert.ToInt16(Session["aantalvragen"]);
                                int aantalvragengoed = Convert.ToInt16(Session["aantalvragengoed"]);
                                lblgoed.Text = aantalvragengoed + "/" + (aantalvragen - 1) + " goed";
                                if (aantalvragengoed == 10 || aantalvragengoed > 10 && aantalvragengoed < 20)
                                {
                                    sterren.ImageUrl = "~/Images/ster.jpg";
                                }
                                if (aantalvragengoed == 20 || aantalvragengoed > 20 && aantalvragengoed < 30)
                                {
                                    sterren.ImageUrl = "~/Images/2sterren.jpg";
                                }
                                if (aantalvragengoed == 30 || aantalvragengoed > 30 && aantalvragengoed < 40)
                                {
                                    sterren.ImageUrl = "~/Images/3sterren.jpg";
                                }
                                if (aantalvragengoed == 40 || aantalvragengoed > 40 && aantalvragengoed < 50)
                                {
                                    sterren.ImageUrl = "~/Images/4sterren.jpg";
                                }
                                if (aantalvragengoed == 50)
                                {
                                    sterren.ImageUrl = "~/Images/5sterren.jpg";
                                }

                            }
                            else
                            {
                                int aantalvragen = Convert.ToInt16(Session["aantalvragen"]);

                            }


                            do
                            {
                                randomlastnumber = randomer.Next(Convert.ToInt16(firstnumber), Convert.ToInt16(lastnumber));
                            }
                            while (randomlastnumber < 4);











                            Label1.Text = Convert.ToString(firstnumber);
                            Label2.Text = Convert.ToString(randomlastnumber);

                            Label5.Text = Convert.ToString(randomlastnumber * 0.5);

                            double getal1 = Convert.ToDouble(randomlastnumber * 0.3);
                            double getal2 = Convert.ToDouble(randomlastnumber * 0.5);
                            double getal3 = Convert.ToDouble(randomlastnumber * 0.8);
                            double verlijkgetal1 = Math.Floor(getal1);
                            double verlijkgetal2 = Math.Floor(getal2);
                            double verlijkgetal3 = Math.Floor(getal3);
                            double pijlgetal = 0;
                            




                            #region pijlpositie
                            do
                            {
                                randomlastnumber = randomer.Next(Convert.ToInt16(firstnumber), Convert.ToInt16(lastnumber));


                                int randompijl = randomer.Next(1, 9);
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
                                if (randompijl == 7)
                                {
                                    Pijl.CssClass = "derde";
                                    pijlgetal = randomlastnumber * 0.3;
                                }
                                if (randompijl == 8)
                                {
                                    Pijl.CssClass = "achtste";
                                    pijlgetal = randomlastnumber * 0.8;
                                }




                            }

                            while (randomlastnumber == 0 || pijlgetal < 2);
                            #endregion


                            goedantwoord = pijlgetal;
                            Session.Add("goedantwoord", goedantwoord);
                            #region geneerfouteantwoorden
                            do
                            {
                                int randomfoutgetal = randomer.Next(1, 6);
                                int randomfoutgetal2 = randomer.Next(2, 7);
                                double randomfoutgetal3 = randomer.Next(1, 10);
                                double komma = randomfoutgetal3 / 10;
                                foutantwoord1 = goedantwoord + randomfoutgetal;
                                foutantwoord2 = goedantwoord + randomfoutgetal2;
                                foutantwoord3 = Math.Round(goedantwoord * komma);
                            }
                            while (foutantwoord1 == goedantwoord || foutantwoord2 == goedantwoord || foutantwoord3 == goedantwoord || foutantwoord1 == foutantwoord2 || foutantwoord2 == foutantwoord3 || foutantwoord1 == foutantwoord3 || foutantwoord1 < 1 || foutantwoord2 < 1 || foutantwoord3 < 1 || foutantwoord1 == randomlastnumber || foutantwoord2 == randomlastnumber || foutantwoord3 == randomlastnumber);
                            #endregion



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
                                RadioButtonList1.Items[randompositie1 - 1].Text = Convert.ToString(foutantwoord1);
                                RadioButtonList1.Items[randompositie2 - 1].Text = Convert.ToString(foutantwoord2);
                                RadioButtonList1.Items[randompositie3 - 1].Text = Convert.ToString(foutantwoord3);
                                RadioButtonList1.Items[randompositie4 - 1].Text = Convert.ToString(goedantwoord);

                            }

                        


                        Label1.Text = Convert.ToString(firstnumber);
                        Label2.Text = Convert.ToString(randomlastnumber);

                        Label5.Text = Convert.ToString(randomlastnumber * 0.5);

                    }



                    #endregion
                    #region Breuken
                    if (subcategorie == "Breuken")
                    {
                        double goedantwoord;
                        double foutantwoord1;
                        double foutantwoord2;
                        double foutantwoord3;

                        if (Convert.ToInt16(Session["aantalvragen"]) != 0)
                        {
                            int aantalvragen = Convert.ToInt16(Session["aantalvragen"]);
                            lblvragen.Text = "Vraag " + aantalvragen + " van 50";
                        }
                        else
                        {
                            lblvragen.Text = "Vraag " + 1 + " van 50";
                            Session["aantalvragen"] = 1;
                        }


                        if (Convert.ToString(Convert.ToString(Session["aantalvragengoed"])) != null)
                        {
                            int aantalvragen = Convert.ToInt16(Session["aantalvragen"]);
                            int aantalvragengoed = Convert.ToInt16(Session["aantalvragengoed"]);
                            lblgoed.Text = aantalvragengoed + "/" + (aantalvragen - 1) + " goed";
                            if (aantalvragengoed == 10 || aantalvragengoed > 10 && aantalvragengoed < 20)
                            {
                                sterren.ImageUrl = "~/Images/ster.jpg";
                            }
                            if (aantalvragengoed == 20 || aantalvragengoed > 20 && aantalvragengoed < 30)
                            {
                                sterren.ImageUrl = "~/Images/2sterren.jpg";
                            }
                            if (aantalvragengoed == 30 || aantalvragengoed > 30 && aantalvragengoed < 40)
                            {
                                sterren.ImageUrl = "~/Images/3sterren.jpg";
                            }
                            if (aantalvragengoed == 40 || aantalvragengoed > 40 && aantalvragengoed < 50)
                            {
                                sterren.ImageUrl = "~/Images/4sterren.jpg";
                            }
                            if (aantalvragengoed == 50)
                            {
                                sterren.ImageUrl = "~/Images/5sterren.jpg";
                            }

                        }
                        else
                        {
                            int aantalvragen = Convert.ToInt16(Session["aantalvragen"]);

                        }


                        do
                        {
                            randomlastnumber = randomer.Next(Convert.ToInt16(firstnumber), Convert.ToInt16(lastnumber));
                        }
                        while (randomlastnumber < 4);

                        

                        
                        double getal2 = Convert.ToDouble(randomlastnumber * 0.5);
                       
                       
                        double verlijkgetal2 = Math.Floor(getal2);
                       
                        double pijlgetal = 0;
                        double nietpijlgetal;

                        #region pijlpositie
                        do
                        {
                            randomlastnumber = randomer.Next(Convert.ToInt16(firstnumber), Convert.ToInt16(lastnumber));
                            


                        
                            getal2 = Convert.ToDouble(randomlastnumber * 0.5);
                          
                           
                            verlijkgetal2 = Math.Floor(getal2);
                           
                            int randompijl = randomer.Next(1, 9);
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
                            if (randompijl == 7)
                            {
                                Pijl.CssClass = "derde";
                                pijlgetal = randomlastnumber * 0.3;
                            }
                            if (randompijl == 8)
                            {
                                Pijl.CssClass = "achtste";
                                pijlgetal = randomlastnumber * 0.8;
                            }
                            nietpijlgetal = Math.Floor(pijlgetal);



                        }

                        while ( verlijkgetal2 != getal2  || randomlastnumber == 0 || nietpijlgetal != pijlgetal || pijlgetal < 2);
                        #endregion


                        goedantwoord = pijlgetal;
                        Session.Add("goedantwoord", goedantwoord);
                        #region geneerfouteantwoorden
                        do
                        {
                            int randomfoutgetal = randomer.Next(1, 6);
                            int randomfoutgetal2 = randomer.Next(2, 7);
                            double randomfoutgetal3 = randomer.Next(1, 10);
                            double komma = randomfoutgetal3 / 10;
                            foutantwoord1 = goedantwoord + randomfoutgetal;
                            foutantwoord2 = goedantwoord + randomfoutgetal2;
                            foutantwoord3 = Math.Round(goedantwoord * komma);
                        }
                        while (foutantwoord1 == goedantwoord || foutantwoord2 == goedantwoord || foutantwoord3 == goedantwoord || foutantwoord1 == foutantwoord2 || foutantwoord2 == foutantwoord3 || foutantwoord1 == foutantwoord3 || foutantwoord1 < 1 || foutantwoord2 < 1 || foutantwoord3 < 1 || foutantwoord1 == randomlastnumber || foutantwoord2 == randomlastnumber || foutantwoord3 == randomlastnumber);
                        #endregion

                        Label1.Text = Convert.ToString(firstnumber);
                        Label2.Text = Convert.ToString(randomlastnumber);

                        Label5.Text = Convert.ToString(getal2);

                        #region antwoordenpositioneren
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
                            RadioButtonList1.Items[randompositie1 - 1].Text = Convert.ToString(foutantwoord1) + "/" + randomlastnumber;
                            RadioButtonList1.Items[randompositie2 - 1].Text = Convert.ToString(foutantwoord2) + "/" + randomlastnumber;
                            RadioButtonList1.Items[randompositie3 - 1].Text = Convert.ToString(foutantwoord3) + "/" + randomlastnumber;
                            RadioButtonList1.Items[randompositie4 - 1].Text = Convert.ToString(goedantwoord) + "/" + randomlastnumber ;
                            RadioButtonList1.Items[randompositie1 - 1].Value = Convert.ToString(foutantwoord1);
                            RadioButtonList1.Items[randompositie2 - 1].Value = Convert.ToString(foutantwoord2);
                            RadioButtonList1.Items[randompositie3 - 1].Value = Convert.ToString(foutantwoord3);
                            RadioButtonList1.Items[randompositie4 - 1].Value = Convert.ToString(goedantwoord);
                        }


                        nietpijlgetal = Math.Floor(pijlgetal);


                        #endregion






                    }
                    #endregion
                }
                else
                {
                    Response.Redirect("/Home.aspx");

                }



            }
        }

        protected void nextbutton_Click(object sender, EventArgs e)
        {
            
            if (IsPostBack == true)
            {
                double test = Math.Round(Convert.ToDouble(Session["goedantwoord"]),1);


                if (RadioButtonList1.SelectedIndex == -1)
                {
                    lblerror.Visible = true;
                    lblerror.Text = "Voer een antwoord in!";
                    
                    
                }
                else
                {

                    if (Convert.ToDouble(RadioButtonList1.SelectedItem.Value.ToString()) ==test)
                    {
                        int aantalgoed = Convert.ToInt16(Session["aantalvragengoed"]);
                        aantalgoed++;
                        Session["aantalvragengoed"] = aantalgoed;
                    }
                    int aantalvragen = Convert.ToInt16(Session["aantalvragen"]);
                    aantalvragen++;
                    Session["aantalvragen"] = aantalvragen;
                    lblvragen.Text = "Vraag " + aantalvragen + " van 50";
                    RadioButtonList1.SelectedItem.Selected = false;
                    if (aantalvragen < 50 || aantalvragen == 50)
                    {
                        Response.Redirect("Getallenlijn.aspx");
                    }
                    else
                    {
                        Resultatenbutton.Visible = true;
                        Resultatenbutton.Enabled = true;
                        getallenlijn.Visible = false;
                        RadioButtonList1.Items.Clear();
                        nextbutton.Enabled = false;
                        Pijl.Visible = false;
                        Label1.Visible = false;
                        Label2.Visible = false;
                        lblvragen.Visible = false;
                        lblgoed.Visible = false;
                        nextbutton.Visible = false;
                        Label5.Visible = false;
                        Session["aantalgoedsession"] = Convert.ToString(Session["aantalvragengoed"]);

                        
                    }
                }




            }
        }

        protected void Resultatenbutton_Click(object sender, EventArgs e)
        {
            Response.Redirect("leerlingresultaat.aspx");
           
        }
    }
}


