<?php include("inc/header.php");
include("auth.php");
?>
<head>
<script type="text/javascript" src="js/js.js"></script>
<script src="js/bootstrap.min.js" type="text/javascript"></script>
</head>
<div class="container">
        <div class="row">
              <div class="col-md-2"><img src="images/CBA-Logo-Converted.png"             style="width:120px;height:90px;"></div>
             
            
            </div> 
        </div>
		
		<?php 

//$dsn='mysql:host=localhost;dbname=MSM';
//$user='root';
//$pass='';
//$option= array(
//    PDO::MYSQL_ATTR_INIT_COMMAND =>'SET NAMES utf8',
//);
//
//
//try{
//    
//    $con=new PDO($dsn,$user,$pass,$option);
//    $con->setAttribute(PDO::ATTR_ERRMODE,PDO::ERRMODE_EXCEPTION);
//	
//}
//catch(PDOException $e){
//    
//    echo'failed' . $e->getMessage();
//}
//
//function getPosts(){
//	
//	$posts=array();
//	@$posts[0]=$_POST['Unique_num'];
//@$posts[1]=$_POST['student_name'];
//@$posts[2]=$_POST['Intake_code'];
//@$posts[3]=$_POST['course_name'];
//@$posts[4]=$_POST['assignment'];
//@$posts[5]=$_POST['final_exam'];
//@$posts[6]=$_POST['reason_request'];
//@$posts[7]=$_POST['other_reson'];
//@$posts[8]=$_POST['previously_exam'];
//@$posts[9]=$_POST['name_course'];
//@$posts[10]=$_POST['date'];
// 
//
//return $posts;
//}
//
//if(isset($_POST['insert']))
//{
//	$data=getPosts();
//	if(empty($data[0]) || empty($data[1]) || empty($data[2]) || empty($data[3])  ||  empty($data[6]) || empty($data[8]) )
//	{
//		
// echo " <h4 style=\"color: red;\" align=\"center\" class='alert alert-danger'><i class='fa fa-thumbs-down'></i><br>please complete the fields</h4> "; 
//	}else{
//		
//
//		$insertStmt =$con->prepare('insert into request_exam(Unique_num,student_name,Intake_code ,course_name ,assignment,final_exam,reason_request,other_reson,previously_exam,name_course,date)
//	values(:Unique_num,:student_name,:Intake_code,:course_name,:assignment,:final_exam,:reason_request,:other_reson,:previously_exam,:name_course,:date)');
//          $insertStmt ->execute(array(
//		  
//		       ':Unique_num' => $data[0],
//		       ':student_name'=>$data[1],
//		       ':Intake_code'=>$data[2],
//		       ':course_name'=>$data[3],
//			   ':assignment'=>$data[4],
//			   ':final_exam'=>$data[5],
//			   ':reason_request'=>$data[6],
//			    ':other_reson'=>$data[7],
//			   ':previously_exam'=>$data[8], 
//			   ':name_course'=>$data[9], 
//			   ':date'=>$data[10]
//			  
//		  
//		  ));
//		 if($insertStmt){
//echo "<h4 style=\"color: green;\" align=\"center\" class='alert alert-success'>
//<i class='fa fa-thumbs-up'></i><br>Insert data done successfully</h4> ";
//		  
//		 }
//		   	
//	}
//}
?>	
<?php
if($_SERVER['REQUEST_METHOD']=='POST'){
@$id=$_POST['userid'];
@$Unique_num=$_POST['Unique_num'];
@$student_name=$_POST['student_name'];
@$Intake_code=$_POST['Intake_code'];
@$course_name=$_POST['course_name'];
@$assignment=$_POST['assignment'];
@$final_exam=$_POST['final_exam'];
@$reason_request=$_POST['reason_request'];
@$other_reson=$_POST['other_reson'];
@$previously_exam=$_POST['previously_exam'];
@$name_course=$_POST['name_course'];
@$date=$_POST['date'];
    
    $stmt=$con->prepare("UPDATE request_exam SET Unique_num=?,student_name=?,Intake_code=?,course_name=?,assignment=?,final_exam=?,reason_request=?,other_reson=?,previously_exam=?,name_course=?,date=? WHERE code=?");
       $stmt->execute(array($Unique_num,$student_name,$Intake_code,$course_name,$assignment,$final_exam,$reason_request,$other_reson,$previously_exam,$name_course,$date,$id));
 echo "<div class='alert alert-success text-center'><h4>".$stmt->rowCount().
   " Record Updated Successfully</h4></div>";
    
}
$do='';
$do=isset($_GET['do'])?$_GET['do']:'login';
if($do=='updateDefermentRequest'){
    
$userid=isset($_GET['userid'])&& is_numeric($_GET['userid'])?intval($_GET['userid']):0;
    $stmt=$con->prepare("SELECT * FROM request_exam WHERE code=? LIMIT 1");
    $stmt->execute(array($userid));
    $row=$stmt->fetch();    
    $count=$stmt->rowCount();
        if($stmt->rowCount()>0) { 


?>
<!-- start Exam-Assignment Deferment Request-->
<section class="DefermentRequest">
<div class="fields">
<div class="container">
    <div class="row">
    <div class="col-md-12">
         <p class="text-right">Executive MBA - Application Form</p>
        <h4 class="text-center">CETNTER OF BUSINESS ADMINISTRATION(CBA)-SANA'A UNIVERSITY </h4>
        <h4 class="text-center">ADMISSION AND REGISTRATION OFFICE</h4>
        <p class="text-left">an exam/assignment may be deferred based on extenuating circumstances such as documented illness or severe personal difficulties.However,when a deferred exam/assignment privilege is granted,the subsequent exam/assignment must be completed  on the date set by CBA .If the privilege is not exercised by the date that  CBA grants ,this privilege will be revoked.</p>
        
        <p>Procedures&hellip;
            <a href="images/defrmentRequest.JPG" data-lightbox="gallery" data-title="Procedures">Read more</a> 
       </p> 
       <!-- <ol class="bg-primary">
            Procedures
            <li>CBA decides the date and time you will write the deferred exam/submit the deferred assignment and you are required to check the Re-sit Schedual and maintain contact with the administration to determine when and where you will have the deferred exam/assignment  </li>
            <li>A student who is compeiled to miss a final exam/assignment because of personal illness or death in the immedate family must apply no later than four working days after the date of the exam.</li>
            <li>Submission of this form does not gurantee automatic approval of this request.</li>
            <li>If you are intending to graduate and have deferred your exam/assignment ,your graduation will be delayed until the following intake .</li>
            <li>You will be notified of your application outcome via your email (Please ensure your correct email address is recorded at CBA and the email inbox is not full.)</li>
            <li>Applications must be submitted to the ADMISSION AND REGISTRATION OFFICE two working days prior to the missed exam date where advance notice permits. </li>
        </ol>-->
       <br>
	   
       <h4>Please complete and submitting this form to the Admission And Registration Office   </h4>
	   
	    <form role="form" action="<?php $_SERVER['PHP_SELF'] ?>" method="post">
            <input type="hidden" name="userid" value="<?php echo $userid?>"/>
        <div class="row">
  <div class="col-md-3">
    <label for="exampleInputName2"> Name:</label><input type="text"  name="student_name" class="form-control"  placeholder=""
value="<?php echo $row['student_name']?>">
  </div>
  <div class="col-md-3">
    <label for="exampleInputName2">ID Number:</label><input type="text"  name="Unique_num" class="form-control" placeholder="" value="<?php echo $row['Unique_num']?>">
  </div>
  <div class="col-md-3">
    <label for="exampleInputName2">Intake:</label><input type="text"  name="Intake_code" class="form-control" placeholder="" value="<?php echo $row['Intake_code']?>">
  </div>
       <div class="row">
           <div class="col-md-3">
                <label for="exampleInputName2">Course title:</label><input type="text"   name="course_name" class="form-control" placeholder="" value="<?php echo $row['course_name']?>">
                </div>  
           
            <div class="col-md-12">
           <label class="checkbox-inline e">
 <input type="checkbox" id="inlineCheckbox1"  name="final_exam" value="<?php echo $row['final_exam']?>" >Exam
        </label>
        <label class="checkbox-inline a">
          <input type="checkbox" id="inlineCheckbox2"   name="assignment" value="<?php echo $row['assignment']?>"> Assignment
        </label>
         </div>
          
            </div>
        </div>
        <h4>Please indicate the reason for your deferred exam/assignment request:</h4>
        <div class="radio">
  <label>
    <input type="radio"  id="optionsRadios1"  class="no"  name="reason_request" value="illness(medical documentation required including period of illness or disability,the nature of illness).">
    illness(medical documentation required including period of illness or disability,the nature of illness).
       

  </label>
</div>
<div class="radio">
  <label>
    <input type="radio" id="optionsRadios2"  name="reason_request" class="no" value="Traveling(visa/passport documentation required)" >
    Traveling(visa/passport documentation required)
      
  </label>
</div>
<div class="radio">
  <label>
    <input type="radio"  id="optionsRadios3" name="reason_request" class="no" value="bereavement&#42;" >
    bereavement&#42;
  </label>
    
</div>
        <div class="col-md-6">
        <input type="radio" id="optionsRadios4"  value="other (please specify)&#42;" name="reason_request" >
    <label for="exampleInputName2">other (please specify)&#42;:</label>
<input type="text"  name="other_reson" id="reason" class="form-control" placeholder="" value="<?php echo $row['other_reson']?>" disabled>
  </div>
      <div class="row">
        <div class="col-md-12">
            <p>&#42;consultation with an administrator is required to determine appropriate documentation and&#92;or approval.</p>
          </div>
        </div> 
       <div class="row">
        <div class="col-md-4">
            <h5>Have you deferred an exam/assignment previously?</h5>
       
           </div>
           <div class="col-md-2">
            <label class="radio-inline y">
  <input type="radio" name="previously_exam" id="inlineRadio1" value="yes"> yes
</label>
<label class="radio-inline n">
  <input type="radio" name="previously_exam" id="inlineRadio1" value="no"> no
</label>
               
           </div>
           
               <div class="col-md-3">
               <em>&#40;if yes ,please mention the course&#40;s&#41;&#41;</em>
               <input type="text" name=" name_course" class="form-control" id="courseName" placeholder="" value="<?php echo $row['name_course']?>" disabled>
               </div>
        </div>
         <span class="label label-primary">Participant Declaration</span> 
        <p>I declare that the information I have supplied is correct and complete and the documentary evidence supporting this application is authentic.I authorize the Center of Business Administration to obtain information with respect to my application and,if necessary,to verify the authenticity of the documentation I have provided.I undertake to not disclose or seek ,from any person,information on the contents of my examination.I have read nd understand the information on the Participant Manual and this application ,noting relevant details in regards to the Reexamination process.</p>
        <div class="row">
       
           
             <div class="col-md-3">
    <label for="exampleInputName2"> Date:</label><input type="date"  name="date" class="form-control" placeholder="" value="<?php echo $row['date']?>">
  </div>
        </div>
        
        
           
        </div>
    </div>
              
    </div>

     <div class="row">
                <div class="col-md-3"></div>
                <div class="col-md-3"></div>
    <div class="col-md-4"><button name="insert" class="btn btn-primary ">Submit</button></div>
                </div>
    
       <div class="row">
                <div class="col-md-3"></div>
                <div class="col-md-3"></div>
    <div class="col-md-4"><button name="" type="reset" class="btn btn-primary ">Cancel</button></div>
                </div>
</div>
</form>
</section>
 <?php
       }}
?>
      <div class="row">
         <div class="col-md-12">
           
            </div>
            </div>
<?php include("inc/footer.php");?> 