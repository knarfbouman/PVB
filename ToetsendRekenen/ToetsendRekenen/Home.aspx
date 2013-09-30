<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ToetsendRekenen.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            <div id="ButtonRow1">
            <asp:Button ID="Opdracht1" runat="server" Text="Opdracht 1" CSSclass="Button" OnClick="Opdracht1_Click"/>
            <asp:Button ID="Opdracht2" runat="server" Text="Opdracht 2" CSSclass="Button"/>
            <asp:Button ID="Opdracht3" runat="server" Text="Opdracht 3" CSSclass="Button"/>
            </div>
            <div id="ButtonRow2">
            <asp:Button ID="Opdracht6" runat="server" Text="Opdracht 6" CSSclass="Button"/>
            <asp:Button ID="Opdracht7" runat="server" Text="Opdracht 7" CSSclass="Button"/>
            <asp:Button ID="Opdracht8" runat="server" Text="Opdracht 8" CSSclass="Button"/>
            </div>
            <div id="ButtonRow3">
            <asp:Button ID="Opdracht4" runat="server" Text="Opdracht 4" CSSclass="Button"/>
            <asp:Button ID="Opdracht5" runat="server" Text="Opdracht 5" CSSclass="Button"/>
            <asp:Button ID="Adminbutton" runat="server" Text="Resultaten" CSSclass="Button"/>
            </div>

            <div id="Tekst">
                <asp:Label ID="Label1" runat="server" Text="Hier komt het verhaal te staan over deze site :)"></asp:Label>
            </div>
    
</asp:Content>

