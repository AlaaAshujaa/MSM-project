<?php include("inc/header.php"); ?>

<div class="container">
        <div class="row">
              <div class="col-md-2"><img src="images/CBA-Logo-Converted.png"             style="width:120px;height:90px;"></div>
              <div class="col-md-5  ">
            <ol class="breadcrumb">
  <li><a href="Home.php">Home</a></li>
  <li><a href="student_enrolling3.php">Student Enrolling 3</a></li>
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
    
@$Professionalorganization=$_POST['Professionalorganization'];
@$ProfessionalType=$_POST['ProfessionalType'];
@$ProfessionalBusinessadd=$_POST['ProfessionalBusinessadd'];
@$Professionalcountry=$_POST['Professionalcountry'];
@$Professionalcity=$_POST['Professionalcity'];
@$Professionalcode=$_POST['Professionalcode'];
@$Professionalbusinesstele=$_POST['Professionalbusinesstele'];
@$Professionalbusinessfax=$_POST['Professionalbusinessfax'];
@$Professionalmobilephone=$_POST['Professionalmobilephone'];
@$Professionalemail=$_POST['Professionalemail'];
@$Professionalcurrentpos=$_POST['Professionalcurrentpos'];
@$Professionalpossince=$_POST['Professionalpossince'];
@$Professionaldescription=$_POST['Professionaldescription'];
@$Professionalnameorg1=$_POST['Professionalnameorg1'];
@$Professionalpositionheld1=$_POST['Professionalpositionheld1'];
@$Professionalstartdate1=$_POST['Professionalstartdate1'];
@$Professionalfinishdate1=$_POST['Professionalfinishdate1'];
@$Professionaldescription1=$_POST['Professionaldescription1'];
@$Professionalnameorg2=$_POST['Professionalnameorg2'];
@$Professionalpositionheld2=$_POST['Professionalpositionheld2'];
@$Professionalstartdate2=$_POST['Professionalstartdate2'];
@$Professionalfinishdate2=$_POST['Professionalfinishdate2'];
@$Professionaldescription2=$_POST['Professionaldescription2'];
@$ProessionalSocietymember=$_POST['ProessionalSocietymember'];
    

    
if(empty($Professionalorganization) || empty($ProfessionalType) || empty($ProfessionalBusinessadd) || empty($Professionalcountry) || empty($Professionalcity) || empty($Professionalcode) || empty($Professionalbusinesstele) || empty($Professionalbusinessfax) || empty($Professionalmobilephone) || empty($Professionalemail) || empty($Professionalcurrentpos) || empty($Professionalpossince) || empty($Professionaldescription) || empty($Professionalnameorg1) || empty($Professionalpositionheld1) || empty($Professionalstartdate1) || empty($Professionaldescription1)|| empty($ProessionalSocietymember)){
      echo " <h4 style=\"color: red;\" align=\"center\" class='alert alert-danger'><i class='fa fa-thumbs-down'></i><br>please complete the fields</h4> "; 
    
      
  } else{ 
    $stmt=$con->prepare("UPDATE student SET professional_name_org=?,professional_type_org=?,professional_business_add=?,professional_country=?,professional_city=?,professional_code=?,professional_telephone=?,professional_fax=?,professional_mobile=?,professional_email=?,professional_current_position=?,professional_position_since=?,	professional_description=?,professional_name_org1=?,professional_position_held1=?,professional_start_date1=?,professional_finish_date1=?,professional_description1=?,	professional_name_org2=?,professional_position_held2=?,professional_start_date2=?,	professional_finish_date2=?,professional_description2=?,Professional_Society_memberships=? WHERE ID=(SELECT MAX(ID)FROM (SELECT * FROM student) AS student2)");
$stmt->execute(array($Professionalorganization,$ProfessionalType,$ProfessionalBusinessadd,$Professionalcountry,$Professionalcity,$Professionalcode,$Professionalbusinesstele,$Professionalbusinessfax,$Professionalmobilephone,$Professionalemail,$Professionalcurrentpos,$Professionalpossince,$Professionaldescription,$Professionalnameorg1,$Professionalpositionheld1,$Professionalstartdate1,$Professionalfinishdate1,$Professionaldescription1,$Professionalnameorg2,$Professionalpositionheld2,$Professionalstartdate2,$Professionalfinishdate2,$Professionaldescription2,$ProessionalSocietymember));
    
     header("location:student_enrolling4.php?execute=done");
}
}
?>
<!-- start student_enrolling-->
<section class="Student1">
    <div class="fields">
<div class="container">
<div class="row">
    <div class="col-md-12">
        <p class="text-right">Executive MBA - Application Form</p>
        <div class="container">
            <div class="row">
                    <div class="col-md-6">
    <form role="form" action="<?php $_SERVER['PHP_SELF'] ?>" method="post">
                 <h4>5- Professional background</h4>
	 <em>Current employer</em>
                 </div>
                    </div> 
            <div class="row">
            <div class="col-md-4">
                <label for="exampleInputName2">Name organization/company</label><input type="text" class="form-control" placeholder="" name="Professionalorganization">
                </div>
                
             <div class="col-md-8">
                <label for="exampleInputName2">Type of organiztion:</label>
                    <label class="radio-inline">
  <input type="radio" name="ProfessionalType" id="inlineRadio2" value="Government">  Government
</label>
<label class="radio-inline">
  <input type="radio" name="ProfessionalType" id="inlineRadio2" value="Semi-government">  Semi&#45;government
</label>
<label class="radio-inline">
  <input type="radio" name="ProfessionalType" id="inlineRadio2" value="NGO"> NGO
</label>
           <label class="radio-inline">
<input type="radio" name="ProfessionalType" id="inlineRadio2" value="Private company"> Private company
</label>
          <label class="radio-inline">
