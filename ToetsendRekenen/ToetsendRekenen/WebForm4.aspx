<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="ToetsendRekenen.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="Change">
    <asp:Label ID="Label1" runat="server" Text="Oude wachtwoord" CssClass="lblOwachtwoord"></asp:Label>
    <asp:TextBox ID="tbOudeWachtwoord" runat="server" CssClass="tbOudeWachtwoordClass"></asp:TextBox>

    </div>


    <asp:GridView ID="Resultaat" runat="server">
    </asp:GridView>



</asp:Content>
