<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Opdracht1.aspx.cs" Inherits="ToetsendRekenen.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Jquery/jquery.ui.slider.css" rel="stylesheet" />
    <script src="Jquery/jquery.ui.slider.js"></script>
        <script src="Jquery/jquery.1.10.2.min.js"></script>
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

     <script>
         $(function () {
             $("#slider-range").slider({
                 range: true,
                 min: 0,
                 max: 100000,
                 values: [75, 300],
                 slide: function (event, ui) {
                     $("#amount").val("$" + ui.values[0] + " - $" + ui.values[1]);
                 }
             });
             $("#amount").val("$" + $("#slider-range").slider("values", 0) +
             " - $" + $("#slider-range").slider("values", 1));
         });
</script>
<p>
<label for="amount">Price range:</label>
<input type="text" id="amount" style="border: 0; color: #f6931f; font-weight: bold;" />
</p>
<div id="slider-range"></div>
    
</asp:Content>
