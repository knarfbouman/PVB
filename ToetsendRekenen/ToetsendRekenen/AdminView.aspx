<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AdminView.aspx.cs" Inherits="ToetsendRekenen.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList2" runat="server">
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList3" runat="server">
    </asp:DropDownList>
    <asp:GridView ID="GridView1" runat="server" Height="302px" Width="478px">
    </asp:GridView>
    <asp:Button ID="Button1" runat="server" Text="Uitloggen" />
</asp:Content>
