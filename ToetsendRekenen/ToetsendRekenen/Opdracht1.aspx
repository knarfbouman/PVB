<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Opdracht1.aspx.cs" Inherits="ToetsendRekenen.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
    <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
      <link href="Stylesheets/inhoud.css" rel="stylesheet" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="headeropdracht">
<asp:Label ID="opdrachtlbl" runat="server" Font-Size="25" Text="Opdracht#" ></asp:Label>
    
     
   
    
  <br /><br />
    <br />
  



<asp:RadioButtonList ID="SubCategorie" runat="server" Height="119px"  Font-Size="X-Large" OnSelectedIndexChanged="SubCategorie_SelectedIndexChanged1">
        <asp:ListItem>optie 1</asp:ListItem>
        <asp:ListItem>optie 2</asp:ListItem>
        <asp:ListItem>optie 3</asp:ListItem>
        <asp:ListItem>optie 4</asp:ListItem>
        <asp:ListItem>optie 5</asp:ListItem>
    </asp:RadioButtonList>
 </div>
     
    <br /><br />
       <label for="amount">Getallenbereik: </label>
 <input type="text" id="amount" style="border: 0; color: #f6931f; font-weight: bold;" readonly="true" />

    <div id="slider-range">
    </div>
  
    <br />
    <asp:RadioButtonList ID="RadioButtonList1" Font-Size="X-Large" runat="server">
         <asp:ListItem>Makkelijk</asp:ListItem>
         <asp:ListItem>Normaal</asp:ListItem>
         <asp:ListItem>Moeilijk</asp:ListItem>
     </asp:RadioButtonList>
  <br />
     <br />
    <input type="hidden" name="labeltest"  id="labeltest" value ="0"  ></input>
    <input type="hidden" name="getal2"  id="getal2" value ="100000"  ></input>
    <asp:Button ID="Button1" runat="server" Text="Start" Width="130px" OnClick="Button1_Click" />
  
    <br />
<script>
    $(function () {
        
        var valMap = [0, 10, 100, 1000, 10000, 100000];
        $("#slider-range").slider({
            range: true,
            min: 0,
            max: valMap.length - 1,
            values: [0, 100],
            slide: function (event, ui) {
                var pizza = valMap[ui.values[0]];
                var getal2 = valMap[ui.values[1]];
                $("#labeltest").val(pizza);
                    $("#getal2").val(getal2);
                $("#amount").val(valMap[ui.values[0]] + " - " + valMap[ui.values[1]]);

            }
        });
        $("#amount").val(valMap[$("#slider-range").slider("values", 0)] +
        " - " + valMap[$("#slider-range").slider("values", 1)]);
        
    });

</script>
    

    </asp:Content>
