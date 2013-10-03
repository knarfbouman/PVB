<%@ Page Title="Resultaat" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Leerlingresultaat.aspx.cs" Inherits="ToetsendRekenen.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        var aantalgoed = parseInt("<%=aantalgoed%>");
        var aantalsterren = Math.floor(aantalgoed / 10);
        var score = aantalgoed * 2;
        $(function () {
            $("#resultaat").append("Je hebt " + aantalgoed + " vragen van de 50 vragen goed beantwoord en " + aantalsterren + " van de 5 sterren behaald.");
            $("#score").append("Score: " + score + "% van 100%.");

            if (aantalsterren == 1)
            {
                var img = document.createElement("img");
                img.src = "Images/ster.jpg";

                var src = document.getElementById("sterren");
                src.appendChild(img);
            }
            if (aantalsterren == 2)
            {
                var img = document.createElement("img");
                img.src = "Images/2sterren.jpg";

                var src = document.getElementById("sterren");
                src.appendChild(img);
            }
            if (aantalsterren == 3)
            {
                var img = document.createElement("img");
                img.src = "Images/3sterren.jpg";

                var src = document.getElementById("sterren");
                src.appendChild(img);
            }
            if (aantalsterren == 4)
            {
                var img = document.createElement("img");
                img.src = "Images/4sterren.jpg";

                var src = document.getElementById("sterren");
                src.appendChild(img);
            }
            if (aantalsterren == 5)
            {
                var img = document.createElement("img");
                img.src = "Images/5sterren.jpg";

                var src = document.getElementById("sterren");
                src.appendChild(img);
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
