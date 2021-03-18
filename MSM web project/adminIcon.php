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
         <li class="fa fa-book fa-5x hvr-grow-rotate"></li>
          <h3>Course Retake Request</h3>
 <a href="tableCourseRetakeRequest.php"><li class="fa fa-angle-double-right fa-2x"></li><li class="fa fa-angle-double-right fa-2x"></li></a>          
  </div>   
     </div>
        <div class="col-lg-5">
      <div class="feat blue">
        <li class="fa fa-calendar fa-5x  hvr-grow-rotate"></li>
          <h3>Exam-Assignment Deferment Request</h3>
 <a href="tableExam-Assignment.php"><li class="fa fa-angle-double-right fa-2x"></li><li class="fa fa-angle-double-right fa-2x"></li></a>          
         </div>   
     </div>
    </div>
    <br>
     <div class="row">
        <div class="col-lg-2"></div>
     <div class="col-lg-4">
      <div class="feat purbel">
         <li class="fa fa-address-card fa-5x hvr-grow-rotate"></li>
          <h3>Filing Grievance-CBA</h3>
 <a href="tableFilingGrievance.php"><li class="fa fa-angle-double-right fa-2x"></li><li class="fa fa-angle-double-right fa-2x"></li></a>          
         </div>   
     </div>
        <div class="col-lg-4">
      <div class="feat yellow">
         <li class="fa fa-map fa-5x hvr-grow-rotate"></li>
          <h3>Grade Obejection Form-MSM</h3>
 <a href="tableGradeObejectionForm.php"><li class="fa fa-angle-double-right fa-2x"></li><li class="fa fa-angle-double-right fa-2x"></li></a>          
         </div>   
     </div>
    </div>
    <br>
     <div class="row">
        <div class="col-lg-2"></div>
    
          <div class="col-lg-4">
      <div class="feat black">
         <li class="fa fa-user fa-5x hvr-grow-rotate"></li>
          <h3>Add User</h3>
 <a href="addUser.php"><li class="fa fa-angle-double-right fa-2x"></li><li class="fa fa-angle-double-right fa-2x"></li></a>          
         </div>   
     </div>
          <div class="col-lg-4">
      <div class="feat white">
         <li class="fa fa-address-book fa-5x hvr-grow-rotate"></li>
          <h3>Student Enrolling</h3>
 <a href="tablestudent_enrolling.php"><li class="fa fa-angle-double-right fa-2x"></li><li class="fa fa-angle-double-right fa-2x"></li></a>          
         </div>   
     </div>
    </div>
    
    </div>
</section>

<?php include("inc/footer.php"); ?>