<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Opdracht1.aspx.cs" Inherits="ToetsendRekenen.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
    <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>

    <link href="Jquery/inhoud.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="headeropdracht" >
<asp:Label ID="opdrachtlbl" runat="server" Font-Size="25" Text="Opdracht#" ></asp:Label>
    
     </div>
   
    
  <br /><br />
<p>
   
    
      <asp:RadioButtonList ID="SubCategorie" runat="server" Height="119px" Width="100%" style="margin-left: 0px; top: 154px; left: 277px; margin-top: 0px;" Font-Size="X-Large">
        <asp:ListItem>test</asp:ListItem>
        <asp:ListItem>test</asp:ListItem>
        <asp:ListItem>test</asp:ListItem>
        <asp:ListItem>test</asp:ListItem>
        <asp:ListItem>test</asp:ListItem>
    </asp:RadioButtonList>
<label for="amount">Getallenbereik: </label>
<input type="text" id="amount" style="border: 0; color: #f6931f; font-weight: bold;" readonly="true" /></p>
        
    <div id="slider-range">
    </div>
    <br />
    <p>
    <asp:RadioButtonList ID="MoeilijkheidsGraad" runat="server" Width="818px" RepeatDirection="Horizontal" Font-Size="X-Large" Height="52px">
        <asp:ListItem>Makkelijk</asp:ListItem>
        <asp:ListItem>Normaal</asp:ListItem>
        <asp:ListItem>Moeilijk</asp:ListItem>
    </asp:RadioButtonList>
        
    &nbsp;</p>
  
    <br /><br />
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
  
    </asp:Content>