<input type="radio" name="ProfessionalType" id="inlineRadio2" value="
Public company"> Public company
</label>
            </div>
            </div>
            <div class="row">
           <div class="col-md-4">
                 <label for="exampleInputName2">Business address</label><input type="text" class="form-control" placeholder="" name="ProfessionalBusinessadd">
                </div>
                <div class="col-md-3">
                 <label for="exampleInputName2">Country</label><input type="text" class="form-control" placeholder="" name="Professionalcountry">
                </div>
            </div>
             <div class="row">
           <div class="col-md-4">
                 <label for="exampleInputName2">City</label><input type="text" class="form-control" placeholder="" name="Professionalcity">
                </div>
                <div class="col-md-3">
                 <label for="exampleInputName2">Postal code</label><input type="number" class="form-control" placeholder="" name="Professionalcode">
                </div>
            </div>
            
            <div class="row">
  <div class="col-md-6">
    <label for="exampleInputName2">Business telephone(country code,area code,number)</label>
      <div class="row">
  <div class="col-sm-8">
<input type="text" class="form-control" placeholder="" name="Professionalbusinesstele">
  </div>
</div>
  </div>
                     <div class="col-md-6">
     <label for="exampleInputName2">Business fax(country code,area code,number)</label>
      <div class="row">
  <div class="col-sm-8">
<input type="text" class="form-control" placeholder="" name="Professionalbusinessfax">
  </div>
  </div>
                         
 </div>
                <div class="row">
  <div class="col-md-6">
    <label for="exampleInputName2">Mobile phone(country code,area code,number)</label>
      <div class="row">
  <div class="col-sm-8">
<input type="text" class="form-control" placeholder="" name="Professionalmobilephone">
  </div>
</div>
</div>
                    <div class="col-md-4">
  <label for="exampleInputName2">Business E&#45;mail</label>
    <input type="email" class="form-control" placeholder="" name="Professionalemail">        
        </div>
  </div>
     
                <div class="row">
                <div class="col-md-4">
                   <label for="exampleInputName2">Current position</label><input type="text" class="form-control" placeholder="" name="Professionalcurrentpos">         
                    </div>
                    <div class="col-md-4">
                   <label for="exampleInputName2">in position since</label><input type="text" class="form-control" placeholder="" name="Professionalpossince">         
                    </div>
                    <div class="col-md-4">
  <label for="exampleInputName2">Description of duties and responsibilities:</label><textarea class="form-control" rows="4" name="Professionaldescription"></textarea>
                    </div>
                </div>  
                <div class="row">
                <br>
                </div>
                <div class="row">
                    <div class="col-md-6">
                    <em>Previous employers</em>
                    </div>
                </div>
                <div class="row">
                <div class="col-md-4">
 <label for="exampleInputName2">1&#45;Name organization/company</label>
 <input type="text" class="form-control" placeholder="" name="Professionalnameorg1">
                    </div>
                    <div class="col-md-4">
                    <label for="exampleInputName2">Position held</label><input type="text" class="form-control" placeholder="" name="Professionalpositionheld1">
                    </div>
                </div>
                 <div class="row">
                <div class="col-md-4">
<label for="exampleInputName2">Start date</label><input type="date" class="form-control" placeholder="" name="Professionalstartdate1">
                    </div>
                    <div class="col-md-4">
                    <label for="exampleInputName2">finish date</label><input type="date" class="form-control" placeholder="" name="Professionalfinishdate1">
                    </div>
                     <div class="col-md-4">
                     <label for="exampleInputName2">Description of duties and responsibilities:</label>
    <textarea class="form-control" rows="3" name="Professionaldescription1"></textarea>
                     </div>
                     
                </div>
               
             
                <div class="row">
                <div class="col-md-4">
                    <label for="exampleInputName2">2&#45;Name organization/company <b>&nbsp;&#40;optinal&#41;</b></label>
    <input type="text" class="form-control" placeholder="" name="Professionalnameorg2">
                    </div>
                    <div class="col-md-4">
                    <label for="exampleInputName2">Position held</label>
<input type="text" class="form-control" placeholder="" name="Professionalpositionheld2">
                    </div>
                </div>
                 <div class="row">
                <div class="col-md-4">
                    <label for="exampleInputName2">Start date</label>
    <input type="date" class="form-control" placeholder="" name="Professionalstartdate2">
                    </div>
                    <div class="col-md-4">
                    <label for="exampleInputName2">finish date</label>
<input type="date" class="form-control" placeholder="" name="Professionalfinishdate2">
                    </div>
                     <div class="col-md-4">
                     <label for="exampleInputName2">Description of duties and responsibilities:</label><textarea class="form-control" rows="3" name="Professionaldescription2"></textarea>
                     </div>
                      
                </div>
               <div class="row">
                <div class="col-md-6">
                   <label for="exampleInputName2">Professional Society memberships:<b style="color:firebrick;">&nbsp;&#40;important&#42;&#41;</b></label><textarea class="form-control" rows="3" name="ProessionalSocietymember"></textarea>
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
    <li class="active"><a href="student_enrolling3.php">Form Page3</a></li>
    <li class="disabled"><a href="student_enrolling4.php">Form Page4</a></li>
    <li class="disabled"><a href="student_enrolling5.php">Form Page5</a></li>
     <li class="disabled"><a href="">Form Page6</a></li> 
    <li>
      <a href="#" aria-label="Next">
        <span aria-hidden="true">&raquo;</span>
      </a>

            </li>
          </ul>
        </nav></div>
                
                </div>   
        </div>
            </form>   
        </div>
    </div>
    </div>
     </div>
    </div>
</section>

<?php include("inc/footer.php"); ?>