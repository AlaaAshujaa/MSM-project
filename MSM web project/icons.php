<?php include("inc/header.php"); ?>
<div class="container">
         <div class="row">
              <div class="col-md-2"><img src="images/CBA-Logo-Converted.png"             style="width:120px;height:90px;"></div>
            </div>
        </div>
<!-- Start Section Icons-->
<?php 
 $id=$_SESSION['ID'];
?>
<h1 class="text-center">Center Of Business Administration </h1>
<section class="icons text-center">
<div class="container">
    <div class="row">
        <div class="col-lg-2"></div>
     <div class="col-lg-4">
      <div class="feat red">
         <li class="fa fa-book fa-5x hvr-float shadow"></li>
          <h3>Course Retake Request</h3>
 <a href="CourseRetakeRequest.php?do=courseRetake&userid=<?php echo $id?>"><li class="fa fa-angle-double-right fa-2x"></li><li class="fa fa-angle-double-right fa-2x"></li></a>          
  </div>   
     </div>
        <div class="col-lg-5">
      <div class="feat blue">
        <li class="fa fa-calendar fa-5x hvr-float shadow"></li>
          <h3>Exam-Assignment Deferment Request</h3>
 <a href="Exam-Assignment%20Deferment%20Request.php?do=DefermentRequest&userid=<?php echo $id?>"><li class="fa fa-angle-double-right fa-2x"></li><li class="fa fa-angle-double-right fa-2x"></li></a>          
         </div>   
     </div>
    </div>
    <br>
     <div class="row">
        <div class="col-lg-2"></div>
     <div class="col-lg-4">
      <div class="feat purbel">
         <li class="fa fa-address-card fa-5x hvr-float shadow"></li>
          <h3>Filing Grievance-CBA</h3>
 <a href="Filing%20Grievance.php?do=cba&userid=<?php echo $id?>"><li class="fa fa-angle-double-right fa-2x"></li><li class="fa fa-angle-double-right fa-2x"></li></a>          
         </div>   
     </div>
        <div class="col-lg-4">
      <div class="feat yellow">
         <li class="fa fa-map fa-5x hvr-float shadow"></li>
          <h3>Grade Obejection Form-MSM</h3>
 <a href="Grade%20Obejection%20Form.php?do=msm&userid=<?php echo $id?>"><li class="fa fa-angle-double-right fa-2x"></li><li class="fa fa-angle-double-right fa-2x"></li></a>          
         </div>   
     </div>
    </div>
    <br>
     <div class="row">
        <div class="col-lg-2"></div>
     <div class="col-lg-4">
      <div class="feat green">
<li class="fa fa-plus fa-5x hvr-float shadow"></li>&nbsp;<li class="fa fa-asterisk fa-5x hvr-float shadow"></li>&nbsp;<li class="fa fa-minus fa-5x hvr-float shadow"></li>
          <h3>Result of Final Exam and Assignment</h3>
 <a href="Result%20of%20final%20exam%20and%20assignment.php?do=result&userid=<?php echo $id?>"><li class="fa fa-angle-double-right fa-2x"></li><li class="fa fa-angle-double-right fa-2x"></li></a>          
         </div>   
     </div>
       
    </div>
    
    </div>
</section>

<?php include("inc/footer.php"); ?>