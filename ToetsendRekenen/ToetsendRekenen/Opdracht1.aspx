<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Opdracht1.aspx.cs" Inherits="ToetsendRekenen.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
    <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>

    <link href="Jquery/inhoud.css" rel="stylesheet" />
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
        var valMap = [0, 10, 100, 1000, 10000, 100000];
        $("#slider-range").slider({
            range: true,
            min: 0,
            max: valMap.length - 1,
            values: [0, 100],
            slide: function (event, ui) {
                $("#amount").val(valMap[ui.values[0]] + " - " + valMap[ui.values[1]]);
            }
        });
        $("#amount").val(valMap[$("#slider-range").slider("values", 0)] +
        " - " + valMap[$("#slider-range").slider("values", 1)]);
    });
</script>
<p>
<label for="amount">Getallenbereik: </label>
<input type="text" id="amount" style="border: 0; color: #f6931f; font-weight: bold;" />
</p>
<div id="slider-range"></div>   

</asp:Content>
