<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AdminView.aspx.cs" Inherits="ToetsendRekenen.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <link href="Stylesheets/inhoud.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <asp:Button ID="logout" runat="server" Text="Uitloggen" />
    <br /><br />
    <div id="testhestbest">
       
    <div id="Dropdownlistsmargin">
        <asp:Label Font-Size="X-Large" Text="Statistieken" runat="server"></asp:Label><br /><br />
    <asp:Label ID="Label2" runat="server" Text ="Jaar:"></asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
        <asp:DropDownList ID="DropDownList1" runat="server" Width="100px">
    </asp:DropDownList>&nbsp&nbsp&nbsp&nbsp
        <asp:Button ID="Button3" runat="server" Text="Bekijk gegevens" Width="109px" />
        <br /><br />
        <asp:Label ID="Label3" runat="server" Text ="Maand:"></asp:Label>&nbsp&nbsp
    <asp:DropDownList ID="DropDownList2" runat="server" Width="100px" CSSclass="test">
    </asp:DropDownList>&nbsp&nbsp&nbsp&nbsp
        <asp:Button ID="Button2" runat="server" Text="Bekijk gegevens" Width="109px" />
        <br /><br />
        <asp:Label ID="Label4" runat="server" Text ="Week:"></asp:Label>&nbsp&nbsp&nbsp&nbsp  
    <asp:TextBox ID="tbweek" runat="server" Width="95px" CSSclass="test" ></asp:TextBox>&nbsp&nbsp&nbsp&nbsp
        <asp:Button ID="Button1" runat="server" Text="Bekijk gegevens" Width="109px" />
        <br /><br />
           
        </div>
     <div id="changepass">
         <asp:Label ID="Editpasslabel" runat="server" Text ="Wachtwoord wijzigen" Font-Size="X-Large"></asp:Label><br /><br />
        <asp:Label ID="lbloldpass" runat="server" Text ="Oud wachtwoord:"></asp:Label>
       &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
    <asp:TextBox ID="tblogin" runat="server"></asp:TextBox>
        <br /> <br />
        <asp:Label ID="lblnewpass" runat="server" Text ="Nieuw wachtwoord:"></asp:Label>
        &nbsp&nbsp&nbsp&nbsp
    <asp:TextBox ID="tbpass" runat="server"></asp:TextBox>
        <br />    <br />  
        <asp:Label ID="Label1" runat="server" Text ="Wachtwoord herhalen:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br /> <br />
        <asp:Button runat="server" ID="Change" Text="Verander" />
        </div>
        </div>
    <div id="buttonmargin">
 
        </div>
    <br /><br />
    <div id="datagridviewmargin">
    <asp:GridView ID="datagrid" runat="server" Height="302px" Width="478px" AutoGenerateColumns="False" DataKeyNames="projectId" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="beginDatum" HeaderText="beginDatum" SortExpression="beginDatum" />
            <asp:BoundField DataField="eindDatum" HeaderText="eindDatum" SortExpression="eindDatum" />
            <asp:BoundField DataField="projectId" HeaderText="projectId" InsertVisible="False" ReadOnly="True" SortExpression="projectId" />
            <asp:BoundField DataField="projectNaam" HeaderText="projectNaam" SortExpression="projectNaam" />
            <asp:BoundField DataField="projectOmschrijving" HeaderText="projectOmschrijving" SortExpression="projectOmschrijving" />
        </Columns>
    </asp:GridView>
        </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UrenregistratieConnectionString %>" SelectCommand="SELECT [beginDatum], [eindDatum], [projectId], [projectNaam], [projectOmschrijving] FROM [Projecten]"></asp:SqlDataSource>
    
 
    </asp:Content>
