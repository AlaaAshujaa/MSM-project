<?php include("inc/header.php"); ?>
<?php 
//$notify=$_GET['notification_id'];
//$stmt=$con->prepare("UPDATE `schedualer` SET `seen`=1 WHERE `task_id`='" . $notify . "' ");
//$stmt->execute();
?>
<div class="container">
        <div class="row">
              <div class="col-md-2"><img src="images/CBA-Logo-Converted.png"             style="width:120px;height:90px;"></div>
              <div class="col-md-5  ">
            <ol class="breadcrumb">
  <li><a href="login.php">Sign Up</a></li>
  <li><a href="Result%20of%20final%20exam%20and%20assignment.php">Result of final exam and assignment</a></li>
</ol>
            </div>
            
            </div> 
        </div>
<?php
$do='';
$do=isset($_GET['do'])?$_GET['do']:'login';
if($do=='result'){
    
$userid=isset($_GET['userid'])&& is_numeric($_GET['userid'])?intval($_GET['userid']):0;
    $stmt=$con->prepare("SELECT * FROM student WHERE ID=? LIMIT 1");
    $stmt->execute(array($userid));
    $row=$stmt->fetch();    
    $count=$stmt->rowCount();
        if($stmt->rowCount()>0) { 


?>
<?php

$userid=isset($_GET['userid'])&& is_numeric($_GET['userid'])?intval($_GET['userid']):0;
$stmt=$con->prepare("SELECT * FROM grade,add_courses WHERE grade.course_code=add_courses.course_code AND grade.grade_code=?");
$stmt->execute(array($userid));
 // $stmt->execute();          
$rows=$stmt->fetchAll();                                 
 $count=$stmt->rowCount();
        if($stmt->rowCount()>0) {
?>
<!-- start Result of final exam and assignment-->
<div class="container">
<div class="row">
<div class="row">
  <div class="col-xs-6 col-md-4"></div>
  <div class="col-xs-6 col-md-4">
      <label for="exampleInputName2">Name of student:&nbsp;</label>
      <label for="exampleInputName2">
      <?php echo $row['first_name'].' '.$row['middle_name'].' '.$row['family_name']?>
      </label>
     
  <div class="col-xs-6 col-md-4"></div>
</div>
</div>
    
    <div class="row">
  <div class="col-xs-6 col-md-4"></div>
  <div class="col-xs-6 col-md-4">
      <label for="exampleInputName2">ID No.:&nbsp;</label>
      <label for="exampleInputName2">
      <?php echo $row['student_id']?>
      </label>
     
  <div class="col-xs-6 col-md-4"></div>
</div>
</div>
   <hr> 
    <div class="row">
    <div class="col-xs-12 col-md-12 text-center">
        <br>
        <h4 class="text-center">EXECUTIVE MASTER OF BUSINESS ADMINISTRATION</h4>
        <div class="table-responsive">
        <table class="table table-bordered table-striped">
              <tr>
              <td>Course </td>    
              <td>Assignment&#40;40&#37;&#41;</td>
              <td >Exam&#40;60&#37;&#41;</td>
              
              <td>Total Grade&#40;100&#37;&#41;</td>
              <td>Year</td>
              
            </tr>
            <?php 
            foreach($rows as $row){
                echo "<tr>";
                 echo "<td>".$row['name']."</td>";
                 echo "<td>".$row['Assignment']."</td>";
                 echo "<td>".$row['final_Exam']."</td>";
                 echo "<td>".$row['Total_grade']."</td>";
                 echo "<td>".date("Y")."</td>";
                 echo "</tr>";
                 }
            ?>
            <tr>
              <td> </td>    
              <td></td>
              <td ></td>
              
              <td></td>
              <td></td>
              
            </tr>
      </table>
            </div>
        </div>
    </div>
    </div>
</div>
<?php 
}else{
            
            echo "<div class='alert alert-success text-center'><h4 class='text-center'>There aren't Result of final exam and assignment</h4></div>";
        }
        }}

?>
<?php include("inc/footer.php"); ?>