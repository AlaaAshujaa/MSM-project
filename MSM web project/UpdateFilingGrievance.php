<?php include("inc/header.php"); ?>
<div class="container">
        <div class="row">
              <div class="col-md-2"><img src="images/CBA-Logo-Converted.png"             style="width:120px;height:90px;"></div>
             
           
            </div> 
        </div>

<?php
if($_SERVER['REQUEST_METHOD']=='POST'){
@$ID=$_POST['userid'];
@$name =$_POST ['name'];
@$id =$_POST ['id'];
@$intake =$_POST ['intake'];
@$what_Grieved =$_POST ['what_Grieved'];
@$date_Occurrence =$_POST ['date_Occurrence'];
@$Explanation_Grievance =$_POST ['Explanation_Grievance'];
@$reason_Grievance=$_POST ['reason_Grievance'];
@$Date_filing=$_POST['Date_filing'];
    
$stmt=$con->prepare("UPDATE grievance_cba SET Unqiue_num=?,student_name=?,Intake_code=?,what_BeingGrieved=?,date_occurrence=?,explanation_grieved=?,reason_grieved=?,date_filing=? WHERE ID=?");
 $stmt->execute(array($id,$name,$intake,$what_Grieved,$date_Occurrence,$Explanation_Grievance,$reason_Grievance,$Date_filing,$ID));
 echo "<div class='alert alert-success text-center'><h4>".$stmt->rowCount().
   " Record Updated Successfully</h4></div>";
}
?>


<?php
$do='';
$do=isset($_GET['do'])?$_GET['do']:'login';
if($do=='updatecba'){
    
$userid=isset($_GET['userid'])&& is_numeric($_GET['userid'])?intval($_GET['userid']):0;
    $stmt=$con->prepare("SELECT * FROM grievance_cba WHERE ID=? LIMIT 1");
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
  <form action="<?php $_SERVER['PHP_SELF'] ?>" method="post">
         <input type="hidden" name="userid" value="<?php echo $userid?>"/>   
      <div class="row">
	   
          <div class="col-md-6">
		   <label for="exampleInputName2">Name of Grievant</label><input id="name" type="text" class="form-control" placeholder="" name="name"  value="<?php echo $row['student_name']?>">
          
          </div>

    </div>
	 <br>
	<div class="row">
	 
 <div class="col-md-6">
        <input type="hidden" name="userid" value="<?php echo $userid?>"/>  
		  <label for="exampleInputName2"> ID No.</label><input id="id" type="text" class="form-control" placeholder="" name="id" value="<?php echo $row['Unqiue_num']?>" >
 </div>
 </div>
  <br>
 <div class="row">
  
 <div class="col-md-6">
		  <label for="exampleInputName2"> Intake</label><input type="text" id="intake" class="form-control" placeholder="" name="intake" value="<?php echo $row['Intake_code']?>">

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
                 <label for="exampleInputName2">Date of Occurrence:</label><input id="date_Occurrence" type="date" class="form-control" placeholder="" name="date_Occurrence" value="<?php echo $row['date_occurrence']?>">
            </div>
        </div>
		 <br>
		 <div class="row">
             
            <div class="col-md-4">
                 <label for="exampleInputName2">Detialed Explanation of the Grievance? </label><textarea id="Explanation_Grievance"class="form-control" rows="4" name="Explanation_Grievance" ></textarea>
            </div>
        </div>
		 <br>
             <div class="row">
             
            <div class="col-md-4">
                 <label for="exampleInputName2">Reason for the Grievance? </label><textarea id="reason_Grievance"class="form-control" rows="4" name="reason_Grievance" ></textarea>
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
                 <label for="exampleInputName2">Date of filing (Grievance procedures must be complete and filed within five working days after occurrence:) </label><input type="date" class="form-control" placeholder="" id="Date_filing" name="Date_filing" value="<?php echo $row['date_filing']?>">
            </div>
			  </div>
    
    </div>
    </div>
	
    <div class="row">
    <div class="col-md-5"></div>
        <div class="col-md-4">
            <button class="btn btn-primary "name="insert">Submit</button>
		 
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
}
?>
	

<?php include("inc/footer.php"); ?>

