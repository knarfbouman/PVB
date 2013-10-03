<%@ Page Title="Resultaat" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Leerlingresultaat.aspx.cs" Inherits="ToetsendRekenen.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        var aantalgoed = localStorage.getItem("aantalgoed");
        var aantalsterren = Math.floor(aantalgoed / 10);
        $("#resultaat").append("Je hebt " + aantalgoed + " vragen van de 50 vragen goed beantwoord en # van de 5 sterren behaald.");
    </script>
    <h1>
        Resultaat
    </h1>
    <div id="resultaat">
    </div> 
    <div id="score">
        Score: ##% van 100%
    </div>
    <asp:Button ID="btnBack" runat="server" Text="Ga terug" OnClick="btnBack_Click" />
</asp:Content>
