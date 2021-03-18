<?php
    session_start();
    include('connection/connect.php');
    if(!empty($_SESSION['email'] )){
    
   
 
      mysqli_close($con_db);
    session_destroy();
    header("location:login.php");
    
    }
        else
        
    {
    }
?>