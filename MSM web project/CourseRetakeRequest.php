<?php include("inc/header.php");
include("auth.php");
?>
<div class="container">
        <div class="row">
              <div class="col-md-2"><img src="images/CBA-Logo-Converted.png"             style="width:120px;height:90px;"></div>
              <div class="col-md-5  ">
            <ol class="breadcrumb">
 <li><a href="login.php">Sign Up</a></li>
  <li><a href="CourseRetakeRequest.php">Course Retake Request</a></li>
</ol>
            </div>   
            </div> 
        </div>
 
	<?php   
$dsn='mysql:host=localhost;dbname=MSM';
$user='root';
$pass='';
$option= array(
    PDO::MYSQL_ATTR_INIT_COMMAND =>'SET NAMES utf8',
);


try{
    
    $con=new PDO($dsn,$user,$pass,$option);
    $con->setAttribute(PDO::ATTR_ERRMODE,PDO::ERRMODE_EXCEPTION);
	
}
catch(PDOException $e){
    
    echo'failed' . $e->getMessage();
}

function getPosts(){
	
	$posts=array();
	@$posts[0]=$_POST['Unique_num'];
@$posts[1]=$_POST['student_name'];
@$posts[2]=$_POST['Intake_code'];
@$posts[3]=$_POST['course_name'];
@$posts[4]=$_POST['segment_taken'];
@$posts[5]=$_POST['date'];
@$posts[6]=$_POST['originally_taken'];
@$posts[7]=$_POST['retake_intake'];
@$posts[8]=$_POST['Reason'];

return $posts;
}
if(isset($_POST['insert']))
{
	$data=getPosts();
	if(empty($data[0]) || empty($data[1]) || empty($data[2]) || empty($data[3]) || empty($data[4]) || empty($data[5]) ||  empty($data[6]) || empty($data[7]) || empty($data[8]) )
	{
    
       
 echo " <h4 style=\"color: red;\" align=\"center\" class='alert alert-danger'><i class='fa fa-thumbs-down'></i><br>please complete the fields</h4> "; 
	}else{
		
		$insertStmt =$con->prepare('insert into request_course(Unique_num,student_name,Intake_code,course_name,segment_taken,data,originally_taken,retake_intake,Reason)
	values(:Unique_num,:student_name,:Intake_code,:course_name,:segment_taken,:date,:originally_taken,:retake_intake,:Reason)');
          $insertStmt ->execute(array(
		  
		       ':Unique_num' => $data[0],
		       ':student_name'=>$data[1],
		       ':Intake_code'=>$data[2],
		       ':course_name'=>$data[3],
			   ':segment_taken'=>$data[4],
			   ':date'=>$data[5], 
			   ':originally_taken'=>$data[6], 
			   ':retake_intake'=>$data[7],
			   ':Reason'=>$data[8]
		  
		  ));
		 if($insertStmt){
         
echo "<h4 style=\"color: green;\" align=\"center\" class='alert alert-success'>
<i class='fa fa-thumbs-up'></i><br>Insert data done successfully</h4> ";
             
             $to="info@su-cba.com";
     $subject="My subject"; 
    $txt=$_POST['student_name']." is request retake course";
      $headers="From:webmaster@example.com"."\r\n".
          "CC:somebodyelse@example.com";
      
      mail($to,$subject,$txt,$headers);
		  
		 }
		   	
	}	
}
?>
<?php
$do='';
$do=isset($_GET['do'])?$_GET['do']:'login';
if($do=='courseRetake'){
    
$userid=isset($_GET['userid'])&& is_numeric($_GET['userid'])?intval($_GET['userid']):0;
    $stmt=$con->prepare("SELECT * FROM student WHERE ID=? LIMIT 1");
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
    <label for="exampleInputName2">Participant Name</label><input type="text" name="student_name" class="form-control" placeholder="" 
value="<?php echo $row['first_name'].' '.$row['middle_name'].' '.$row['family_name']?>">
  </div>
            <div class="col-md-3">
    <label for="exampleInputName2"> ID No.</label><input type="text" name="Unique_num" class="form-control" placeholder="" value="<?php echo $row['student_id']?>">
  </div>
            <div class="col-md-3">
    <label for="exampleInputName2"> Intake</label><input type="text" name="Intake_code" class="form-control" placeholder="">
  </div>
         <div class="col-md-3">
    <label for="exampleInputName2"> Course to be retaken</label><input name="course_name" type="text" class="form-control" placeholder="">
  </div>  
            <div class="col-md-3">
    <label for="exampleInputName2"> Segment take in</label><input  name="segment_taken"type="text" class="form-control" placeholder="">
  </div>
            <div class="col-md-3">
    <label for="exampleInputName2"> Date </label><input type="date" name="date" class="form-control" placeholder="">
  </div>
            <div class="col-md-3">
    <label for="exampleInputName2"> Date when originally taken</label><input  name="originally_taken" type="date" class="form-control" placeholder="">
  </div>
            <div class="col-md-3">
    <label for="exampleInputName2"> Retake Intake</label><input type="text" class="form-control" placeholder="" name="retake_intake">
	
  </div>
            <div class="col-md-6">
    <label for="exampleInputName2"> Absence Reason</label><textarea  name="Reason"class="form-control" rows="3"></textarea>
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
        
       <!-- <div class="row">
        <div class="col-md-4">
            <label for="exampleInputName2"> Participant Sigature</label>
            
            </div>
             <div class="col-md-4">
            <label for="exampleInputName2"> Date</label><input type="date" class="form-control" placeholder="">
            
            </div>
        </div>
        <div class="row">
        <div class="col-md-4">
            <label for="exampleInputName2"> Approved</label>
            
            </div>
             <div class="col-md-4">
            <label for="exampleInputName2"> Date</label><input type="date" class="form-control" placeholder="">
            
            </div>
        </div>-->
         <div class="row"><br>
                <div class="col-md-3"></div>
                <div class="col-md-3"></div>
                <div class="col-md-4">
                    <button class="btn btn-primary "name="insert">Submit</button></div>
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