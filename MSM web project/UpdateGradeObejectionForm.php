<?php include("inc/header.php"); ?>

<div class="container">
        <div class="row">
              <div class="col-md-2"><img src="images/CBA-Logo-Converted.png"             style="width:120px;height:90px;">
            </div>
              <div class="col-md-4  ">
            <ol class="breadcrumb">
  <li><a href="login.php">Sign Up</a></li>
  <li><a href="Grade%20Obejection%20Form.php">Grade objection Form</a></li>
</ol>
            </div>
            </div> 
        </div>
<?php
if($_SERVER['REQUEST_METHOD']=='POST'){
 
@$id=$_POST['userid'];    
@$Uniquenum=$_POST['Uniquenum'];
@$Title=$_POST['Title'];
@$studentname=$_POST['studentname'];
@$programtype=$_POST['programtype'];
@$Intakecode=$_POST['Intakecode'];
@$Institutionname=$_POST['Institutionname'];
@$programlocation=$_POST['programlocation'];
@$Coursename=$_POST['Coursename'];
@$lecturername=$_POST['lecturername'];
@$AssignorExam=$_POST['AssignorExam'];
@$indorGrop=$_POST['indorGrop'];
@$graderesult=$_POST['graderesult'];
@$ProjectTitle=$_POST['ProjectTitle'];
@$Supervisor=$_POST['Supervisor'];
@$Evaluator=$_POST['Evaluator'];
@$Date=$_POST['Date'];
@$gradeproject=$_POST['gradeproject'];
@$BHAPtitle=$_POST['BHAPtitle'];
@$Coach=$_POST['Coach'];
@$EvaluatorBHAP=$_POST['EvaluatorBHAP'];
@$dateBHAP=$_POST['dateBHAP'];
@$Question=$_POST['Question'];
@$Objection=$_POST['Objection'];
@$Motivation=$_POST['Motivation'];
@$Declarationdate=$_POST['Declarationdate'];

$stmt=$con->prepare("UPDATE grievance_msm SET Unique_num=?,Title=?,student_name=?,	program_type=?,Intake_code=?,Institution_name=?,program_location=?,Course_name=?,lecturer_name=?,Assign_or_Exam=?,ind_or_Grop=?,grade_result=?,Project_Title=?,Supervisor=?,Evaluator=?,Date=?,grade_project=?,BHAP_title=?,Coach=?,Evaluator_BHAP=?,date_BHAP=?,Question=?,Objection=?,Motivation=?,Declaration_date=? WHERE code=?");
  
$stmt->execute(array($Uniquenum,$Title,$studentname,$programtype,$Intakecode,$Institutionname,$programlocation,$Coursename,$lecturername,$AssignorExam,$indorGrop,$graderesult,$ProjectTitle,$Supervisor,$Evaluator,$Date,$gradeproject,$BHAPtitle,$Coach,$EvaluatorBHAP,$dateBHAP,$Question,$Objection,$Motivation,$Declarationdate,$id));
     
echo "<div class='alert alert-success text-center'><h4>".$stmt->rowCount().
   " Record Updated Successfully</h4></div>";
    }

?>

