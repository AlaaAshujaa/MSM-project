<?php include("inc/header.php"); ?>
<div class="container">
        <div class="row">
              <div class="col-md-2"><img src="images/CBA-Logo-Converted.png"             style="width:120px;height:90px;"></div>
              <div class="col-md-5  ">
            <ol class="breadcrumb">
  <li><a href="Home.php">Home</a></li>
  <li><a href="student_enrolling2.php">Student Enrolling 2</a></li>
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

     @$HighesT=$_POST['Highest'];
     @$HighestOther=$_POST['Highestother'];
     @$ListAcademic=$_POST['Listacademic'];
     @$EducationalInstitute=$_POST['Educationalinstitute'];
     @$EducationalStartDate=$_POST['EducationalStartdate'];
     @$EducationalfinishDate=$_POST['Educationalfinishdate'];
     @$Educationaldegree=$_POST['EducationalDegree'];
     @$Educationalmajor=$_POST['EducationalMajor'];
     @$EducationalInstitute2=$_POST['Educationalinstitute2'];
     @$EducationalStartDate2=$_POST['EducationalStartdate2'];
     @$EducationalfinishDate2=$_POST['Educationalfinishdate2'];
     @$Educationaldegree2=$_POST['EducationalDegree2'];
     @$Educationalmajor2=$_POST['EducationalMajor2'];
     @$EducationalInstitute3=$_POST['Educationalinstitute3'];
     @$EducationalStartDate3=$_POST['EducationalStartdate3'];
     @$EducationalfinishDate3=$_POST['Educationalfinishdate3'];
     @$Educationaldegree3=$_POST['EducationalDegree3'];
     @$Educationalmajor3=$_POST['EducationalMajor3'];
   
       /*if(empty($HighesT) || empty($ListAcademic) || empty($EducationalInstitute) || empty($EducationalStartDate) || empty($EducationalfinishDate) || empty($Educationaldegree) || empty($Educationalmajor)){
           
         echo " <h4 style=\"color: red;\" align=\"center\" class='alert alert-danger'><i class='fa fa-thumbs-down'></i><br>please complete the fields</h4> "; 
       }else{*/
           
$stmt=$con->prepare("UPDATE student SET educational_highest=?, educational_highest_other=?,educational_list_academic=?,educational_institute1=?,educational_start_date1=?,educational_finish_date1=?,educational_degree1=?,educational_majer1=?,educational_institute2=?,educational_start_date2=?,educational_finish_date2=?,educational_degree2=?,educational_majer2=?,educational_institute3=?,educational_start_date3=?,educational_finish_date3=?,educational_degree3=?,educational_majer3=? WHERE 
ID=(SELECT MAX(ID)FROM (SELECT * FROM student) AS student2)");    
$stmt->execute(array($HighesT,$HighestOther,$ListAcademic,$EducationalInstitute,$EducationalStartDate,$EducationalfinishDate,$Educationaldegree,$Educationalmajor,$EducationalInstitute2,$EducationalStartDate2,$EducationalfinishDate2,$Educationaldegree2,$Educationalmajor2,$EducationalInstitute3,$EducationalStartDate3,$EducationalfinishDate3,$Educationaldegree3,$Educationalmajor3)); 
           
            header("location:student_enrolling3.php?execute=done");
       }

?>
<!-- start student_enrolling2-->
<section class="Student1">
<div class="fields">
<div class="container">
<div class="row">
   <p class="text-right">Executive MBA - Application Form</p> 
    <h4>4- Educational background</h4>
    <label>Highest qualification</label>
     <form role="form" action="<?php $_SERVER['PHP_SELF'] ?>" method="post">
    <div class="radio">
  <label>
    <input type="radio" name="Highest" id="optionsRadios2" value=" Master degree" class="noo">
   Master degree
  </label>
</div>
    <div class="radio">
  <label>
    <input type="radio" name="Highest" id="optionsRadios2" value="Bachelor degree" class="noo">
    Bachelor degree
       
  </label>
</div>
    <div class="col-md-6">
        <input type="radio" name="Highest" id="optionsRadios4" value="Other" >
    <label for="exampleInputName2">Other:</label><textarea id="reason" class="form-control" rows="3" name="Highestother" disabled></textarea>
  </div>
      <div class="row">
          
          <div class="col-md-12">
           <label>List any academic distictions,honors or scholarships received</label>
              <textarea class="form-control" rows="3" name="Listacademic"></textarea>
              <h4>History (list most important programs attended - up to three-with most recent first)</h4>
              
          </div>
          <div class="col-md-6"></div>
    </div>  
    <label for="exampleInputName2">1-Educational institute/University</label>
         <input type="text" class="form-control" placeholder="" name="Educationalinstitute">
    <div class="row">
    <div class="col-md-4">
        <label for="exampleInputName2">Start date</label><input type="date" class="form-control" placeholder="" name="EducationalStartdate">
        </div>
        <div class="col-md-4">
        <label for="exampleInputName2">finish date</label><input type="date" class="form-control" placeholder="" name="Educationalfinishdate">
        </div>
    
    </div>
  <br>
        <div class="row">  
            <div class="col-md-6">
                <label>Degree/diploma:</label>
    <div class="radio-inline">
  <label>
    <input type="radio" name="EducationalDegree" id="optionsRadios4" value="Yes, degree">
   Yes, degree
  </label>
