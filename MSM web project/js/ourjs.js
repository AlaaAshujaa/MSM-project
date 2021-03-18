$(document).ready(function(){

$('#radio').click(function(){
        $('#text').attr("disabled", false);
    console.log("hi");
    });
    
    $('#noradio').click(function(){
        $('#text').attr("disabled", true);
    console.log("hi");
    });
    
                
});


