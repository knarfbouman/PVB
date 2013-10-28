<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Klokkijken.aspx.cs" Inherits="ToetsendRekenen.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Stylesheets/inhoud.css" rel="stylesheet" />
    <link href="Stylesheets/Klok.css" rel="stylesheet" />
    <link href="Stylesheets/banaan.css" rel="stylesheet" />
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
    <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <input type="button" value="klik hier om te beginnen" id="beginButton"/>
    <div id="sterren">
    </div>
    <div id="vraagStellen">
    </div>

    <script>
        //Globale variabelen.
        var kleineWijzer = 0;
        var groteWijzer = 0;
        var tijdStip = 0;
        var randomUurVanDeDag = 0;
        var randomMinuutVanDeDag = 0;
        var percentageKleineWijzer = 0;
        var uur = 0;
        var tussenBerekening = 0;
        var minuten = 0;
        var percentageGroteWijzer = 0;
        var aantalGoed = 0;
        var voortgang = 1;

        //Variabelen voor de timer.
        var sTime = new Date().getTime();
        var countDown = 1500;

        

        $(function () {
            //randomize radiobuttons
            (function ($) {

                $.fn.randomize = function (childElem) {
                    return this.each(function () {
                        var $this = $(this);
                        var elems = $this.children(childElem);

                        elems.sort(function () { return (Math.round(Math.random()) - 0.5); });

                        $this.remove(childElem);

                        for (var i = 0; i < elems.length; i++)
                            $this.append(elems[i]);

                    });
                }
            })(jQuery);

            $("#zieAntwoord").attr("hidden", true);
            $("#volgende").attr("hidden", true);
            $("#divNaarResultaat").attr("hidden", true);

            $('#beginButton').click(function () {
                //Timer
                function UpdateTime() {
                    var cTime = new Date().getTime();
                    var diff = cTime - sTime;
                    var seconds = countDown - Math.floor(diff / 1000);
                    if (seconds >= 0) {
                        var minutes = Math.floor(seconds / 60);
                        seconds -= minutes * 60;
                        $("#minutes").text(minutes < 10 ? "0" + minutes : minutes);
                        $("#seconds").text(seconds < 10 ? "0" + seconds : seconds);
                    } else {
                        $("#countdown").hide();
                        $("#aftercount").show();
                        $("#radioAntwoord1").attr("disabled", true);
                        $("#radioAntwoord2").attr("disabled", true);
                        $("#radioAntwoord3").attr("disabled", true);
                        $("#radioAntwoord4").attr("disabled", true);
                        $("#divNaarResultaat").attr("hidden", false);
                        $("#volgende").attr("hidden", true);
                        $("#zieAntwoord").attr("hidden", true);
                        clearInterval(counter);
                    }
                }
                UpdateTime();
                var counter = setInterval(UpdateTime, 1000);

                wijzers();
                $("#zieAntwoord").attr("hidden", false);
                $("#vraagStellen").append("Hoe laat is het?");
                $("#voortgang").append("vraag " + voortgang + " van 50");
                $("#beginButton").hide();
                $("div.alleAntwoorden").randomize("div.eenAntwoord");
            });

            function setRotation(obj, rotation) {
                obj.css({
                    "-webkit-transform": "rotate(" + rotation + "deg)",
                    "-moz-transform": "rotate(" + rotation + "deg)",
                    "-o-transform": "rotate(" + rotation + "deg)",
                    "-ms-transform": "rotate(" + rotation + "deg)",
                    "transform": "rotate(" + rotation + "deg)"
                });
            };

            function getRandomRotationKleineWijzer() {
                tijdStip = Math.random() * (60 * 24);
                randomMinuutVanDeDag = Math.floor(tijdStip / 2);
                uur = Math.floor(randomMinuutVanDeDag / 60);
                return minuten;
            };

            function getRandomRotationGroteWijzer() {
                tijdStip = Math.random() * (60 * 24);
                randomMinuutVanDeDag = Math.floor(tijdStip / 2);
                uur = Math.floor(randomMinuutVanDeDag / 60);
                tussenBerekening = Math.floor(randomMinuutVanDeDag / 60) * 60;
                minuten = randomMinuutVanDeDag - tussenBerekening;
                return uur;
            };

            function wijzers () {
                tijdStip = Math.random() * (60 * 24);
                randomUurVanDeDag = Math.floor(tijdStip / 60);
                randomMinuutVanDeDag = Math.floor(tijdStip / 2);
                percentageKleineWijzer = Math.round((randomMinuutVanDeDag / 720) * 100);
                uur = Math.floor(randomMinuutVanDeDag / 60);
                kleineWijzer = (360 / 100) * percentageKleineWijzer;       

                tussenBerekening = Math.floor(randomMinuutVanDeDag / 60) * 60;       
                minuten = randomMinuutVanDeDag - tussenBerekening;
                percentageGroteWijzer = Math.round((minuten / 60) * 100);

                groteWijzer = (360 / 100) * percentageGroteWijzer;

                setRotation($('.little.hand'), kleineWijzer);
                setRotation($('.big.hand'), groteWijzer);
                $("#antwoord1").empty();
                $("#antwoord1").append("Het is " + uur + " uur en " + minuten + " minuten.");
                $("#antwoord2").empty();
                $("#antwoord2").append("Het is " + getRandomRotationGroteWijzer() + " uur en " + getRandomRotationKleineWijzer() + " minuten.");
                $("#antwoord3").empty();
                $("#antwoord3").append("Het is " + getRandomRotationGroteWijzer() + " uur en " + getRandomRotationKleineWijzer() + " minuten.");
                $("#antwoord4").empty();
                $("#antwoord4").append("Het is " + getRandomRotationGroteWijzer() + " uur en " + getRandomRotationKleineWijzer() + " minuten.");
            };


            $("#zieAntwoord").click(function () {
                //Divs en buttons properties veranderen.
                $("#radioAntwoord1").attr("disabled", true);
                $("#radioAntwoord2").attr("disabled", true);
                $("#radioAntwoord3").attr("disabled", true);
                $("#radioAntwoord4").attr("disabled", true);
                $("#volgende").attr("value", "Volgende");
                $("#volgende").attr("hidden", false);
                $("#zieAntwoord").attr("hidden", true);
                $("#uitleg").removeAttr("hidden");

                //If else kijkt of het antwoord goed is.
                if($("#radioAntwoord1").attr('checked', 'checked')){           
                    $("#goed").removeAttr("hidden");
                    aantalGoed = aantalGoed + 1;
                }
                else {
                    $("#fout").removeAttr("hidden");
                }

                //If else voor de aantal goed beantwoorde vragen.
                $("#aantalgoed").empty();
                if (aantalGoed == 1) {
                    $("#aantalgoed").append(aantalGoed + " vraag goed bantwoord");
                }

                else if (aantalGoed == 0 || aantalGoed > 1) {
                    $("#aantalgoed").append(aantalGoed + " vragen goed bantwoord");
                }

                //Image voor sterren erbij zetten.
                $('#sterren').empty();
                for (var i = 0; i < Math.floor(aantalGoed / 10) ; i++) {
                    var img = document.createElement("img");
                    img.src = "Images/ster.jpg";

                    $('#sterren').append(img);
                }

                //Button naar resultaat laten zien.
                if (voortgang == 50) {
                    $("#volgende").attr("hidden", true);
                    $("#divNaarResultaat").attr("hidden", false);
                    $("#inputaantalgoed").val(aantalGoed);
                }
            });
            $("#volgende").click(function () {
                //Divs en buttons properties veranderen.
                $("div.alleAntwoorden").randomize("div.eenAntwoord");
                $("#radioAntwoord1").attr("disabled", false);
                $("#radioAntwoord2").attr("disabled", false);
                $("#radioAntwoord3").attr("disabled", false);
                $("#radioAntwoord4").attr("disabled", false);
                $("#radioAntwoord1").attr("checked", false);
                $("#radioAntwoord2").attr("checked", false);
                $("#radioAntwoord3").attr("checked", false);
                $("#radioAntwoord4").attr("checked", false);
                $("#volgende").attr("hidden", true);
                $("#zieAntwoord").attr("hidden", false);
                $("#uitleg").empty();
                $("#fout").attr("hidden", true);
                $("#goed").attr("hidden", true);
                $("#antwoord").val('');
                $("#antwoord").focus();
                $("#voortgang").empty();
                voortgang = voortgang + 1;
                $("#voortgang").append("vraag " + voortgang + " van 50");
                wijzers();
            });
            
        });
    </script>

    <div class="clock">
    <div class="little hand"></div>
    <div class="big hand"></div>

    </div>
    <div id="tijd">
    </div>
    <div class="alleAntwoorden">
        <div class="eenAntwoord">
        <input id="radioAntwoord1" type="radio" name="group1"/> <label id="antwoord1"></label> <br />
        </div>
        <div class="eenAntwoord">
        <input id="radioAntwoord2" type="radio" name="group1"/> <label id="antwoord2"></label> <br />
        </div>
        <div class="eenAntwoord">
        <input id="radioAntwoord3" type="radio" name="group1"/> <label id="antwoord3"> </label><br />
        </div>
        <div class="eenAntwoord">
        <input id="radioAntwoord4" type="radio" name="group1"/> <label id="antwoord4"> </label><br />
        </div>
    </div>
    <div>
        <p id="fout" hidden="hidden">Je antwoord is fout.</p>
        <p id="goed" hidden="hidden">Je antwoord is goed!</p>
        <div id="uitleg">
        </div>
    </div>
    <input type="button" id="zieAntwoord" value="Zie antwoord" />
    <input type="button" id="volgende" value="Volgende" />
    <div id="divNaarResultaat">
        <asp:Button ID="naarResultaat" Text="Naar resultaat" runat="server"/>
    </div>
    <%-- Divs en inputs voor javascript variabelen --%>
    <div id="voortgang">
    </div>
    <div id="aantalgoed">
    </div>
    <input type="hidden" id="inputaantalgoed" name="inputaantalgoed"/>

    <div id="countdown">
    <div id="minutes" style="float:left">25</div>
    <div style="float:left">:</div>
    <div id="seconds" style="float:left">00</div>
    </div>
    <div id="aftercount" style="display:none">Tijd is voorbij</div>
</asp:Content>
