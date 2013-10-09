<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ToetsendRekenen.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            <div id="ButtonRow1">
            <asp:Button ID="Opdracht1" runat="server" Text="Met Sommen Werken" CSSclass="Button" OnClick="Opdracht1_Click"/>
            <asp:Button ID="Opdracht2" runat="server" Text="Getallenlijn" CSSclass="Button" OnClick="Opdracht2_Click"/>
            <asp:Button ID="Opdracht3" runat="server" Text="Opdracht 3" CSSclass="Button" OnClick="Opdracht3_Click"/>
            </div>
            <div id="ButtonRow2">
            <asp:Button ID="Opdracht6" runat="server" Text="Opdracht 6" CSSclass="Button" OnClick="Opdracht6_Click"/>
            <asp:Button ID="Opdracht7" runat="server" Text="Opdracht 7" CSSclass="Button" OnClick="Opdracht7_Click"/>
            <asp:Button ID="Opdracht8" runat="server" Text="Opdracht 8" CSSclass="Button" OnClick="Opdracht8_Click"/>
            </div>
            <div id="ButtonRow3">
            <asp:Button ID="Opdracht4" runat="server" Text="Opdracht 4" CSSclass="Button" OnClick="Opdracht4_Click"/>
            <asp:Button ID="Opdracht5" runat="server" Text="Opdracht 5" CSSclass="Button" OnClick="Opdracht5_Click"/>
            <asp:Button ID="Adminbutton" runat="server" Text="Resultaten" CSSclass="Button" OnClick="Adminbutton_Click"/>
            </div>

            <div id="Tekst">
                <asp:Label ID="Label1" runat="server" Text="Hier komt het verhaal te staan over deze site :)"></asp:Label>
            </div>
    
</asp:Content>

