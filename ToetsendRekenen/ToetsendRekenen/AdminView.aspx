<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AdminView.aspx.cs" Inherits="ToetsendRekenen.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <link href="Stylesheets/inhoud.css" rel="stylesheet" />
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
    <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       
    <br /><br />

    <div id="testhestbest">
       
    <div id="Dropdownlistsmargin">
        <asp:Label Font-Size="X-Large" Text="Statistieken" runat="server"></asp:Label><br /><br />
    <asp:Label ID="Label2" runat="server" Text ="Jaar:"></asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
        <asp:DropDownList ID="DropDownList1" runat="server" Width="120px">
    </asp:DropDownList>&nbsp&nbsp&nbsp&nbsp
        <asp:Button ID="Button3" runat="server" Text="Bekijk gegevens" Width="109px" />
        <br /><br />
        <asp:Label ID="Label3" runat="server" Text ="Maand:"></asp:Label>&nbsp&nbsp
    <asp:DropDownList ID="ddlMaand" runat="server" Width="120px" CSSclass="test" AppendDataBoundItems="true" >
            <asp:ListItem>Januari</asp:ListItem>
            <asp:ListItem>Februari</asp:ListItem>
            <asp:ListItem>Maart</asp:ListItem>
            <asp:ListItem>April</asp:ListItem>
            <asp:ListItem>Mei</asp:ListItem>
            <asp:ListItem>Juni</asp:ListItem>
            <asp:ListItem>Juli</asp:ListItem>
            <asp:ListItem>Augustus</asp:ListItem>
            <asp:ListItem>September</asp:ListItem>
            <asp:ListItem>Oktober</asp:ListItem>
            <asp:ListItem>November</asp:ListItem>
            <asp:ListItem>December</asp:ListItem>
    </asp:DropDownList>&nbsp&nbsp&nbsp&nbsp
        <asp:Button ID="Button2" runat="server" Text="Bekijk gegevens" Width="109px" OnClick="Button2_Click" />
        <br /><br />
        <asp:Label ID="Label4" runat="server" Text ="Week:"></asp:Label>&nbsp&nbsp&nbsp&nbsp  
    <asp:TextBox ID="tbweek" runat="server" Width="120px" CSSclass="test" ></asp:TextBox>&nbsp&nbsp&nbsp&nbsp
        <asp:Button ID="Button1" runat="server" Text="Bekijk gegevens" Width="109px" />
        <br /><br />
           <asp:Label ID="Label5" runat="server" Text ="Van:"></asp:Label>
    <input type="text" id="TextBox2" class="test" style="width:95px" name="textbox2" />
        <asp:Label ID="Label6" runat="server" Text ="tot:"></asp:Label>
    <input type="text" id="TextBox3" class="test" style="width:95px" name="textbox3" />
        <asp:Button ID="Button4" runat="server" Text="Bekijk gegevens" Width="109px" OnClick="Button4_Click" />
        <br /><br />
        </div>

     <div id="changepass">
         <asp:Label ID="Editpasslabel" runat="server" Text ="Wachtwoord wijzigen" Font-Size="X-Large"></asp:Label><br /><br />
        <asp:Label ID="lbloldpass" runat="server" Text ="Oud wachtwoord:"></asp:Label>
       &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
    <asp:TextBox ID="tbOudWachtwoord" runat="server" TextMode="Password"></asp:TextBox>
        <br /> <br />
        <asp:Label ID="lblnewpass" runat="server" Text ="Nieuw wachtwoord:"></asp:Label>
        &nbsp&nbsp&nbsp&nbsp
    <asp:TextBox ID="tbNieuwWachtwoord" runat="server" TextMode="Password"></asp:TextBox>
        <br />    <br />  
        <asp:Label ID="Label1" runat="server" Text ="Wachtwoord herhalen:"></asp:Label>
    <asp:TextBox ID="tbNieuwWachtwoord2" runat="server" TextMode="Password"></asp:TextBox>
        <br /> <br />
        <asp:Button runat="server" ID="btnWijzig" Text="Verander" OnClick="btnWijzig_Click" Width="109px"/>
         <asp:Button ID="logout" runat="server" Text="Uitloggen" OnClick="logout_Click" CSSClass="btnUitloggen" Width="109px"/>
          <asp:Label ID="lblError" runat="server" Text="" CssClass="lblErrorAdmin"></asp:Label>
        </div>

       

        </div>

    <div id="buttonmargin">
 
        </div>
    <br /><br />
    <div id="datagridviewmargin">
        <asp:GridView ID="DataGrid" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        </div>
    <script>
        $(function () {
            $("#TextBox2").datepicker({
                changeMonth: true,
                changeYear: true,
                yearRange: "-3:+3",
                dateFormat: "dd-mm-yy"
            })
        });
        $(function () {
            $("#TextBox3").datepicker({
                changeMonth: true,
                changeYear: true,
                yearRange: "-3:+3",
                dateFormat: "dd-mm-yy"
            })
        });
    </script>
    
 
    </asp:Content>