<?php
$do='';
$do=isset($_GET['do'])?$_GET['do']:'login';
if($do=='updatemsm'){
    
$userid=isset($_GET['userid'])&& is_numeric($_GET['userid'])?intval($_GET['userid']):0;
    $stmt=$con->prepare("SELECT * FROM grievance_msm WHERE code=? LIMIT 1");
    $stmt->execute(array($userid));
    $row=$stmt->fetch();    
    $count=$stmt->rowCount();
        if($stmt->rowCount()>0) { 


?>
<!--start Grade objection form-->
<section class="GradeObjection">
    <div class="fields">
    <div class="contaier">
     <form role="form" action="<?php $_SERVER['PHP_SELF'] ?>" method="post">
          <input type="hidden" name="userid" value="<?php echo $userid?>"/>  
<div class="row">
    <div class="col-md-12">
    
<h3 class="text-center">Grade objection Form to Examination &#44;Assignments ad Master Theses or final Project grades</h3>
    </div>
   
    </div>   
     <div class="row">

         <div class="col-md-2"></div>
   <div class=" col-md-8 ">
       
        <p>A participant may object his or her assessment grade&#44;&hellip;
            <a href="images/gradeObjection.JPG" data-lightbox="gallery" data-title="Help">Read more</a> 
       </p> 
       <!--<p> A participant may object his or her assessment grade&#44;if there is sufficient justification to do so&#46;This means that the participant should give specific grounds related the grading&#46;In case of a written examination or written assignment&#44;the participant is advised to first review the examination or the assignment on appointment basis&#46;Next&#40;s&#41;he should discuss the work with the respective examiner&#46;The examiner will evaluate and inform the MSM Global Education Programs department or local Administrator&#46;</p>
       <p>In case the examiner is not available for the review and the participant has objections to the given grade&#44;the participant may fill out the"Grade objection Form"&#40;which will replace the review with the examiner&#41;&#46;The participant motivates clearly&#44;for each question on a seperate form&#44;why&#40;s&#41;he objects to the assessment&#46;Only motivated objection arguments are taken into considration&#46;The MSM Global Education Programs department or local Administrator further processes the grade objection form and the respective examiner will evaluate and answer the MSM Global Education Programs department or local Administrator&#44;so that the participant can receive the result within three&#40;3&#41;weeks from the review appointment.</p>
       <p>In case of Master Thesis or Final Project objections&#40;review not possible&#41;,the participant is advised to object the grade in writing to the MSM Exmination Board stating the reasons for disagreement.A "motivated" objection should be field no later than four(4) weeks after notification of the Master Thesis or Final Project grade.</p>-->
            
            </div>
    </div>
        <div class="row">
            <div class="col-md-2"></div>
            
            <div class="col-md-1"></div>
        <div class="col-md-6 bg-primary">
            <label for="exampleInputName2">Participant name:</label><input type="text" class="form-control" placeholder="" name="studentname" value="<?php echo $row['student_name']?>">
            
            <label for="exampleInputName2">Title:</label><label class="radio-inline">
  <input type="radio" name="Title" id="inlineRadio1" value="Mr"> Mr.
</label>
<label class="radio-inline">
  <input type="radio" name="Title" id="inlineRadio1" value="Ms"> Ms.
</label>
            <div class="row">
                <div class="col-md-6">
                <label for="exampleInputName2">Participant ID No.:</label><input type="text" class="form-control" placeholder="" name="Uniquenum" value="<?php echo $row['Unique_num']?>">
                </div>
            
            </div>
             
            
            
<label for="exampleInputName2">Type of program:</label><label class="radio-inline">
  <input type="radio" name="programtype" id="inlineRadio1" value="DBA"> DBA
</label>
<label class="radio-inline">
  <input type="radio" name="programtype" id="inlineRadio1" value="PhD"> PhD
</label>
            <label class="radio-inline">
  <input type="radio" name="programtype" id="inlineRadio1" value="MBA"> MBA
</label>
            <label class="radio-inline">
  <input type="radio" name="programtype" id="inlineRadio1" value="EMBA"> EMBA
</label>
            <label class="radio-inline">
  <input type="radio" name="programtype" id="inlineRadio1" value="IMBA"> IMBA
</label>
            <label class="radio-inline">
  <input type="radio" name="programtype" id="inlineRadio1" value="MM"> MM
</label>
            <label class="radio-inline">
  <input type="radio" name="programtype" id="inlineRadio1" value="MSc"> MSc
</label>
            <label class="radio-inline">
  <input type="radio" name="programtype" id="inlineRadio1" value="EP"> EP
</label><br>

            <label for="exampleInputName2">Intake(Group) No.:</label><input type="number" class="form-control" placeholder="" name="Intakecode" value="<?php echo $row['Intake_code']?>">
            
            <label for="exampleInputName2">MSM or Partner Institution name:</label><input type="text" class="form-control" placeholder="" name="Institutionname" value="<?php echo $row['Institution_name']?>">
            
            <label for="exampleInputName2">Program location(city&amp;country):</label><input type="text" class="form-control" placeholder="" name="programlocation" value="<?php echo $row['program_location']?>">
            </div>
               
        </div><!--end first table--> 
        
        <!-- start second table-->
        
        <div class="row">
            <div class="col-md-2"></div>  
            <div class="col-md-1"></div>
            <div class="col-md-6 text-center">
            <h4>Objection regarding written Examination or Assignment grade</h4>
            </div>
        </div> 
        <div class="row">
            <div class="col-md-2"></div>
            
            <div class="col-md-1"></div>
        <div class="col-md-6 bg-primary">
             
            <label for="exampleInputName2">Course Name:</label><input type="text" class="form-control" placeholder="" name="Coursename" value="<?php echo $row['Course_name']?>">
             
            <label for="exampleInputName2">Course lecturer Name:</label><input type="text" class="form-control" placeholder="" name="lecturername" value="<?php echo $row['lecturer_name']?>">
            
            <label for="exampleInputName2">Assignment or Examination:</label><input type="text" class="form-control" placeholder="" name="AssignorExam" value="<?php echo $row['Assign_or_Exam']?>">
            
            <label for="exampleInputName2">Individual or Group assignment:</label><label class="radio-inline">
  <input type="radio" name="indorGrop" id="inlineRadio1" value="Individual"> Individual
</label>
            <label class="radio-inline">
  <input type="radio" name="indorGrop" id="inlineRadio1" value="Group"> Group
</label>
            <div class="row">
                <div class="col-md-6">
                <label for="exampleInputName2">Grade Result:</label><input type="number" class="form-control" placeholder="" name="graderesult" value="<?php echo $row['grade_result']?>">
                </div>
            </div>
            </div>
        </div>
        
         <!-- start third table-->
        
        <div class="row">
            <div class="col-md-2"></div>
            
            <div class="col-md-1"></div>
            <div class="col-md-6 text-center">
            <h4>Objection regarding written Master Thesis or Final Project grade</h4>
            </div>
        </div> 
        <div class="row">
            <div class="col-md-2"></div>
            
            <div class="col-md-1"></div>
        <div class="col-md-6 bg-primary">
             
            <label for="exampleInputName2">Master Thesis or Final Project Title:</label><input type="text" class="form-control" placeholder="" name="ProjectTitle" value="<?php echo $row['Project_Title']?>">
             
            <label for="exampleInputName2">Supervisor:</label><input type="text" class="form-control" placeholder="" name="Supervisor" value="<?php echo $row['Supervisor']?>">
            
            <label for="exampleInputName2">(External) Evaluator(s):</label><input type="text" class="form-control" placeholder="" name="Evaluator"  value="<?php echo $row['Evaluator']?>">
               
            <label for="exampleInputName2">Defense Date:</label><input type="date" class="form-control" placeholder="" name="Date" value="<?php echo $row['Date']?>">
            <div class="row">
                <div class="col-md-6">
                <label for="exampleInputName2">Grade Result:</label><input type="number" class="form-control" placeholder="" name="gradeproject" value="<?php echo $row['grade_project']?>">
                </div>
            </div>
            </div>
        </div>
        
           <!-- start forth table-->
        
        <div class="row">
            <div class="col-md-2"></div>   
            <div class="col-md-1"></div>
            <div class="col-md-6 text-center">
            <h4>Objection regarding BHAP&#40;EP programs only&#41;</h4>
            </div>
        </div> 
        <div class="row">
            <div class="col-md-2"></div>  
            <div class="col-md-1"></div>
        <div class="col-md-6 bg-primary">
             
            <label for="exampleInputName2">BHAP Title:</label><input type="text" class="form-control" placeholder="" name="BHAPtitle" value="<?php echo $row['BHAP_title']?>">
             
            <label for="exampleInputName2">Coach:</label><input type="text" class="form-control" placeholder="" name="Coach" value="<?php echo $row['Coach']?>">
            
            <label for="exampleInputName2">(External) Evaluator(s) BHAP:</label><input type="text" class="form-control" placeholder="" name="EvaluatorBHAP" value="<?php echo $row['Evaluator_BHAP']?>">

            <div class="row">
                <div class="col-md-6">
                <label for="exampleInputName2">Presentation and Defense Date BHAP:</label><input type="date" class="form-control" placeholder="" name="dateBHAP" value="<?php echo $row['date_BHAP']?>">
                </div>
            </div>
            </div>
        </div>
        
         <!-- start fifth table-->
        
        <div class="row">
            <div class="col-md-2"></div>  
            <div class="col-md-1"></div>
            <div class="col-md-6 text-center">
            <h4>Motivation of objection </h4>
            </div>
        </div> 
        <div class="row">
            <div class="col-md-2"></div> 
            <div class="col-md-1"></div>
        <div class="col-md-6 bg-primary">
             
            <label for="exampleInputName2">Question:</label><textarea class="form-control" rows="3" name="Question"></textarea>
             
            <label for="exampleInputName2">Objection:</label><textarea class="form-control" rows="4" name="Objection"></textarea>

            <label for="exampleInputName2">Motivation:</label><textarea class="form-control" rows="5" name="Motivation"></textarea>
 
            </div>
        </div>
         <div class="row">
            <div class="col-md-2"></div>  
            <div class="col-md-1"></div>
        <div class="col-md-6 bg-primary">  
            <u>Declaration:</u>
            <br><br>
             
            <p>&#45;I have read the section &#39;Right of objection&#39;in the Education and Examination Regulations(EER) applying to the program or the Program Booklet applying to the EP programs.</p>
            <p>&#45;I understand and accept the terms and conditions.</p>
            
            <div class="col-md-6">
            <label for="exampleInputName2">Date:</label><input type="date" class="form-control" placeholder="" name="Declarationdate" value="<?php echo $row['Declaration_date']?>">
            
            </div>
            </div>
        </div>
         <div class="row">
    <div class="col-md-4"></div>
        <div class="col-md-4"> 
            <button class="btn btn-primary" name="insert">Submit</button></div></div>
    </div>
          <div class="row">
    <div class="col-md-4"></div>
        <div class="col-md-4"><button class="btn btn-primary " type="reset">Cancel</button></div>
    </div>
        </form>      
</div>
    </div>
</section>
<?php 
  }}
?>
<?php include("inc/footer.php"); ?>