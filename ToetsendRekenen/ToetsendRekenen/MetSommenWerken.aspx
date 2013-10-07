<%@ Page Title="Rekenen" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="MetSommenWerken.aspx.cs" Inherits="ToetsendRekenen.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
    <link href="Stylesheets/banaan.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>
        //Alle variabelen.
        var aantalGoed = 0;
        var voortgang = 49;
        var slidergetal1 = parseInt("<%=getalslider1%>");
        var slidergetal2 = parseInt("<%=getalslider2%>");
        var moeilijkheidsgraad = ("<%=moeilijkheidsgraad%>");
        if (moeilijkheidsgraad == "Makkelijk") {
            var getal1 = Math.floor(Math.random() * slidergetal2) + slidergetal1;
            var getal2 = Math.floor(Math.random() * slidergetal2) + slidergetal1;
            var antwoord = getal1 + getal2;
        }
        else if (moeilijkheidsgraad == "Normaal") {
            var getal1 = (Math.random() * slidergetal2 + slidergetal1).toFixed(2);
            var getal2 = (Math.random() * slidergetal2 + slidergetal1).toFixed(2);
            floatgetal1 = parseFloat(getal1);
            floatgetal2 = parseFloat(getal2);
            var antwoord = (floatgetal1 + floatgetal2).toString().replace('.', ',');
        }
        else if (moeilijkheidsgraad == "Moeilijk") {
            var getal1 = (Math.random() * slidergetal2 + slidergetal1).toFixed(4);
            var getal2 = (Math.random() * slidergetal2 + slidergetal1).toFixed(4);
            floatgetal1 = parseFloat(getal1);
            floatgetal2 = parseFloat(getal2);
            var antwoord = (floatgetal1 + floatgetal2).toString().replace('.', ',');
        }


        $(function () {
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
            if (moeilijkheidsgraad == "Makkelijk") {
                $("#vraag").append("Wat is " + getal1 + " + " + getal2 + "? (Vul een heel getal in).");
            }
            else if (moeilijkheidsgraad == "Normaal") {
                $("#vraag").append("Wat is " + getal1.replace('.', ',') + " + " + getal2.replace('.', ',') + "? (Één tot twee cijfers achter de comma).");
            }
            else if (moeilijkheidsgraad == "Moeilijk") {
                $("#vraag").append("Wat is " + getal1.replace('.', ',') + " + " + getal2.replace('.', ',') + "? (Één tot vijf cijfers achter de comma).");
            }
            
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

                if (moeilijkheidsgraad == "Makkelijk") {
                    $("#uitleg").append("Stel je hebt " + getal1 + ", dan tel je er " + getal2 + "  bij. Het antwoord is dus " + antwoord + "!")
                }
                else {
                    $("#uitleg").append("Stel je hebt " + getal1.replace('.', ',') + ", dan tel je er " + getal2.replace('.', ',') + "  bij. Het antwoord is dus " + antwoord.replace('.', ',') + "!")
                }
                

                //Image voor sterren erbij zetten.
                if (aantalGoed == 10) {
                    $("#sterren").empty();
                    var img = document.createElement("img");
                    img.src = "Images/ster.jpg";

                    var src = document.getElementById("sterren");
                    src.appendChild(img);
                }
                else if (aantalGoed == 20) {
                    $("#sterren").empty();
                    var img = document.createElement("img");
                    img.src = "Images/2sterren.jpg";

                    var src = document.getElementById("sterren");
                    src.appendChild(img);
                }
                else if (aantalGoed == 30) {
                    $("#sterren").empty();
                    var img = document.createElement("img");
                    img.src = "Images/3sterren.jpg";

                    var src = document.getElementById("sterren");
                    src.appendChild(img);
                }
                else if (aantalGoed == 40) {
                    $("#sterren").empty();
                    var img = document.createElement("img");
                    img.src = "Images/4sterren.jpg";

                    var src = document.getElementById("sterren");
                    src.appendChild(img);
                }
                else if (aantalGoed == 50) {
                    $("#sterren").empty();
                    var img = document.createElement("img");
                    img.src = "Images/5sterren.jpg";

                    var src = document.getElementById("sterren");
                    src.appendChild(img);
                }
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

                //Getallen opnieuw randomizen.
                if (moeilijkheidsgraad == "Makkelijk") {
                    var getal1 = Math.floor(Math.random() * slidergetal2) + slidergetal1;
                    var getal2 = Math.floor(Math.random() * slidergetal2) + slidergetal1;
                    var antwoord = getal1 + getal2;
                }
                else if (moeilijkheidsgraad == "Normaal") {
                    var getal1 = (Math.random() * slidergetal2 + slidergetal1).toFixed(2);
                    var getal2 = (Math.random() * slidergetal2 + slidergetal1).toFixed(2);
                    floatgetal1 = parseFloat(getal1);
                    floatgetal2 = parseFloat(getal2);
                    var antwoord = (floatgetal1 + floatgetal2).toString().replace('.', ',');
                }
                else if (moeilijkheidsgraad == "Moeilijk") {
                    var getal1 = (Math.random() * slidergetal2 + slidergetal1).toFixed(4);
                    var getal2 = (Math.random() * slidergetal2 + slidergetal1).toFixed(4);
                    floatgetal1 = parseFloat(getal1);
                    floatgetal2 = parseFloat(getal2);
                    var antwoord = (floatgetal1 + floatgetal2).toString().replace('.', ',');
                }
                $("#vraag").empty();
                $("#vraag").append("Wat is " + getal1 + " + " + getal2 + "? (Vul een heel getal in)");
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
</asp:Content>
