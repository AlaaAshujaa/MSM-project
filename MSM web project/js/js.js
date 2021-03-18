$(document).ready(function(){
    $("#optionsRadios4").click(function() {
        $("#reason").prop("disabled", false);
    });
    $("#optionsRadios4").click(function() {
        $("#nodiploma").prop("disabled", false);
    });

    $(".no").click(function() {
        $("#reason").prop("disabled", true);
    });

    $("#inlineRadio1").click(function() {
        $("#courseName").prop("disabled", false);
    });

    $("#inlineRadio2").click(function() {
        $("#courseName").prop("disabled", true);
    });
    
});