<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Klokkijken.aspx.cs" Inherits="ToetsendRekenen.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Stylesheets/inhoud.css" rel="stylesheet" />
    <link href="Stylesheets/Klok.css" rel="stylesheet" />
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
    <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        Hoe laat is het?
    </div>

    <script>
        $(function () {
            var kleineWijzer = 0;
            var groteWijzer = 0;
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
                var tijdStip = Math.random() * (60 * 24);
                var randomUurVanDeDag = Math.floor(tijdStip / 60);
                var randomMinuutVanDeDag = Math.floor(tijdStip / 2);
                var percentageKleineWijzer = Math.round((randomMinuutVanDeDag / 720) * 100);
                var uur = Math.floor(randomMinuutVanDeDag / 60);
                kleineWijzer = (360 / 100) * percentageKleineWijzer;       

                var tussenBerekening = Math.floor(randomMinuutVanDeDag / 60) * 60;       
                var minuten = randomMinuutVanDeDag - tussenBerekening;
                var percentageGroteWijzer = Math.round((minuten / 60) * 100);

                groteWijzer = (360 / 100) * percentageGroteWijzer;

                setRotation($('.little.hand'), kleineWijzer);
                setRotation($('.big.hand'), groteWijzer);
                $("#tijd").empty();
                $("#tijd").append("Het is " + uur + " uur en " + minuten + " minuten");
            });
        });
    </script>

    <div class="clock">
    <div class="little hand"></div>
    <div class="big hand"></div>

    </div>
    <div id="tijd">
    </div>
</asp:Content>
