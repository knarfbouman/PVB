<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="ToetsendRekenen.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div id="Login">
    <div id="Username">
    <asp:Label ID="Label1" runat="server" Text="Username" CssClass="lblUsername"></asp:Label>
    <asp:TextBox ID="tbUsername" runat="server" CssClass="tbUsernameClass"></asp:TextBox>
    </div>
    <div id="Password">
    <asp:Label ID="Label2" runat="server" Text="Password" CssClass="lblPassword"></asp:Label>
    <asp:TextBox ID="tbPassword" runat="server" CssClass="tbPasswordClass"></asp:TextBox>
    </div>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </div>
    
</asp:Content>
