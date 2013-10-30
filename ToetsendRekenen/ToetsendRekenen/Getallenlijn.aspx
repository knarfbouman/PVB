<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Getallenlijn.aspx.cs" Inherits="ToetsendRekenen.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Stylesheets/inhoud.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;<br />
    <asp:Image ID="sterren" runat="server" />
    
    <br />
    
    <div id="getallenlijnimage">
        <asp:Image ID="getallenlijn" ImageUrl="~/Images/Goodguygetallenlijn.png" runat="server" />
    
    </div>
        <div id="getallen" >
            <div id="getal1">
    <asp:Label ID="Label2" runat="server" Text="100" Font-Size="24"></asp:Label>
      </div>
            <div id ="getal2">
   </div>
            <div id ="getal3">
        <asp:Label ID="Label5" runat="server" Text="50" Font-Size="24"></asp:Label>
                </div>
            <div id="getal4">
                </div>
            <div id="getal5">
        
            <asp:Label ID="Label1" runat="server" Text="0" Font-Size="24"></asp:Label>
    </div>
            <asp:Image ID="Pijl" runat="server" ImageUrl="~/Images/pijl.png" />
            
            </div>
    <br />
    <br />
    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            </asp:RadioButtonList>
    <asp:Button ID="nextbutton" runat="server" Text="Volgende" OnClick="nextbutton_Click" />
    <br />
    <asp:Label ID="lblvragen" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="lblgoed" runat="server" Text=""></asp:Label>
    <asp:Label ID="lblerror" runat="server" ForeColor="#CC0000"></asp:Label>
    </asp:Content>
