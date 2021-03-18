<?php include("inc/header.php"); ?>
<?php 
/*
$do='';
$do=isset($_GET['do'])?$_GET['do']:'login';
if($do=='cba'){

$userid=isset($_GET['userid'])&& is_numeric($_GET['userid'])?intval($_GET['userid']):0;
       
$stmt=$con->prepare("SELECT * FROM student WHERE student_id=?");
    $stmt->execute(array($userid));
    $row=$stmt->fetch();    
    $count=$stmt->rowCount();
        if($stmt->rowCount()>0) {     
*/

   ?>
<?php


		
 if(isset($_POST['submit'])){

@$name =$_POST ['name'];
@$id =$_POST ['id'];
@$intake =$_POST ['intake'];
@$what_Grieved =$_POST ['what_Grieved'];
@$date_Occurrence =$_POST ['date_Occurrence'];
@$Explanation_Grievance =$_POST ['Explanation_Grievance'];
@$reason_Grievance=$_POST ['reason_Grievance'];
@$Date_filing=$_POST['Date_filing'];

if($name =='' ||$id =='' || $intake =='' || $what_Grieved =='' || $date_Occurrence == '' || $Explanation_Grievance =='' || $reason_Grievance ==''  || $Date_filing =='' )
	{
 echo " <h4 style=\"color: red;\" align=\"center\" class='alert alert-danger'><i class='fa fa-thumbs-down'></i><br>please complete the fields</h4> "; 	
	}
	else
	{
$stmt=$con->prepare("INSERT INTO grievance_cba(Unqiue_num,student_name,Intake_code,what_BeingGrieved,date_occurrence,explanation_grieved,reason_grieved,date_filing)
 VALUES ('$id','$name','$intake','$what_Grieved','$date_Occurrence','$Explanation_Grievance','$reason_Grievance','$Date_filing')");
  
$stmt->execute(array($id,$name,$intake,$what_Grieved,$date_Occurrence,$Explanation_Grievance,$reason_Grievance,$Date_filing));
     
echo "<h4 style=\"color: green;\" align=\"center\" class='alert alert-success'>
<i class='fa fa-thumbs-up'></i><br>Insert data done successfully</h4> ";
        
              $to="info@su-cba.com";
     $subject="My subject"; 
    $txt=$_POST['name']." is request filling Grievance";
      $headers="From:webmaster@example.com"."\r\n".
          "CC:somebodyelse@example.com";
      
      mail($to,$subject,$txt,$headers);

}	
}
?>
<div class="container">
        <div class="row">
              <div class="col-md-2"><img src="images/CBA-Logo-Converted.png"             style="width:120px;height:90px;"></div>
              <div class="col-md-5  ">
            <ol class="breadcrumb">
   <li><a href="login.php">Sign Up</a></li>
  <li><a href="Filing%20Grievance.php">Filing Grievance</a></li>
</ol>
            </div>
           
            </div> 
        </div>

<?php
$do='';
$do=isset($_GET['do'])?$_GET['do']:'login';
if($do=='cba'){
    
$userid=isset($_GET['userid'])&& is_numeric($_GET['userid'])?intval($_GET['userid']):0;
    $stmt=$con->prepare("SELECT * FROM student WHERE ID=? LIMIT 1");
    $stmt->execute(array($userid));
    $row=$stmt->fetch();    
    $count=$stmt->rowCount();
        if($stmt->rowCount()>0) { 


?>
<!-- start student_enrolling2-->
<section class="FilingGrievance">
<div class="fields">
<div class="container">
<div class="row">
    <div class="col-md-12">
    <h4 class="text-right">Filing Grievance</h4>
    </div>
  <form   action="<?php $_SERVER['PHP_SELF'] ?>" method="post">
          
      <div class="row">
	   
          <div class="col-md-6">
		   <label for="exampleInputName2">Name of Grievant</label><input id="name" type="text" class="form-control" placeholder="" name="name" value="<?php echo $row['first_name'].' '.$row['middle_name'].' '.$row['family_name']?>">
          
          </div>

    </div>
	 <br>
	<div class="row">
	 
 <div class="col-md-6">
        <input type="hidden" name="userid" value="<?php echo $userid?>"/>  
		  <label for="exampleInputName2"> ID No.</label><input id="id" type="text" class="form-control" placeholder="" name="id" value="<?php echo $row['student_id']?>">
 </div>
 </div>
  <br>
 <div class="row">
  
 <div class="col-md-6">
		  <label for="exampleInputName2"> Intake</label><input type="text" id="intake" class="form-control" placeholder="" name="intake">

		 </div>
		 </div>
  <br>
  <div class="row">
   
    <div class="col-md-6">
        <label for="exampleInputName2"> What is being Grieved?</label><textarea id="what_Grieved"  class="form-control" rows="4" name="what_Grieved"></textarea>
 </div>
        
    
    </div>
    <br>
        <div class="row">
            
            <div class="col-md-4">
                 <label for="exampleInputName2">Date of Occurrence:</label><input id="date_Occurrence" type="date" class="form-control" placeholder="" name="date_Occurrence">
            </div>
        </div>
		 <br>
		 <div class="row">
             
            <div class="col-md-4">
                 <label for="exampleInputName2">Detialed Explanation of the Grievance? </label><textarea id="Explanation_Grievance"class="form-control" rows="4" name="Explanation_Grievance"></textarea>
            </div>
        </div>
		 <br>
             <div class="row">
             
            <div class="col-md-4">
                 <label for="exampleInputName2">Reason for the Grievance? </label><textarea id="reason_Grievance"class="form-control" rows="4" name="reason_Grievance"></textarea>
            </div>
			  </div>
			 <br>
			 <div class="row">
             
            <div class="">
                
              
                 </div>
        </div>
		 <br>
		 <div class="row">
             
            <div class="col-md-4">
                 <label for="exampleInputName2">Date of filing (Grievance procedures must be complete and filed within five working days after occurrence:) </label><input type="date" class="form-control" placeholder="" id="Date_filing" name="Date_filing">
            </div>
			  </div>
    
    </div>
    </div>
	
    <div class="row">
    <div class="col-md-5"></div>
        <div class="col-md-4">
		<input type="submit" value ="Submit" class="btn btn-primary ">
		 <input type="hidden" id="send" name="submit" value="send" onclick="message()" />
		 </div>
    </div><br>
     <div class="row">
    <div class="col-md-5"></div>
        <div class="col-md-4">
		<input type="reset" value ="Cancel" class="btn btn-primary ">
		 </div>
    </div>
    </form>
	
    </div>
    </div>
</section>
<?php 
}
}?>
	

<?php include("inc/footer.php"); ?>

