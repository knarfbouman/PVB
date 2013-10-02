<%@ Page Title="Rekenen" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="MetSommenWerken.aspx.cs" Inherits="ToetsendRekenen.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
    <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
    <link href="Stylesheets/banaan.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>
        $(function () {
            $("#antwoord").keyup(function (event) {
                if (event.keyCode == 13) {
                    $("#zieAntwoord").click();
                }
            });

            $("#volgende").attr("hidden", true);
            var aantalGoed = 0;
            
            var voortgang = 1;
            var getal1 = Math.floor(Math.random() * 10) + 1;
            var getal2 = Math.floor(Math.random() * 10) + 1;
            var antwoord = getal1 + getal2;
            $("#vraag").append("Wat is " + getal1 + " + " + getal2 + "? (Vul een heel getal in)");
            $("#voortgang").append("vraag " + voortgang + " van 50");

            

            $("#zieAntwoord").click(function () {

                $("#antwoord").attr("readonly", true);
                $("#volgende").attr("value", "Volgende");
                $("#volgende").attr("hidden", false);
                $("#zieAntwoord").attr("hidden", true);
                $("#uitleg").removeAttr("hidden");
                
                if ($("#antwoord").val() != antwoord) {
                    $("#fout").removeAttr("hidden");

                }
                else {
                    $("#goed").removeAttr("hidden");
                    aantalGoed = aantalGoed + 1;
                }
                $("#aantalgoed").empty();
                if (aantalGoed == 0 || aantalGoed == 1) {
                    $("#aantalgoed").append(aantalGoed + " vraag goed bantwoord");
                }

                else if (aantalGoed > 1) {
                    $("#aantalgoed").append(aantalGoed + " vragen goed bantwoord");
                }
                if (aantalGoed == 10) {
                    var img = document.createElement("img");
                    img.src = "Images/ster.jpg";

                    var src = document.getElementById("sterren");
                    src.appendChild(img);
                }

            });
            $("#volgende").click(function () {
                $("#antwoord").attr("readonly", false);
                $("#volgende").attr("hidden", true);
                $("#zieAntwoord").attr("hidden", false);
                $("#fout").attr("hidden", true);
                $("#goed").attr("hidden", true);
                $("#antwoord").val('');
                $("#antwoord").focus();
                $("#voortgang").empty();
                voortgang = voortgang + 1;
                $("#voortgang").append("vraag " + voortgang + " van 50");
                
                getal1 = Math.floor(Math.random() * 10) + 1;
                getal2 = Math.floor(Math.random() * 10) + 1;
                antwoord = getal1 + getal2;
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
        <%--<p id="uitleg" hidden="hidden">Stel je hebt 23 bananen, dan doe je er 2 keer 1 bij, 24 en 25. Het antwoord is dus 25!</p>--%>
    </div>
    <input type="button" id="zieAntwoord" value="Zie antwoord" />
    <input type="button" id="volgende" value="Volgende" />
    <div id="voortgang">
    </div>
    <div id="aantalgoed">
    </div>

</asp:Content>
