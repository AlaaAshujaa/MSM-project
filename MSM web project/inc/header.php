<?php 
include("connection/connect.php");
 session_start();


?>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">    
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no">  
 
<link rel="stylesheet" href="css/bootstrap.css"/>
<link rel="stylesheet" href="css/style.css"/>
<link rel="stylesheet" href="css/signature-pad.css"/>  
<link rel="stylesheet" href="css/hover.css"/>
<link rel="stylesheet" href="css/font-awesome.min.css"/>
<link href="css/lightbox.min.css" rel="stylesheet">   
    
   <title>CBA-Center of Business Administration</title>
    <script type="text/javascript">
    var _gaq = _gaq || [];
    _gaq.push(['_setAccount', 'UA-39365077-1']);
    _gaq.push(['_trackPageview']);

    (function() {
      var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
      ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
      var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
    })();
  </script>
    </head>
    <body onselectstart="return false">
        <!--start our navbar-->
        
        
        <nav class="navbar navbar-default">
  <div class="container-fluid">
    <!-- Brand and toggle get grouped for better mobile display -->
   <div class="navbar-header">
      <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
        <span class="sr-only">Toggle navigation</span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
      </button>

      <p class="navbar-brand BRAND" href="#">CBA</p>
    </div>

    <!-- Collect the nav links, forms, and other content for toggling -->
    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
     
       <ul class="nav navbar-nav text-center">
           
      <?php if(!isset($_SESSION['email'] ) && !isset($_SESSION['password'])) { ?>
        <li><a href="Home.php" >&nbsp; <h4><i class="glyphicon glyphicon-home"></i>&nbsp;Home </h4></a></li> 
        <li><a href="login.php" >&nbsp; <h4><i class="glyphicon glyphicon-log-in"></i> &nbsp;Sign Up </h4></a></li> 
       <li> <a href="admin.php" >&nbsp; <h4><i class="glyphicon glyphicon-user"></i>&nbsp;Admin Login </h4></a></li>
        </ul>
		   <?php } elseif (isset($_SESSION['email'] ) && isset($_SESSION['password']))  { ?>
            <ul class="nav navbar-nav ">
		    <!--<li class="active"><a href="Home.php">Home <span class="sr-only">(current)</span></a></li>-->
        <!--  <li><a href="student_enrolling.php?do=s1&userid=?>"> Students Enrolling</a></li>-->
                <li>
<a href="CourseRetakeRequest.php?do=courseRetake&userid=<?php echo $_SESSION['ID']?>">
    Course Retake Request</a></li>
        <li><a href="Exam-Assignment Deferment Request.php?do=DefermentRequest&userid=<?php echo $_SESSION['ID']?>">Exam/Assignment Deferment Request </a></li>
          
           <li class="dropdown">
          <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Plaint <span class="caret"></span></a>
          <ul class="dropdown-menu">
     <li><a href="Filing Grievance.php?do=cba&userid=<?php echo $_SESSION['ID']?>"  class="text-left">Filing Grievance&#40;local CBA&#41;</a></li>
            <li><a href="Grade Obejection Form.php?do=msm&userid=<?php echo $_SESSION['ID']?>" class="text-left">Grade Obejection Form&#40;MSM&#41;</a></li>
            
          </ul>
        </li>
     
         
		  
            <li class="dropdown">
          <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">
<?php    
 $EMAIL=$_SESSION['email'];
$GoodAdd=preg_match("^(.+)@(.+)\.(.+)^",$EMAIL,$EmailArray);
if($GoodAdd){
    
    echo(" <i class='fa fa-user'></i> Welcome $EmailArray[1]");
}                                                                                         
                                                                                         
?>
      
              <span class="caret"></span></a>
          <ul class="dropdown-menu">
<li><a href="ChangePassword.php?do=Edit&userid=<?php echo $_SESSION['ID']?>"  class="text-left">Change password</a></li>
            <li><a href="logout.php" class="text-left">Logout</a></li>
            
          </ul>
                </li>
         <li class="dropdown">
          
            
<!--
          <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Messages <span class="badge">
              </span></a>
-->
<!--
          <ul class="dropdown-menu">
     <li><a href="Result of final exam and assignment.php?do=result&userid= "class="text-left"></a></li>
          
            
          </ul>
-->
        </li>
                
      </ul>
        
  
  

     <?php  }    ?>
     
    </div><!-- /.navbar-collapse -->
  </div><!-- /.container-fluid -->
</nav>
   <!--End our navbar-->
      