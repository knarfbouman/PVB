<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Opdracht1.aspx.cs" Inherits="ToetsendRekenen.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="headerradiobutton" runat="server" Font-Size="25" BorderStyle="None" Text="Sommen"></asp:TextBox>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="119px" Width="98px">
        <asp:ListItem>Plus</asp:ListItem>
        <asp:ListItem>Min</asp:ListItem>
        <asp:ListItem>Keer</asp:ListItem>
        <asp:ListItem>Deel</asp:ListItem>
        <asp:ListItem>Gemixed</asp:ListItem>
    </asp:RadioButtonList>
    
</asp:Content>
