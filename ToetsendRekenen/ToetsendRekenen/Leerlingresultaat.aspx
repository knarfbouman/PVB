﻿<%@ Page Title="Resultaat" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Leerlingresultaat.aspx.cs" Inherits="ToetsendRekenen.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        Resultaat
    </h1>
    <p>
        Je hebt # van de 50 vragen goed beantwoord.
    </p> 
    <p>
        Dat betekent  dat je ##% hebt gehaald.
    </p>
    <asp:Button ID="btnBack" runat="server" Text="Ga terug naar sommen" OnClick="btnBack_Click" />
</asp:Content>
