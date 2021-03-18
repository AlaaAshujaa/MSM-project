<?php include("inc/header.php"); ?>

<div class="container">
        <div class="row">
              <div class="col-md-2"><img src="images/CBA-Logo-Converted.png"             style="width:120px;height:90px;"></div>
              <div class="col-md-5  ">
            <ol class="breadcrumb">
  <li><a href="Home.php">Home</a></li>
  <li><a href="student_enrolling4.php.php">Student Enrolling 4</a></li>
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

@$recommendname=$_POST['recommend_name'];
@$areasaccount=$_POST['areas_account'];
@$areaslaw=$_POST['areas_law'];
@$areasethics=$_POST['areas_ethics'];
@$areaseconomic=$_POST['areas_economic'];
@$areasfinance=$_POST['areas_finance'];
@$areasIB=$_POST['areas_IB'];
@$areasMIS=$_POST['areas_MIS'];
@$areasmarket=$_POST['areas_market'];
@$areasmath=$_POST['areas_math'];
@$areasoperation=$_POST['areas_operation'];
@$areasorgbehavior=$_POST['areas_org_behavior'];
@$areasresearchskill=$_POST['areas_research_skill'];
@$areasstatistic=$_POST['areas_statistic'];
@$areasstrategy=$_POST['areas_strategy'];
@$areasGMAT=$_POST['areas_GMAT'];
@$areasGMATyesdate=$_POST['areas_GMAT_yes_date'];
@$areasGMATscore=$_POST['areas_GMAT_score'];
    

  
    if(empty($recommendname) || empty($areasaccount) || empty($areaslaw) || empty($areasethics) || empty($areaseconomic) || empty($areasfinance) || empty($areasIB) || empty($areasMIS) || empty($areasmarket) || empty($areasmath) || empty($areasoperation) || empty($areasorgbehavior) || empty($areasresearchskill) || empty($areasstatistic) || empty($areasstrategy) || empty($areasGMAT))
        {
         echo " <h4 style=\"color: red;\" align=\"center\" class='alert alert-danger'><i class='fa fa-thumbs-down'></i><br>please complete the fields</h4> "; 
    }else{
    $stmt=$con->prepare("UPDATE student SET recommend_name=?,areas_account=?,areas_law=?,
areas_ethics=?,areas_economic=?,areas_finance=?,areas_IB=?,areas_MIS=?,areas_market=?,areas_math=?,areas_operation=?,areas_org_behavior=?,areas_research_skill=?,areas_statistic=?,areas_strategy=?,areas_GMAT=?,areas_GMAT_yes_date=?,areas_GMAT_score=? WHERE ID=(SELECT MAX(ID)FROM (SELECT * FROM student) AS student2)");    
    
$stmt->execute(array($recommendname,$areasaccount,$areaslaw,$areasethics,$areaseconomic,$areasfinance,$areasIB,$areasMIS,$areasmarket,$areasmath,$areasoperation,$areasorgbehavior,$areasresearchskill,$areasstatistic,$areasstrategy,$areasGMAT,$areasGMATyesdate,$areasGMATscore));
   header("location:student_enrolling5.php?execute=done");
    }
}
?>
<!--start student enrolling4 -->
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
                <h4>6- Recommendation letters</h4>
				 <p >Two recommendation letters,(at least one from your current/previous managers)on offical letterhead from individuals who can evaluate your professional experience and judge your likelihood of success in this program should accompany this application.</p>
               

                <div class="row">
  <div class="col-md-3">
    <label for="exampleInputName2">Names and positions of the two people sending the recommendation letters:</label><textarea  name="recommend_name" class="form-control" rows="3"></textarea>
     
  </div>
                </div>
             <div class="row">
                    <div class="col-md-6">
                 <h4>7- Areas of Management</h4>
	 <p >Indicate your relative degree of knowledge in each of the areas listed below: </p>
                 </div>
                    </div> 
    
                 <div class="row">
 <div class="col-md-3"></div>
  <div class="col-md-3 col-sm-1">
    <label for="exampleInputName2">Basic</label>
  </div>
  <div class="col-md-3 col-sm-1">
    <label for="exampleInputName2">Good</label>
  </div>
   <div class="col-md-3 col-sm-1">
    <label for="exampleInputName2">Excellent</label>
  </div>
                    
 
</div>
              
                <div class="row">
  <div class="col-md-3">
    <label for="exampleInputName2">accounting</label>
  </div>
  <div class="col-md-3">
   <label class="radio-inline">
  <input type="radio" name="areas_account" id="inlineRadio1" value="accounting_Basic"> 
</label> </div>
  <div class="col-md-3">
     <label class="radio-inline">
<input type="radio" name="areas_account" id="inlineRadio1" value="accounting_Good"> 
</label>  
  </div>
   <div class="col-md-3">
     <label class="radio-inline">
<input type="radio" name="areas_account" id="inlineRadio1" value="accounting_Excellent"> 
</label>   
  </div>                 
 
</div>
                <div class="row">
				<div class="col-md-3">
    <label for="exampleInputName2">Business law</label>
  </div>
  <div class="col-md-3">
     <label class="radio-inline">
<input type="radio" name="areas_law" id="inlineRadio1" value="Business law_Basic"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_law" id="inlineRadio1" value="Business law_Good"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_law" id="inlineRadio1" value="Business law_Excellent"> 
</label>   
  </div> 
</div>
   <div class="row">
				<div class="col-md-3">
    <label for="exampleInputName2">Business Ethics</label>
  </div>
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_ethics" id="inlineRadio1" value="Business Ethics_Basic"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_ethics" id="inlineRadio1" value="Business Ethics_Good"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
<input type="radio" name="areas_ethics" id="inlineRadio1" value="Business Ethics_Excellent"> 
</label>   
  </div> 
