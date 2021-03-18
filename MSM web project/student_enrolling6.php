<?php include("inc/header.php"); ?>

<div class="container">
        <div class="row">
              <div class="col-md-2"><img src="images/CBA-Logo-Converted.png"             style="width:120px;height:90px;"></div>
              <div class="col-md-5  ">
            <ol class="breadcrumb">
  <li><a href="Home.php">Home</a></li>
  <li><a href="student_enrolling6.php">Student Enrolling 6</a></li>
</ol>
            </div>
            
            </div> 
        </div>
<?php

if(isset($_GET['execute']) && $_GET['execute']=='done'){
    
  echo " <h4 style=\"color: green;\" align=\"center\" class='alert alert-success'><i class='fa fa-thumbs-up'></i><br>Insert data done successfully</h4> ";  
     
}
?>

<?php

if(isset($_POST['submit'])){
    
@$other_program=$_POST['other_program'];
@$other_about_program=$_POST['other_about_program'];   
@$other_about_PA=$_POST['other_about_PA'];   
@$other_about_other=$_POST['other_about_other'];   
@$Statement_date=$_POST['Statement_date'];  
    
 
    if(empty($other_program) || empty($other_about_program) || empty($Statement_date)){
         echo " <h4 style=\"color: red;\" align=\"center\" class='alert alert-danger'><i class='fa fa-thumbs-down'></i><br>please complete the fields</h4> "; 
    }
  else{  
      $stmt=$con->prepare("UPDATE student SET other_program=?,other_about_program=?,other_about_PA=?,other_about_other=?,
Statement_date=? WHERE ID=(SELECT MAX(ID)FROM (SELECT * FROM student) AS student2)");
$stmt->execute(array($other_program,$other_about_program,$other_about_PA,$other_about_other,$Statement_date));
     echo " <h4 style=\"color: green;\" align=\"center\" class='alert alert-success'>
  <i class='fa fa-thumbs-up'></i><br>Your data has been saved successfully<br>
  Please,pay the fees to the following account quickly:No.0009-231101-009</h4> "; 
      
     $to="info@su-cba.com";
     $subject="My subject"; 
    $txt="There are a student registered in program";
      $headers="From:webmaster@example.com"."\r\n".
          "CC:somebodyelse@example.com";
      
      mail($to,$subject,$txt,$headers);
      
}
}
?>

<!--start student enrolling6 -->
<section class="Student1">
    <div class="fields">
<div class="container">
<div class="row">
    <div class="col-md-12">
        <p class="text-right">Executive MBA - Application Form</p>
        <div class="container">
        <div class="row">
            <div class="col-md-12"> 
            <form role="form" action="<?php $_SERVER['PHP_SELF'] ?>" method="post">    
                <h4>10- Other</h4>
                <div class="row">
            
              <div class="row">
  <div class="col-md-6">
    <label for="exampleInputName2">Who recommended you to this program?</label><textarea class="form-control" rows="4" name="other_program"></textarea>
  </div>
  </div>
 <div class="row">
        <div class="col-md-4">
     <br>
     </div>            
        </div>
   <div class="row">
  <div class="col-md-3">
    <label for="exampleInputName2">Please indicate you about the program</label> </div>
  </div>
                <div class="row">
 
  <div class="col-md-3">
   <label class="radio-inline">
  <input type="radio" name="other_about_program" id="inlineRadio1" value="Relative">Relative 
</label> </div>
</div>
  <div class="row">
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="other_about_program" id="inlineRadio1" value="Internet"> Internet
</label>  
  </div>
  </div>
    <div class="row">
   <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="other_about_program" id="optionsRadios4" value="Publications / advertisement in:" > Publications / advertisement in:
</label>
       <input type="text" class="form-control" placeholder=""  name="other_about_PA" id="reason" disabled>
  </div>  
</div>  
 <div class="row">
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="other_about_program" id="inlineRadio" value="Fair /Exhibition"> Fair /Exhibition
</label>  
  </div>
  </div>
  
   <div class="row">
   <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="other_about_program" id="inlineRadio1" value="Other:"> Other:
</label>
    <input type="text" class="form-control" placeholder="" name="other_about_other" id="courseName"  >
  </div>  
</div>
</div>
   <div class="row">
                <div class="col-md-6">
                    <br><br>
                </div>
                </div>            
   <h4>11- Statement</h4>
 <p >I certify that the information given in this application from is complete and accurate to the best of my knowledge. I permit Sana'a University or its agents to use all means resonable to verify the information i have provided in this application. </p>  
 <div class="row"> 
  <div class="col-md-3">
   <h4> Date</h4> 
      <input type="date" class="form-control" placeholder="" name="Statement_date">
  </div> 
   <div class="col-md-3"></div> 
</div>
   <div class="row">
                <div class="col-md-6">
                   <br><br>
                </div>
                </div>

	<div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-4">
          <a href=""><button class="btn btn-primary" type="submit" name="submit">Save</button></a>
        </div>
                
                </div> 
                <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-8 col-sm-12"> <nav aria-label="Page navigation">
  <ul class="pagination">
     <li>
      <a href="student_enrolling.php" aria-label="Previous">
        <span aria-hidden="true">&laquo;</span>
      </a>
    </li>

    <li class=""><a href="student_enrolling.php">Form Page1</a></li>
    <li><a href="student_enrolling2.php">Form Page2</a></li>
    <li class=""><a href="student_enrolling3.php">Form Page3</a></li>
    <li class=""><a href="student_enrolling4.php">Form Page4</a></li>
    <li class=""><a href="student_enrolling5.php">Form Page5</a></li>
     <li class="active"><a href="student_enrolling6.php">Form Page6</a></li> 
    <li>
      <a href="#" aria-label="Next">
        <span aria-hidden="true">&raquo;</span>
        </a>
            </li>
          </ul>
        </nav></div>
                
                </div> 
                </form>                
 </div>
 </div>
</div> 
 </div>    
</div>
</div>
</div>
</section>
<?php include("inc/footer.php"); ?>