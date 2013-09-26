<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AdminView.aspx.cs" Inherits="ToetsendRekenen.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <link href="Stylesheets/inhoud.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList2" runat="server">
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList3" runat="server">
    </asp:DropDownList>
    <asp:GridView ID="datagrid" runat="server" Height="302px" Width="478px">
    </asp:GridView>
    <div id="changepass">
        <asp:Label ID="lbloldpass" runat="server" Text ="Oud wachtwoord:"></asp:Label>
       &nbsp&nbsp
    <asp:TextBox ID="tblogin" runat="server"></asp:TextBox>
        <asp:Label ID="lblnewpass" runat="server" Text ="Nieuw wachtwoord:"></asp:Label>
    <asp:TextBox ID="tbpass" runat="server"></asp:TextBox>
        <br />
        <asp:Button runat="server" ID="Change" Text="Verander" />
        </div>
    <asp:Button ID="logout" runat="server" Text="Uitloggen" />
    </asp:Content>
