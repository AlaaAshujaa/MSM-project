<?php include("inc/header.php"); ?>

<div class="container">
        <div class="row">
              <div class="col-md-2"><img src="images/CBA-Logo-Converted.png"             style="width:120px;height:90px;"></div>
              <div class="col-md-5  ">
            <ol class="breadcrumb">
  <li><a href="Home.php">Home</a></li>
  <li><a href="student_enrolling5.php.php">Student Enrolling 5</a></li>
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
    
@$proficiency_oral=$_POST['proficiency_oral'];
@$proficiency_written=$_POST['proficiency_written'];
@$proficiency_english_lang=$_POST['proficiency_english_lang'];
@$proficiency_lang_yes_date=$_POST['proficiency_lang_yes_date'];
@$proficiency_lang_yes_score=$_POST['proficiency_lang_yes_score'];
@$proficiency_lang_other=$_POST['proficiency_lang_other'];
@$proficiency_result=$_POST['proficiency_result'];
@$profes_obj_learning=$_POST['profes_obj_learning'];
@$profes_obj_expectation=$_POST['profes_obj_expectation'];
@$profes_obj_AC=$_POST['profes_obj_AC']; 


    if(empty($proficiency_oral) || empty($proficiency_written) ||  empty($proficiency_lang_other) || empty($proficiency_result) || empty($profes_obj_learning) || empty($profes_obj_expectation) || empty($profes_obj_AC)){
        
    echo " <h4 style=\"color: red;\" align=\"center\" class='alert alert-danger'><i class='fa fa-thumbs-down'></i><br>please complete the fields</h4> "; 
    }else{
   $stmt=$con->prepare("UPDATE student SET proficiency_oral=?,proficiency_written=?,proficiency_english_lang=?,proficiency_lang_yes_date=?,proficiency_lang_yes_score=?,proficiency_lang_other=?,proficiency_result=?,profes_obj_learning=?,profes_obj_expectation=?,profes_obj_AC=? WHERE ID=(SELECT MAX(ID)FROM (SELECT * FROM student) AS student2)"); 
$stmt->execute(array($proficiency_oral,$proficiency_written,$proficiency_english_lang,$proficiency_lang_yes_date,$proficiency_lang_yes_score,$proficiency_lang_other,$proficiency_result,$profes_obj_learning,$profes_obj_expectation,$profes_obj_AC));
    
     header("location:student_enrolling6.php?execute=done");
}
}
?>

<!--start student enrolling5 -->
<section class="Student1">
    <div class="fields">
<div class="container">
<div class="row">
    <div class="col-md-12">
        <p class="text-right">Executive MBA - Application Form</p>
        <div class="container">
     <form role="form" action="<?php $_SERVER['PHP_SELF'] ?>" method="post">
            <div class="row">
                    <div class="col-md-6">
                 <h4>8- Proficiency in English</h4>
	 <p >Indicate your relative degree of knowledge in each of the areas listed below: </p>
                 </div>
                    </div> 
<div class="row">
 <div class="col-md-3 col-sm-12"></div>
  <div class="col-md-3 col-sm-12">
    <label for="exampleInputName2">Basic</label>
  </div>
  <div class="col-md-3 col-sm-12">
    <label for="exampleInputName2">Good</label>
  </div>
   <div class="col-md-3 col-sm-12">
    <label for="exampleInputName2">Excellent</label>
  </div>
                    
 
</div>           

              
                <div class="row">
  <div class="col-md-3 col-sm-12">
    <label for="exampleInputName2">Oral</label>
  </div>
  <div class="col-md-3">
   <label class="radio-inline">
  <input type="radio" name="proficiency_oral" id="inlineRadio1" value="Basic"> 
</label> </div>
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="proficiency_oral" id="inlineRadio1" value="Good"> 
</label>  
  </div>
   <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="proficiency_oral" id="inlineRadio1" value="Excellent"> 
</label>   
  </div>                 
 
</div>
                <div class="row">
				<div class="col-md-3 col-sm-12">
    <label for="exampleInputName2">Written</label>
  </div>
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="proficiency_written" id="inlineRadio1" value="Basic"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="proficiency_written" id="inlineRadio1" value="Good"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="proficiency_written" id="inlineRadio1" value="Excellent"> 
</label>   
  </div> 
</div>

<div class="row">
            <div class="col-md-12"><br></div>
            </div>
   <div class="row">
				<div class="col-md-3">
    <label for="exampleInputName2">English Language test taken</label>
  </div>
  <div class="col-md-3">
   <label class="radio-inline">
  <input type="radio" name="proficiency_english_lang" id="inlineRadio2" value="TOEFL"> TOEFL
</label>  
      <label class="radio-inline">
  <input type="radio" name="proficiency_english_lang" id="inlineRadio2" value="IELTS"> IELTS
</label>  
  </div> 
  <div class="col-md-3">
  </div> 
</div>
  <div class="row">
  <div class="col-md-3">
    <label for="exampleInputName2">if yes, date taken</label><input type="date" class="form-control" placeholder="" name="proficiency_lang_yes_date">
  </div>
   <div class="col-md-3">
    <label for="exampleInputName2">Score</label><input type="text" class="form-control" placeholder="" name="proficiency_lang_yes_score">
  </div>
  </div>
  <br>
   <div class="row">
  <div class="col-md-4">
    <label for="exampleInputName2">Other English Language test taken</label><input type="text" class="form-control" placeholder="" name="proficiency_lang_other">
  </div>
   <div class="col-md-4">
    <label for="exampleInputName2">Result</label><input type="number" class="form-control" placeholder="" name="proficiency_result">
  </div>
  </div>
   <h4>9- Professional Objectives for your study</h4>
 <div class="row">
  <div class="col-md-4">
    <label for="exampleInputName2">What your professional / learning objectives?</label><textarea class="form-control" rows="4" name="profes_obj_learning"></textarea>
  </div>
  </div>
  <br>
  <div class="row">
     <div class="col-md-4">
    <label for="exampleInputName2">List your most important expectations regarding this study?</label><textarea class="form-control" rows="4" name="profes_obj_expectation"></textarea>
  </div>
  </div>
  <br>
  <div class="row">
   <div class="col-md-4">
    <label for="exampleInputName2">What other information would you like to add, that would aid the Admission Committee?</label><textarea class="form-control" rows="4" name="profes_obj_AC"></textarea>
  </div>
  </div>
  <br>
      <div class="row">
                <div class="col-md-4"></div>
    <div class="col-md-4">
          <a href=""><button class="btn btn-primary" type="submit" name="submit">Next</button></a>
          </div>
                
                </div> 
                <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-8 col-sm-12"> <nav aria-label="Page navigation">
  <ul class="pagination">
     <li>
      <a href="#" aria-label="Previous">
        <span aria-hidden="true">&laquo;</span>
      </a>
    </li>

    <li ><a href="student_enrolling.php">Form Page1</a></li>
    <li><a href="student_enrolling2.php">Form Page2</a></li>
    <li><a href="student_enrolling3.php">Form Page3</a></li>
    <li><a href="student_enrolling4.php">Form Page4</a></li>
    <li class="active"><a href="student_enrolling5.php">Form Page5</a></li>
     <li class="disabled"><a href="">Form Page6</a></li> 
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
</section>


<?php include("inc/footer.php"); ?>