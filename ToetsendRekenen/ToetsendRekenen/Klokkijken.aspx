<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Klokkijken.aspx.cs" Inherits="ToetsendRekenen.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Stylesheets/inhoud.css" rel="stylesheet" />
    <link href="Stylesheets/Klok.css" rel="stylesheet" />
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
    <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>
        $(function () {
            function setRotation(obj, rotation) {
                obj.css({
                    "-webkit-transform": "rotate(" + rotation + "deg)",
                    "-moz-transform": "rotate(" + rotation + "deg)",
                    "-o-transform": "rotate(" + rotation + "deg)",
                    "-ms-transform": "rotate(" + rotation + "deg)",
                    "transform": "rotate(" + rotation + "deg)"
                });
            }

            function getRandomRotation() {
                return Math.floor((Math.random() * 360) + 1);
            }

            $('.clock').click(function () {
                setRotation($('.little.hand'), getRandomRotation());
                setRotation($('.big.hand'), getRandomRotation());
            });
        });
    </script>

    <div class="clock">
    <div class="little hand"></div>
    <div class="big hand"></div>

    </div>
</asp:Content>
