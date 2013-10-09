<%@ Page Title="Rekenen" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="MetSommenWerken.aspx.cs" Inherits="ToetsendRekenen.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
    <link href="Stylesheets/banaan.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>
        //Globale variabelen.
        var aantalGoed = 0;
        var voortgang = 1;
        var slidergetal1 = parseInt("<%=getalslider1%>");
        var slidergetal2 = parseInt("<%=getalslider2%>");
        var moeilijkheidsgraad = ("<%=moeilijkheidsgraad%>");
        var subcategorie = ("<%=subcategorie%>");

        //Variabelen voor de random getallen.
        var getal1 = 0;
        var getal2 = 0;
        var floatgetal1 = 0;
        var floatgetal2 = 0;
        var antwoord = 0;
        
        //Variabelen voor de timer.
        var sTime = new Date().getTime();
        var countDown = 1500;

        function UpdateTime() {
            var cTime = new Date().getTime();
            var diff = cTime - sTime;
            var seconds = countDown - Math.floor(diff / 1000);
            if (seconds >= 0) {
                var minutes = Math.floor(seconds / 60);
                seconds -= minutes * 60;
                $("#minutes").text(minutes < 10 ? "0" + minutes : minutes);
                $("#seconds").text(seconds < 10 ? "0" + seconds : seconds);
            } else {
                $("#countdown").hide();
                $("#aftercount").show();
                $("#antwoord").attr("readonly", true);
                $("#divNaarResultaat").attr("hidden", false);
                $("#volgende").attr("hidden", true);
                $("#zieAntwoord").attr("hidden", true);
                clearInterval(counter);
            }
        }
        UpdateTime();
        var counter = setInterval(UpdateTime, 1000);
        
        //Maak random vraag, NIET AAN DE MATH.RANDOM ZITTEN!!
        function maakVraag() {
            if (subcategorie == "Erbijsommen") {
                if (moeilijkheidsgraad == "Makkelijk") {
                    getal1 = Math.floor(Math.random() * slidergetal2) + slidergetal1;
                    getal2 = Math.floor(Math.random() * slidergetal2) + slidergetal1;
                    antwoord = getal1 + getal2;
                }
                else if (moeilijkheidsgraad == "Normaal") {
                    getal1 = (Math.random() * (slidergetal2 - slidergetal1) + slidergetal1).toFixed(2);
                    getal2 = (Math.random() * (slidergetal2 - slidergetal1) + slidergetal1).toFixed(2);
                    floatgetal1 = parseFloat(getal1);
                    floatgetal2 = parseFloat(getal2);
                    antwoord = (floatgetal1 + floatgetal2).toFixed(2).toString().replace('.', ',');
                }
                else if (moeilijkheidsgraad == "Moeilijk") {
                    getal1 = (Math.random() * (slidergetal2 - slidergetal1) + slidergetal1).toFixed(4);
                    getal2 = (Math.random() * (slidergetal2 - slidergetal1) + slidergetal1).toFixed(4);
                    floatgetal1 = parseFloat(getal1);
                    floatgetal2 = parseFloat(getal2);
                    antwoord = (floatgetal1 + floatgetal2).toFixed(4).toString().replace('.', ',');
                }
            }
            else if (subcategorie == "Keersommen") {
                if (moeilijkheidsgraad == "Makkelijk") {
                    getal1 = Math.floor(Math.random() * slidergetal2) + slidergetal1;
                    getal2 = Math.floor(Math.random() * slidergetal2) + slidergetal1;
                    antwoord = getal1 * getal2;
                }
                else if (moeilijkheidsgraad == "Normaal") {
                    getal1 = (Math.random() * (slidergetal2 - slidergetal1) + slidergetal1).toFixed(1);
                    getal2 = (Math.random() * (slidergetal2 - slidergetal1) + slidergetal1).toFixed(1);
                    floatgetal1 = parseFloat(getal1);
                    floatgetal2 = parseFloat(getal2);
                    antwoord = (floatgetal1 * floatgetal2).toFixed(2).toString().replace('.', ',');
                }
                else if (moeilijkheidsgraad == "Moeilijk") {
                    getal1 = (Math.random() * (slidergetal2 - slidergetal1) + slidergetal1).toFixed(2);
                    getal2 = (Math.random() * (slidergetal2 - slidergetal1) + slidergetal1).toFixed(2);
                    floatgetal1 = parseFloat(getal1);
                    floatgetal2 = parseFloat(getal2);
                    antwoord = (floatgetal1 * floatgetal2).toFixed(4).toString().replace('.', ',');
                }
            }
            else if (subcategorie == "Erafsommen") {
                if (moeilijkheidsgraad == "Makkelijk") {
                    getal1 = Math.floor(Math.random() * (slidergetal2 - slidergetal1)) + slidergetal1;
                    getal2 = Math.floor(Math.random() * (slidergetal2 - slidergetal1)) + slidergetal1;
                    if (getal1 < getal2) {
                        maakVraag();
                    }
                    else {
                        antwoord = getal1 - getal2;
                    }
                }
                else if (moeilijkheidsgraad == "Normaal") {
                    getal1 = (Math.random() * (slidergetal2 - slidergetal1) + slidergetal1).toFixed(2);
                    getal2 = (Math.random() * (slidergetal2 - slidergetal1) + slidergetal1).toFixed(2);
                    floatgetal1 = parseFloat(getal1);
                    floatgetal2 = parseFloat(getal2);
                    if (getal1 < getal2) {
                        maakVraag();
                    }
                    else {
                        antwoord = (floatgetal1 - floatgetal2).toFixed(2).toString().replace('.', ',');
                    }
                }
                else if (moeilijkheidsgraad == "Moeilijk") {
                    getal1 = (Math.random() * (slidergetal2 - slidergetal1) + slidergetal1).toFixed(4);
                    getal2 = (Math.random() * (slidergetal2 - slidergetal1) + slidergetal1).toFixed(4);
                    floatgetal1 = parseFloat(getal1);
                    floatgetal2 = parseFloat(getal2);
                    if (getal1 < getal2) {
                        maakVraag();
                    }
                    else {
                        antwoord = (floatgetal1 - floatgetal2).toFixed(4).toString().replace('.', ',');
                    }
                }
            }
            if (subcategorie == "Deelsommen") {
                if (moeilijkheidsgraad == "Makkelijk") {
                    getal1 = Math.floor(Math.random() * slidergetal2) + slidergetal1;
                    getal2 = Math.floor(Math.random() * slidergetal2) + slidergetal1;
                    if (parseInt(getal1) < parseInt(getal2)) {
                        maakVraag();
                    }
                    else {
                        antwoord = parseInt(getal1 / getal2);
                    }      
                }
                else if (moeilijkheidsgraad == "Normaal") {
                    getal1 = (Math.random() * (slidergetal2 - slidergetal1) + slidergetal1).toFixed(1);
                    getal2 = (Math.random() * (slidergetal2 - slidergetal1) + slidergetal1).toFixed(1);
                    floatgetal1 = parseFloat(getal1);
                    floatgetal2 = parseFloat(getal2);
                    antwoord = (floatgetal1 / floatgetal2).toFixed(2).toString().replace('.', ',');
                }
                else if (moeilijkheidsgraad == "Moeilijk") {
                    getal1 = (Math.random() * (slidergetal2 - slidergetal1) + slidergetal1).toFixed(2);
                    getal2 = (Math.random() * (slidergetal2 - slidergetal1) + slidergetal1).toFixed(2);
                    floatgetal1 = parseFloat(getal1);
                    floatgetal2 = parseFloat(getal2);
                    antwoord = (floatgetal1 / floatgetal2).toFixed(4).toString().replace('.', ',');
                }
            }
        }

        function toonVraag() {
            $("#vraag").empty();
            if (subcategorie == "Erbijsommen") {
                if (moeilijkheidsgraad == "Makkelijk") {
                    $("#vraag").append("Wat is " + getal1 + " + " + getal2 + "? (Vul een heel getal in).");
                }
                else if (moeilijkheidsgraad == "Normaal") {
                    $("#vraag").append("Wat is " + floatgetal1.toString().replace('.', ',') + " + " + floatgetal2.toString().replace('.', ',') + "? (Afronden tot twee cijfers achter de komma).");
                }
                else if (moeilijkheidsgraad == "Moeilijk") {
                    $("#vraag").append("Wat is " + floatgetal1.toString().replace('.', ',') + " + " + floatgetal2.toString().replace('.', ',') + "? (Afronden tot vier cijfers achter de komma).");
                }
            }
            else if (subcategorie == "Keersommen") {
                if (moeilijkheidsgraad == "Makkelijk") {
                    $("#vraag").append("Wat is " + getal1 + " x " + getal2 + "? (Vul een heel getal in).");
                }
                else if (moeilijkheidsgraad == "Normaal") {
                    $("#vraag").append("Wat is " + floatgetal1.toString().replace('.', ',') + " x " + floatgetal2.toString().replace('.', ',') + "? (Afronden tot twee cijfers achter de komma).");
                }
                else if (moeilijkheidsgraad == "Moeilijk") {
                    $("#vraag").append("Wat is " + floatgetal1.toString().replace('.', ',') + " x " + floatgetal2.toString().replace('.', ',') + "? (Afronden tot vier cijfers achter de komma).");
                }
            }
            else if (subcategorie == "Erafsommen") {
                if (moeilijkheidsgraad == "Makkelijk") {
                    $("#vraag").append("Wat is " + getal1 + " - " + getal2 + "? (Vul een heel getal in).");
                }
                else if (moeilijkheidsgraad == "Normaal") {
                    $("#vraag").append("Wat is " + floatgetal1.toString().replace('.', ',') + " - " + floatgetal2.toString().replace('.', ',') + "? (Afronden tot twee cijfers achter de komma).");
                }
                else if (moeilijkheidsgraad == "Moeilijk") {
                    $("#vraag").append("Wat is " + floatgetal1.toString().replace('.', ',') + " - " + floatgetal2.toString().replace('.', ',') + "? (Afronden tot vier cijfers achter de komma).");
                }
            }
            else if (subcategorie == "Deelsommen") {
                if (moeilijkheidsgraad == "Makkelijk") {
                    $("#vraag").append("Wat is " + getal1 + " / " + getal2 + "? (Afronden tot een heel getal).");
                }
                else if (moeilijkheidsgraad == "Normaal") {
                    $("#vraag").append("Wat is " + floatgetal1.toString().replace('.', ',') + " / " + floatgetal2.toString().replace('.', ',') + "? (Afronden tot twee cijfers achter de komma).");
                }
                else if (moeilijkheidsgraad == "Moeilijk") {
                    $("#vraag").append("Wat is " + floatgetal1.toString().replace('.', ',') + " / " + floatgetal2.toString().replace('.', ',') + "? (Afronden tot vier cijfers achter de komma).");
                }
            }
        }

        $(function () {

            maakVraag();

            //Alleen nummers toestaan in tekstbox
            $("#antwoord").keydown(function (e) {
                var key = e.charCode || e.keyCode || 0;
                return (
                    key == 8 ||
                    key == 9 ||
                    key == 46 ||
                    key == 110 ||
                    key == 188 ||
                    key == 190 ||
                    (key >= 35 && key <= 40) ||
                    (key >= 48 && key <= 57) ||
                    (key >= 96 && key <= 105));
            });

            //Eerste buttons hiden.
            $("#volgende").attr("hidden", true);
            $("#divNaarResultaat").attr("hidden", true);

            //De vraag en voortgang in de desbetreffende divs zetten.
            toonVraag();
            
            $("#voortgang").append("Vraag " + voortgang + " van 50.");

            

            //Button click functie
            $("#zieAntwoord").click(function () {
                //Divs en buttons properties veranderen.
                $("#antwoord").attr("readonly", true);
                $("#volgende").attr("value", "Volgende");
                $("#volgende").attr("hidden", false);
                $("#zieAntwoord").attr("hidden", true);
                $("#uitleg").removeAttr("hidden");

                //If else kijkt of het antwoord goed is.
                if ($("#antwoord").val() != antwoord) {
                    $("#fout").removeAttr("hidden");
                }
                else {
                    $("#goed").removeAttr("hidden");
                    aantalGoed = aantalGoed + 1;
                }

                //If else voor de aantal goed beantwoorde vragen.
                $("#aantalgoed").empty();
                if (aantalGoed == 1) {
                    $("#aantalgoed").append(aantalGoed + " vraag goed bantwoord");
                }

                else if (aantalGoed == 0 || aantalGoed > 1) {
                    $("#aantalgoed").append(aantalGoed + " vragen goed bantwoord");
                }

                //Uitleg erbij zetten.
                $("#uitleg").empty();

                if (subcategorie == "Erbijsommen") {
                    if (moeilijkheidsgraad == "Makkelijk") {
                        $("#uitleg").append("Stel je hebt " + getal1 + ", dan tel je er " + getal2 + "  bij. Het antwoord is dus " + antwoord + "!")
                    }
                    else {
                        $("#uitleg").append("Stel je hebt " + floatgetal1.toString().replace('.', ',') + ", dan tel je er " + floatgetal2.toString().replace('.', ',') + "  bij. Het antwoord is dus " + antwoord.replace('.', ',') + "!")
                    }
                }
                else if (subcategorie == "Erafsommen") {
                    if (moeilijkheidsgraad == "Makkelijk") {
                        $("#uitleg").append("Stel je hebt " + getal1 + ", dan haal je er " + getal2 + "  af. Het antwoord is dus " + antwoord + "!")
                    }
                    else {
                        $("#uitleg").append("Stel je hebt " + floatgetal1.toString().replace('.', ',') + ", dan haal je er " + floatgetal2.toString().replace('.', ',') + "  af. Het antwoord is dus " + antwoord.replace('.', ',') + "!")
                    }
                }
                else if (subcategorie == "Keersommen") {
                    if (moeilijkheidsgraad == "Makkelijk") {
                        $("#uitleg").append("Stel je hebt " + getal1 + ", dan vermenigvuldig je het met " + getal2 + ". Het antwoord is dus " + antwoord + "!")
                    }
                    else {
                        $("#uitleg").append("Stel je hebt " + floatgetal1.toString().replace('.', ',') + ", dan vermenigvuldig je het met " + floatgetal2.toString().replace('.', ',') + ". Het antwoord is dus " + antwoord.replace('.', ',') + "!")
                    }
                }
                else if (subcategorie == "Deelsommen") {
                    if (moeilijkheidsgraad == "Makkelijk") {
                        $("#uitleg").append("Stel je hebt " + getal1 + ", dan deel je het door " + getal2 + ". Het antwoord is dus " + antwoord + "!")
                    }
                    else {
                        $("#uitleg").append("Stel je hebt " + floatgetal1.toString().replace('.', ',') + ", dan deel je het door " + floatgetal2.toString().replace('.', ',') + ". Het antwoord is dus " + antwoord.replace('.', ',') + "!")
                    }
                }

                //Image voor sterren erbij zetten.
                $('#sterren').empty();
                for (var i = 0; i < Math.floor(aantalGoed / 10); i++) {
                    var img = document.createElement("img");
                    img.src = "Images/ster.jpg";

                    $('#sterren').append(img);
                }

                //Button naar resultaat laten zien.
                if (voortgang == 50) {
                    $("#volgende").attr("hidden", true);
                    $("#divNaarResultaat").attr("hidden", false);
                    $("#inputaantalgoed").val(aantalGoed);
                }
               

            });

            //Tweede button click functie.
            $("#volgende").click(function () {
                //Divs en buttons properties veranderen.
                $("#antwoord").attr("readonly", false);
                $("#volgende").attr("hidden", true);
                $("#zieAntwoord").attr("hidden", false);
                $("#uitleg").empty();
                $("#fout").attr("hidden", true);
                $("#goed").attr("hidden", true);
                $("#antwoord").val('');
                $("#antwoord").focus();
                $("#voortgang").empty();
                voortgang = voortgang + 1;
                $("#voortgang").append("vraag " + voortgang + " van 50");

                maakVraag();
                toonVraag();
            });
        });
    </script>

    <div id="sterren">
    </div>

    <div id="bananen">
        <img src="Images/banaan.jpg" />
    </div>
    <div id="vraag">
    </div>
    <input type="text" id="antwoord" placeholder="Vul hier je antwoord in" onkeydown="return (event.keyCode!=13);" autocomplete="off" />
    <br />
    <div>
        <p id="fout" hidden="hidden">Je antwoord is fout.</p>
        <p id="goed" hidden="hidden">Je antwoord is goed!</p>
        <div id="uitleg">
        </div>
    </div>
    <input type="button" id="zieAntwoord" value="Zie antwoord" />
    <input type="button" id="volgende" value="Volgende" />
    <div id="divNaarResultaat">
        <asp:Button ID="naarResultaat" Text="Naar resultaat" runat="server" OnClick="naarResultaat_Click" />
    </div>
    <%-- Divs en inputs voor javascript variabelen --%>
    <div id="voortgang">
    </div>
    <div id="aantalgoed">
    </div>
    <input type="hidden" id="inputaantalgoed" name="inputaantalgoed"/>

    <div id="countdown">
    <div id="minutes" style="float:left">25</div>
    <div style="float:left">:</div>
    <div id="seconds" style="float:left">00</div>
    </div>
    <div id="aftercount" style="display:none">Tijd is voorbij</div>

</asp:Content>
