<?php include("inc/header.php");
include("auth.php");
?>
<div class="container">
        <div class="row">
              <div class="col-md-2"><img src="images/CBA-Logo-Converted.png"             style="width:120px;height:90px;"></div>
                 
            </div> 
        </div>
 
	<?php   

?>
<?php
if($_SERVER['REQUEST_METHOD']=='POST'){
@$id=$_POST['userid'];
@$Unique_num=$_POST['Unique_num'];
@$student_name=$_POST['student_name'];
@$Intake_code=$_POST['Intake_code'];
@$course_name=$_POST['course_name'];
@$segment_taken=$_POST['segment_taken'];
@$date=$_POST['date'];
@$originally_taken=$_POST['originally_taken'];
@$retake_intake=$_POST['retake_intake'];
@$Reason=$_POST['Reason'];

 $stmt=$con->prepare("UPDATE request_course SET Unique_num=?,student_name=?,Intake_code=?,course_name=?,segment_taken=?,data=?,originally_taken=?,retake_intake=?,Reason=? WHERE code=?");
       $stmt->execute(array($Unique_num,$student_name,$Intake_code,$course_name,$segment_taken,$date,$originally_taken,$retake_intake,$Reason,$id));
 echo "<div class='alert alert-success text-center'><h4>".$stmt->rowCount().
   " Record Updated Successfully</h4></div>";
  }

$do='';
$do=isset($_GET['do'])?$_GET['do']:'login';
if($do=='updatecourseRetake'){
    
$userid=isset($_GET['userid'])&& is_numeric($_GET['userid'])?intval($_GET['userid']):0;
    $stmt=$con->prepare("SELECT * FROM request_course WHERE code=? LIMIT 1");
    $stmt->execute(array($userid));
    $row=$stmt->fetch();    
    $count=$stmt->rowCount();
        if($stmt->rowCount()>0) { 

?>
<!-- start CourseRetakeRequest-->
<section class="RetakeRequest">
    <div class="fields">
    <div class="container">
	 
    <div class="row">
        <div class="col-md-12">
          <p class="text-right">Executive MBA - Application Form</p>
        <h4 class="text-center">CETNTER OF BUSINESS ADMINISTRATION(CBA)-SANA'A UNIVERSITY </h4>
        <h4 class="text-center">ADMISSION AND REGISTRATION OFFICE</h4>
           
		   <form role="form" action="<?php $_SERVER['PHP_SELF'] ?>" method="post">
                <input type="hidden" name="userid" value="<?php echo $userid?>"/>  
            <div class="col-md-3">
    <label for="exampleInputName2">Participant Name</label><input type="text" name="student_name" class="form-control" placeholder="" value="<?php echo $row['student_name']?>">
  </div>
            <div class="col-md-3">
    <label for="exampleInputName2"> ID No.</label><input type="text" name="Unique_num" class="form-control" placeholder="" value="<?php echo $row['Unique_num']?>">
                
  </div>
            <div class="col-md-3">
    <label for="exampleInputName2"> Intake</label><input type="text" name="Intake_code" class="form-control" placeholder="" value="<?php echo $row['Intake_code']?>">
  </div>
         <div class="col-md-3">
    <label for="exampleInputName2"> Course to be retaken</label><input name="course_name" type="text" class="form-control" placeholder="" value="<?php echo $row['course_name']?>">
  </div>  
            <div class="col-md-3">
    <label for="exampleInputName2"> Segment take in</label><input  name="segment_taken"type="text" class="form-control" placeholder="" value="<?php echo $row['segment_taken']?>">
  </div>
            <div class="col-md-3">
    <label for="exampleInputName2"> Date </label><input type="date" name="date" class="form-control" placeholder="" value="<?php echo $row['data']?>">
  </div>
            <div class="col-md-3">
    <label for="exampleInputName2"> Date when originally taken</label><input  name="originally_taken" type="date" class="form-control" placeholder="" value="<?php echo $row['originally_taken']?>">
  </div>
            <div class="col-md-3">
    <label for="exampleInputName2"> Retake Intake</label><input type="text" class="form-control" placeholder="" name="retake_intake" value="<?php echo $row['retake_intake']?>">
	
  </div>
            <div class="col-md-6">
    <label for="exampleInputName2"> Absence Reason</label><textarea  name="Reason"class="form-control" rows="3" value="<?php echo $row['Reason']?>"></textarea>
  </div>
        </div>
        </div>
		
         <h3 class="text-center">Course Retake Policy</h3>
        <ul>
              <li>it is the responsibility of the participant to download ,complete and submit this form to the Admission And Registration Officer 48 hours before the retake course take placein order for the retake to replace the original grade .Even in the case of a course that was failed ,the new grade will not replace the old grade if this form is not on file with the Admission And Registration Officer.      </li>
              <li>Students may retake a class to attempt to improve their grade.Upon completion of the class, the Admission And Registration Officer's office records the awarded grade and computes the cumulative GPA using the most recent of the two grades.In doing so,participants forfeit any credit or grade they may have recieved n the previous class  </li>
            <li>The original grade will have an appropriate designation put next to it to indicate that the course was retaken.</li>
            <li>Course substitutions are not allowed;te original course must be replaced by a retake of the same course.</li>
            <li>Participants are responsible for any additional expenses incurred.</li>
            <li>This policy must be exercised prior to graduation in the then enrolled-in program.</li>
        </ul>
        
      
         <div class="row"><br>
                <div class="col-md-3"></div>
                <div class="col-md-3"></div>
                <div class="col-md-4">
                    <button class="btn btn-primary" name="insert">Submit</button></div>
                </div> 
         <div class="row"><br>
                <div class="col-md-3"></div>
                <div class="col-md-3"></div>
                <div class="col-md-4">
                    <button class="btn btn-primary "name="" type="reset">Cancel</button></div>
                </div> 
    </div>
    </div></form>
</section>
<?php
}
}
  
?>

<?php include("inc/footer.php");?> 