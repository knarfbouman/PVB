<%@ Page Title="Rekenenen" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="MetSommenWerken.aspx.cs" Inherits="ToetsendRekenen.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
    <link href="Jquery/banaan.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>
        $(function () {
            var aantalGoed = 10;
            if (aantalGoed = 10) {      
                var img = document.createElement("img");
                img.src = "Images/ster.jpg";
               
                var src = document.getElementById("sterren");
                src.appendChild(img);
            }

            $("#volgende").click(function () {
                $("#antwoord").attr("readonly", true);
                $("#volgende").attr("value", "Volgende");
                $("#uitleg").removeAttr("hidden");
                if ($("#antwoord").val() != "25") {
                    $("#fout").removeAttr("hidden");
                }
                else {
                    $("#goed").removeAttr("hidden");
                }
            })
        });
    </script> 

    <div id="sterren">
    </div>

    <div id="bananen">
        <img src="Images/banaan.jpg" />
    </div>
    <p>
        Je hebt 2 bananen, iemand geeft jou er 23 bananen bij.
        <br />
        Hoeveel bananen heb je nu?
    </p>
    <input type="text" id="antwoord" placeholder="Vul hier je antwoord in" />
    <br />
    <div>
        <p id="fout" hidden="hidden">Je antwoord is fout.</p>
        <p id="goed" hidden="hidden">Je antwoord is goed!</p>
        <p id="uitleg" hidden="hidden">Stel je hebt 23 bananen, dan doe je er 2 keer 1 bij, 24 en 25. Het antwoord is dus 25!</p>
    </div>
    <input type="button" id="volgende" value="Zie antwoord" />

</asp:Content>
