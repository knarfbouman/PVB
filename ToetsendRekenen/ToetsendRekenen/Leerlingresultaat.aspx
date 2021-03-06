﻿<%@ Page Title="Resultaat" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Leerlingresultaat.aspx.cs" Inherits="ToetsendRekenen.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        var aantalgoed = parseInt("<%=aantalgoed%>");
        var subcategorie = ("<%=subcategorie%>");
        var aantalsterren = Math.floor(aantalgoed / 10);
        var score = aantalgoed * 2;
        $(function () {
            $("#resultaat").append("Je hebt " + aantalgoed + " vragen van de 50 vragen goed beantwoord en " + aantalsterren + " van de 5 sterren behaald voor "+ subcategorie + ".");
            $("#score").append("Score: " + score + "% van 100%.");

            for (var i = 0; i < Math.floor(aantalgoed / 10) ; i++) {
                var img = document.createElement("img");
                img.src = "Images/ster.jpg";

                $('#sterren').append(img);
            }
        });
    </script>
    <h1>
        Resultaat
    </h1>
    <div id="sterren">
    </div>
    <div id="resultaat">
    </div> 
    <br />
    <br />
    <div id="score">
    </div>
    <asp:Button ID="btnBack" runat="server" Text="Ga terug" OnClick="btnBack_Click" />
</asp:Content>