</div>
        <div class="radio-inline">
  <label>
    <input type="radio" name="EducationalDegree" id="optionsRadios4" value=" Yes, diploma">
   Yes, diploma
  </label>
</div>
        <div class="radio-inline">
  <label>
    <input type="radio" name="EducationalDegree" id="optionsRadios2" value="No">
  No
  </label>
</div>
            </div>
            
        </div>
    <div class="row">
    <div class="col-md-4"><label for="exampleInputName2">Major</label><input type="text" class="form-control" placeholder="" name="EducationalMajor3" id="nodiploma"></div>   
    </div>
      <br>   
    <div class="row">
         <label for="exampleInputName2">2-Educational institute/University(Optional)</label><input type="text" class="form-control" placeholder="" name="Educationalinstitute2">
    <div class="row">
    <div class="col-md-4">
        <label for="exampleInputName2">Start date</label><input type="date" class="form-control" placeholder="" name="EducationalStartdate2">
        </div>
        <div class="col-md-4">
        <label for="exampleInputName2">finish date</label><input type="date" class="form-control" placeholder="" name="Educationalfinishdate2">
        </div>
    
    </div>
  <br>
        <div class="row">
            
            <div class="col-md-6">
                <label>Degree/diploma:</label>
    <div class="radio-inline">
  <label>
 <input type="radio" name="EducationalDegree2" id="optionsRadios1" value="Yes, degree">
   Yes, degree
  </label>
</div>
        <div class="radio-inline">
  <label>
 <input type="radio" name="EducationalDegree2" id="optionsRadios1" value="Yes, diploma">
   Yes, diploma
  </label>
</div>
        <div class="radio-inline">
  <label>
 <input type="radio" name="EducationalDegree2" id="optionsRadios1" value="No">
  No
  </label>
</div>
            </div>
           
        </div>
    <div class="row">
    <div class="col-md-4"><label for="exampleInputName2">Major</label><input type="text" class="form-control" placeholder="" name="EducationalMajor3"></div>
        
    </div>
    </div>
    <br>
    <div class="row">
         <label for="exampleInputName2">3-Educational institute/University(Optional)</label><input type="text" class="form-control" placeholder="" name="Educationalinstitute3">
    <div class="row">
    <div class="col-md-4">
        <label for="exampleInputName2">Start date</label><input type="date" class="form-control" placeholder="" name="EducationalStartdate3">
        </div>
        <div class="col-md-4">
        <label for="exampleInputName2">finish date</label><input type="date" class="form-control" placeholder="" name="Educationalfinishdate3">
        </div>
    
    </div>
 <br>
        <div class="row">
            
            <div class="col-md-6">
                <label>Degree/diploma:</label>
    <div class="radio-inline">
  <label>
 <input type="radio" name="EducationalDegree3" id="optionsRadios1" value="Yes, degree">
   Yes, degree
  </label>
</div>
        <div class="radio-inline">
  <label>
 <input type="radio" name="EducationalDegree3" id="optionsRadios1" value="Yes, diploma">
   Yes, diploma
  </label>
</div>
        <div class="radio-inline">
  <label>
<input type="radio" name="EducationalDegree3" id="optionsRadios1" value="No">    
  No
  </label>
</div>
            </div>
           
        </div>         
    </div>
    </div>
    <div class="row">
    <div class="col-md-4"><label for="exampleInputName2">Major</label><input type="text" class="form-control" placeholder="" name="EducationalMajor3"></div>
        
    </div>
    </div>
     <div class="row">
        <div class="col-md-7"></div>
       <div class="col-md-4">
     <a href="">
        <button class="btn btn-primary" type="submit" name="submit">Next</button></a></div>  
    </div><br>
     <div class="row">
              <div class="col-md-3"></div>
                <div class="col-md-8"> <nav aria-label="Page navigation">
  <ul class="pagination">
     <li>
      <a href="#" aria-label="Previous">
        <span aria-hidden="true">&laquo;</span>
      </a>
    </li>

    <li ><a href="student_enrolling.php">Form Page1</a></li>
    <li class="active"><a href="student_enrolling2.php">Form Page2</a></li>
    <li class="disabled"><a href="student_enrolling3.php">Form Page3</a></li>
    <li class="disabled"><a href="student_enrolling4.php">Form Page4</a></li>
    <li class="disabled"><a href="student_enrolling5.php">Form Page5</a></li>
    <li class="disabled"><a href="#">Form Page6</a></li>  
    <li>
      <a href="#" aria-label="Next">
        <span aria-hidden="true">&raquo;</span>
      </a>

    </li>
  </ul>
</nav></div>
    </form>
 </div>
    </div>
    </div>
</section>

<?php include("inc/footer.php"); ?>