</div>
   <div class="row">
				<div class="col-md-3">
    <label for="exampleInputName2">Economics</label>
  </div>
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_economic" id="inlineRadio1" value="Economics_Basic"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_economic" id="inlineRadio1" value="Economics_Good"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_economic" id="inlineRadio1" value="Economics_Excellent"> 
</label>   
  </div> 
</div>
        <div class="row">
				<div class="col-md-3">
    <label for="exampleInputName2">Finance</label>
  </div>
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_finance" id="inlineRadio1" value="Finance_Basic"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_finance" id="inlineRadio1" value="Finance_Good"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_finance" id="inlineRadio1" value="Finance_Excellent"> 
</label>   
  </div> 
</div>
   <div class="row">
				<div class="col-md-3">
    <label for="exampleInputName2">International Business</label>
  </div>
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_IB" id="inlineRadio1" value="International Business_Basic"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_IB" id="inlineRadio1" value="International Business_Good"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_IB" id="inlineRadio1" value="International Business_Excellent"> 
</label>   
  </div> 
</div>
   <div class="row">
				<div class="col-md-3">
    <label for="exampleInputName2">Management Information System</label>
  </div>
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_MIS" id="inlineRadio1" value="Management Information System_Basic"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_MIS" id="inlineRadio1" value="Management Information System_Good"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_MIS" id="inlineRadio1" value="Management Information System_Excellent"> 
</label>   
  </div> 
</div>
   <div class="row">
				<div class="col-md-3">
    <label for="exampleInputName2">Marketing</label>
  </div>
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_market" id="inlineRadio1" value="Marketing_Basic"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_market" id="inlineRadio1" value="Marketing_Good"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_market" id="inlineRadio1" value="Marketing_Excellent"> 
</label>   
  </div> 
</div>
   <div class="row">
				<div class="col-md-3">
    <label for="exampleInputName2">Mathematics</label>
  </div>
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_math" id="inlineRadio1" value="Mathematics_Basic"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_math" id="inlineRadio1" value="Mathematics_Good"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_math" id="inlineRadio1" value="Mathematics_Excellent"> 
</label>   
  </div> 
</div>
   <div class="row">
				<div class="col-md-3">
    <label for="exampleInputName2">Operations</label>
  </div>
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_operation" id="inlineRadio1" value="Operations_Basic"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_operation" id="inlineRadio1" value="Operations_Good"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_operation" id="inlineRadio1" value="Operations_Excellent"> 
</label>   
  </div> 
</div>
   <div class="row">
				<div class="col-md-3">
    <label for="exampleInputName2">Organizational behavior</label>
  </div>
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_org_behavior" id="inlineRadio1" value="Organizational behavior_Basic"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_org_behavior" id="inlineRadio1" value="Organizational behavior_Good"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_org_behavior" id="inlineRadio1" value="Organizational behavior_Excellent"> 
</label>   
  </div> 
</div>
   <div class="row">
				<div class="col-md-3">
    <label for="exampleInputName2">Research Skills</label>
  </div>
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_research_skill" id="inlineRadio1" value="Research Skills_Basic"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_research_skill" id="inlineRadio1" value="Research Skills_Good"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_research_skill" id="inlineRadio1" value="Research Skills_Excellent"> 
</label>   
  </div> 
</div>
   <div class="row">
				<div class="col-md-3">
    <label for="exampleInputName2">Statistics</label>
  </div>
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_statistic" id="inlineRadio1" value="Statistics_Basic"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_statistic" id="inlineRadio1" value="Statistics_Good"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_statistic" id="inlineRadio1" value="Statistics_Excellent"> 
</label>   
  </div> 
</div>
   <div class="row">
				<div class="col-md-3">
    <label for="exampleInputName2">Strategy</label>
  </div>
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_strategy" id="inlineRadio1" value="areas_strategy Basic"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_strategy" id="inlineRadio1" value="areas_strategy Good"> 
</label>   
  </div> 
  <div class="col-md-3">
     <label class="radio-inline">
  <input type="radio" name="areas_strategy" id="inlineRadio1" value="areas_strategy Excellent"> 
</label>   
  </div> 
</div>
<br><br><br>
   <div class="row">
			
    <label for="exampleInputName2">GMAT taken:</label>
  
  
   <label class="radio-inline">
  <input type="radio" name="areas_GMAT" id="optionsRadios4" value="areas_GMAT yes"> Yes
</label>  
   
  
    <label class="radio-inline">
  <input type="radio" name="areas_GMAT" id="inlineRadio2" value="areas_GMAT No"> No
</label>  
 
 
</div>
  <div class="row">
  <div class="col-md-3">
    <label for="exampleInputName2">if yes, date taken</label><input type="date" class="form-control" placeholder="" name="areas_GMAT_yes_date" id="reason" disabled>
  </div>
   <div class="col-md-3">
    <label for="exampleInputName2">Score</label><input type="text" class="form-control" placeholder="" name="areas_GMAT_score">
  </div>
  </div>
      <div class="row">
                 <div class="col-md-7"></div>
          <div class="col-md-4">
 <a href=""><button class="btn btn-primary" type="submit" name="submit">Next</button></a></div>
                
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

    <li><a href="student_enrolling.php">Form Page1</a></li>
    <li><a href="student_enrolling2.php">Form Page2</a></li>
    <li><a href="student_enrolling3.php">Form Page3</a></li>
    <li class="active"><a href="student_enrolling4.php">Form Page4</a></li>
    <li class="disabled"><a href="student_enrolling5.php">Form Page5</a></li>
    <li class="disabled"><a href="student_enrolling6.php">Form Page6</a></li>  
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
</section>


<?php include("inc/footer.php"); ?>