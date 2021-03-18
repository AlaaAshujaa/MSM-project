<?php include("inc/header.php"); ?>

<div class="container">
        <div class="row">
              <div class="col-md-2"><img src="images/CBA-Logo-Converted.png"             style="width:120px;height:90px;"></div>
              <div class="col-md-5  ">
            <ol class="breadcrumb">
  <li><a href="Home.php">Home</a></li>
  <li><a href="student_enrolling.php">Student Enrolling 1</a></li>
</ol>
            </div>
        
            </div> 
        </div>

<?php


//$stmt=$con->prepare("SELECT * FROM student ORDER BY ID DESC");
//$stmt->execute();
//@$rows=$stmt->fetchAll();
//
//foreach($rows as $row):
//$string='E-MBA';
//$date=date("y");
// @$id= $row['ID'].'/'.$string.'/'.$date;
//
//endforeach;

//$stmt=$con->prepare("INSERT INTO student (student_id) VALUES (:student_id)");
//$stmt->execute(array('student_id'=>$id));

//$y=date('y');
//$inid=str_pad('/E-MBA/','0',STR_PAD_LEFT);
//echo $id=$inid.$y;


//$q=$con->prepare("INSERT INTO student(student_id) VALUES('$id')");
// 
//
//$q->execute($id);

/////////////////////////////////////////////////////
 if(isset($_POST['submit'])){
     
    // @$student_id=$id;
     @$id=$_POST[''];
     @$MF=$_POST['M_F'];
     @$FIRSTNAME=$_POST['firstname'];
     @$MiddleName=$_POST['midname'];
     @$FamilyName=$_POST['familyname'];
     @$Homeaddress=$_POST['homeadd'];
     @$City=$_POST['city'];
     @$PostalCode=$_POST['postalcode'];
     @$Country=$_POST['country'];
     @$HomeTelephone=$_POST['hometelephone'];
     @$HomeFax=$_POST['homefax'];
     @$MobilePhone=$_POST['mobilephone'];
     @$Personalemail=$_POST['Pemail'];
    
     @$BirthDate=$_POST['birthdate'];
     @$BirthPlace=$_POST['birthplace'];
     @$Nationalty=$_POST['nationalty'];
     @$PreferredAddress=$_POST['preferredaddress'];
     @$IDnum=$_POST['idnum'];
     @$Passport=$_POST['passport'];
     @$Issue=$_POST['issue'];
     @$IssueDate=$_POST['issuedate'];
     @$ExpirationDate=$_POST['expirationdate'];
     @$Person=$_POST['person'];
     @$Relation=$_POST['relation'];
     @$EmergecyAddress=$_POST['Emergecyaddress'];
     @$EmergecyCity=$_POST['Emergecycity'];
     @$EmergecyPostal=$_POST['Emergecypostal'];
     @$EmergecyCountry=$_POST['Emergecycountry'];
     @$EmergecyTelephone=$_POST['Emergecytelephone'];
     @$EmergecyFax=$_POST['Emergecyfax'];
     @$EmrgecyMobile=$_POST['Emergecymobile'];
     @$EmergecyEmail=$_POST['Emergecyemail'];
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

     @$other_program=$_POST['other_program'];
@$other_about_program=$_POST['other_about_program'];   
@$other_about_PA=$_POST['other_about_PA'];   
@$other_about_other=$_POST['other_about_other'];   
@$Statement_date=$_POST['Statement_date'];
    
      
$stmt=$con->prepare("UPDATE student SET
M_F=?,first_name=?,middle_name=?,family_name=?,home_address=?,city=?,postal_code=?,country=?,home_telephone=?,home_fax=?,mobile_phone=?,personal_email=?,date_birth=?,place_birth=?,nationality=?,preferred_address=?,data_id=?,data_passport_num=?,data_issue_place=?,data_date_issue=?,data_date_expiration=?,emergency_person=?,emergency_type_relation=?,emergency_address=?,emergency_city=?,emergency_code=?,emergency_country=?,emergency_telephone=?,emergency_fax=?,emergency_mobile=?,emergency_email=?,educational_highest=?, educational_highest_other=?,educational_list_academic=?,educational_institute1=?,educational_start_date1=?,educational_finish_date1=?,educational_degree1=?,educational_majer1=?,educational_institute2=?,educational_start_date2=?,educational_finish_date2=?,educational_degree2=?,educational_majer2=?,educational_institute3=?,educational_start_date3=?,educational_finish_date3=?,educational_degree3=?,educational_majer3=?,professional_name_org=?,professional_type_org=?,professional_business_add=?,professional_country=?,professional_city=?,professional_code=?,professional_telephone=?,professional_fax=?,professional_mobile=?,professional_email=?,professional_current_position=?,professional_position_since=?,	professional_description=?,professional_name_org1=?,professional_position_held1=?,professional_start_date1=?,professional_finish_date1=?,professional_description1=?,	professional_name_org2=?,professional_position_held2=?,professional_start_date2=?,	professional_finish_date2=?,professional_description2=?,Professional_Society_memberships=?,recommend_name=?,areas_account=?,areas_law=?,
areas_ethics=?,areas_economic=?,areas_finance=?,areas_IB=?,areas_MIS=?,areas_market=?,areas_math=?,areas_operation=?,areas_org_behavior=?,areas_research_skill=?,areas_statistic=?,areas_strategy=?,areas_GMAT=?,areas_GMAT_yes_date=?,areas_GMAT_score=?,proficiency_oral=?,proficiency_written=?,proficiency_english_lang=?,proficiency_lang_yes_date=?,proficiency_lang_yes_score=?,proficiency_lang_other=?,proficiency_result=?,profes_obj_learning=?,profes_obj_expectation=?,profes_obj_AC=?,other_program=?,other_about_program=?,other_about_PA=?,other_about_other=?,
Statement_date=? WHERE 
ID=(SELECT MAX(ID)FROM (SELECT * FROM student) AS student2)");
  
$stmt->execute(array($MF,$FIRSTNAME,$MiddleName,$FamilyName,$Homeaddress,$City,$PostalCode,$Country,$HomeTelephone,$HomeFax,$MobilePhone,$Personalemail,$BirthDate,$BirthPlace,$Nationalty,$PreferredAddress,$IDnum,$Passport,$Issue,$IssueDate,$ExpirationDate,$Person,$Relation,$EmergecyAddress,$EmergecyCity,$EmergecyPostal,$EmergecyCountry,$EmergecyTelephone,$EmergecyFax,$EmergecyMobile,$EmergecyEmail,$HighesT,$HighestOther,$ListAcademic,$EducationalInstitute,$EducationalStartDate,$EducationalfinishDate,$Educationaldegree,$Educationalmajor,$EducationalInstitute2,$EducationalStartDate2,$EducationalfinishDate2,$Educationaldegree2,$Educationalmajor2,$EducationalInstitute3,$EducationalStartDate3,$EducationalfinishDate3,$Educationaldegree3,$Educationalmajor3,$Professionalorganization,$ProfessionalType,$ProfessionalBusinessadd,$Professionalcountry,$Professionalcity,$Professionalcode,$Professionalbusinesstele,$Professionalbusinessfax,$Professionalmobilephone,$Professionalemail,$Professionalcurrentpos,$Professionalpossince,$Professionaldescription,$Professionalnameorg1,$Professionalpositionheld1,$Professionalstartdate1,$Professionalfinishdate1,$Professionaldescription1,$Professionalnameorg2,$Professionalpositionheld2,$Professionalstartdate2,$Professionalfinishdate2,$Professionaldescription2,$ProessionalSocietymember,$recommendname,$areasaccount,$areaslaw,$areasethics,$areaseconomic,$areasfinance,$areasIB,$areasMIS,$areasmarket,$areasmath,$areasoperation,$areasorgbehavior,$areasresearchskill,$areasstatistic,$areasstrategy,$areasGMAT,$areasGMATyesdate,$areasGMATscore,$proficiency_oral,$proficiency_written,$proficiency_english_lang,$proficiency_lang_yes_date,$proficiency_lang_yes_score,$proficiency_lang_other,$proficiency_result,$profes_obj_learning,$profes_obj_expectation,$profes_obj_AC,$other_program,$other_about_program,$other_about_PA,$other_about_other,$Statement_date));
     
echo "<div class='alert alert-success text-center'><h4>".$stmt->rowCount().
   " Record Updated Successfully</h4></div>";
    //exit();

}
 
?>
<?php
$do='';
$do=isset($_GET['do'])?$_GET['do']:'login';
if($do=='updatestudent'){
    
$userid=isset($_GET['userid'])&& is_numeric($_GET['userid'])?intval($_GET['userid']):0;
    $stmt=$con->prepare("SELECT * FROM student WHERE ID=? LIMIT 1");
    $stmt->execute(array($userid));
    $row=$stmt->fetch();    
    $count=$stmt->rowCount();
        if($stmt->rowCount()>0) { 


?>
<!--start student enrolling -->
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
              <input type="hidden" name="userid" value="<?php echo $userid?>"/> 
                <h4>1- Personal Data as stated in your passport</h4>
                <label class="radio-inline">
  <input type="radio" name="M_F" id="inlineRadio1" value="Mr"> Mr.
</label>
<label class="radio-inline">
  <input type="radio" name="M_F" id="inlineRadio1" value="Ms"> Ms.
</label>
<label class="radio-inline">
  <input type="radio" name="M_F" id="inlineRadio1" value="Mrs"> Mrs.
</label>
               
<div class="row">
             <div class="col-md-3">
    <label for="exampleInputName2">ID Number of student</label><input type="text" class="form-control" placeholder="" name="id" value="<?php echo $row['student_id']?>">
  </div>
             </div>


                <div class="row">
  <div class="col-md-3">
    <label for="exampleInputName2">First Name (as in passport)</label><input type="text" class="form-control" placeholder="" name="firstname" value="<?php echo $row['first_name']?>">
  </div>
  <div class="col-md-3">
    <label for="exampleInputName2">Middle Name (as in passport)</label><input type="text" class="form-control" placeholder="" name="midname" value="<?php echo $row['middle_name']?>">
  </div>
  <div class="col-md-3">
    <label for="exampleInputName2">Family Name (as in passport)</label><input type="text" class="form-control" placeholder="" name="familyname" value="<?php echo $row['family_name']?>">
  </div>
 
</div>
                
                <div class="row">
                    <div class="col-md-3">
    <label for="exampleInputName2">Home address (no.+street)</label><input type="text" class="form-control" placeholder="" name="homeadd" value="<?php echo $row['home_address']?>">
  </div>
  <div class="col-md-3">
    <label for="exampleInputName2">City</label><input type="text" class="form-control" placeholder="" name="city" value="<?php echo $row['city']?>">
  </div>
  <div class="col-md-3">
    <label for="exampleInputName2">Postal code</label><input type="number" class="form-control" placeholder="" name="postalcode" value="<?php echo $row['postal_code']?>">
  </div>
  
 </div>
                <div class="row">
                <div class="col-md-3">
    <label for="exampleInputName2">country</label><input type="text" class="form-control" placeholder="" name="country" value="<?php echo $row['country']?>">
  </div>
                </div>
                 <div class="row">
                     
  <div class="col-md-6">
      <br>
    <label for="exampleInputName2">Home telephone(country code,area code,number)</label>
      <div class="row">
  <div class="col-sm-8">
    <input type="text" class="form-control" placeholder="" name="hometelephone" value="<?php echo $row['home_telephone']?>">
  </div>
  
</div>
  </div>            
     <div class="col-md-6"></div>
            </div>
                <div class="row">
                    <div class="col-md-6">
        <label for="exampleInputName2">Home fax(country code,area code,number)</label>
      <div class="row">
  <div class="col-sm-8">
    <input type="text" class="form-control" placeholder="" name="homefax" value="<?php echo $row['home_fax']?>">
  </div>
 </div>
 </div>
  </div>    
                <div class="row">
  <div class="col-md-6  "><br>
    <label for="exampleInputName2">Mobile phone(country code,number)</label>
      <div class="row">
  <div class="col-sm-8">
    <input type="text" class="form-control" placeholder="" name="mobilephone" value="<?php echo $row['mobile_phone']?>">
  </div>
</div>
  </div>           
 </div>
                <div class="row">
                   <div class="col-md-4"><br>
                     <label for="exampleInputName2">Personal e-mail</label><input type="email" class="form-control" placeholder="" name="Pemail" value="<?php echo $row['personal_email']?>">
  </div>
                </div>
                   <div class="row">
  <div class="col-md-4"><br>
    <label for="exampleInputName2">Date of birth(day/month/year)</label><input type="date" class="form-control" placeholder="" name="birthdate" value="<?php echo $row['date_birth']?>">
  </div>
  <div class="col-md-4">
    <label for="exampleInputName2">Place of birth</label><input type="text" class="form-control" placeholder="" name="birthplace" value="<?php echo $row['place_birth']?>">
  </div>
  <div class="col-md-4">
    <label for="exampleInputName2">Nationalty</label><input type="text" class="form-control" placeholder="" name="nationalty" value="<?php echo $row['nationality']?>">
  </div>
 </div>
              
                   <div class="row">
  <div class="col-md-4"><br>
    <label for="exampleInputName2">preferred address for further correspondence:</label><label class="radio-inline">
  <input type="radio" name="preferredaddress"  value="Home address" id="inlineRadio" > Home address
</label>
<label class="radio-inline">
  <input type="radio" name="preferredaddress"  value="Business address" id="inlineRadio"> Business address
</label>
  </div>
  
 </div>  
                
    <h4>2- Data needed</h4>
                 <div class="row">
  <div class="col-md-4">
    <label for="exampleInputName2">ID Number</label><input type="text" class="form-control" placeholder="" name="idnum" value="<?php echo $row['data_id']?>">

  </div>
  <div class="col-md-4">
    <label for="exampleInputName2">Passport number</label><input type="text" class="form-control" placeholder="" name="passport" value="<?php echo $row['data_passport_num']?>">
  </div>
  <div class="col-md-4">
    <label for="exampleInputName2">Issue place</label><input type="text" class="form-control" placeholder="" name="issue" value="<?php echo $row['data_issue_place']?>">
  </div>
                     <div class="row">
                         <div class="col-md-4">
    <label for="exampleInputName2">Date of issue(day/month/year)</label><input type="date" class="form-control" placeholder="" name="issuedate" value="<?php echo $row['data_date_issue']?>">
                        
  </div>
    <div class="col-md-4"> <label for="exampleInputName2">Date of expiration</label><input type="date" class="form-control" placeholder="" name="expirationdate" value="<?php echo $row['data_date_expiration']?>"></div>                     
</div>
 
</div>
                <h4>3- Emergecy data</h4>
                <div class="row">
  <div class="col-md-3">
    <label for="exampleInputName2">Person to be notified</label><input type="text" class="form-control" placeholder="" name="person" value="<?php echo $row['emergency_person']?>">
  </div>
  <div class="col-md-3">
    <label for="exampleInputName2">Type of relation</label><input type="text" class="form-control" placeholder="" name="relation"
                                value="<?php echo $row['emergency_type_relation']?>">
  </div>
  <div class="col-md-3">
    <label for="exampleInputName2">Address</label><input type="text" class="form-control" placeholder="" name="Emergecyaddress"
                            value="<?php echo $row['emergency_address']?>">
      
  </div>
                   
 
                </div>
                <div class="row">
  <div class="col-md-3">
    <label for="exampleInputName2">City</label><input type="text" class="form-control" placeholder="" name="Emergecycity" value="<?php echo $row['emergency_city']?>">
  </div>
  <div class="col-md-3">
    <label for="exampleInputName2">Postal code</label><input type="number" class="form-control" placeholder="" name="Emergecypostal" 
                    value="<?php echo $row['emergency_code']?>">
  </div>
                    
                     <div class="col-md-3">
    <label for="exampleInputName2">Country</label><input type="text" class="form-control" placeholder="" name="Emergecycountry" value="<?php echo $row['emergency_country']?>">
      
  </div> 
                    
</div>
                <div class="row">
                <div class="col-md-6">
      <label for="exampleInputName2">Telephone(country code,area code,number)</label>
      <div class="row">
  <div class="col-sm-8">
    <input type="text" class="form-control" placeholder="" name="Emergecytelephone" value="<?php echo $row['emergency_telephone']?>">
                    </div>
                     </div>
                    </div> 
                </div>
  <div class="row">
     <div class="col-md-6">
        <label for="exampleInputName2">fax(country code,area code,number)</label>
      <div class="row">
  <div class="col-sm-8">
    <input type="text" class="form-control" placeholder="" name="Emergecyfax" value="<?php echo $row['emergency_fax']?>">
  </div>
    </div>
 </div> 
                 </div>
                <div class="row">
                     <div class="col-md-6">
        <label for="exampleInputName2">Mobile phone(country code,number)</label>
      <div class="row">
  <div class="col-sm-8">
    <input type="text" class="form-control" placeholder="" name="Emergecymobile" value="<?php echo $row['emergency_mobile']?>">
                     </div>
                     </div>
                    </div> 
     
         </div>
                <div class="row">
                 <div class="col-md-4"><label for="exampleInputName2">E-mail</label><input type="email" class="form-control" placeholder="" name="Emergecyemail" value="<?php echo $row['emergency_email']?>"></div>
                    <br>
                </div>
     
                
                 </div>
                 </div>
                </div>
                 </div>
                </div>
                </div>
                </div>
                </section>
<br>
<!-- start student_enrolling2-->
<section class="Student1">
<div class="fields">
<div class="container">
<div class="row">
   <p class="text-right">Executive MBA - Application Form</p> 
    <h4>4- Educational background</h4>
    <label>Highest qualification</label>
   
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
    
    </div>  
    <label for="exampleInputName2">1-Educational institute/University</label>
         <input type="text" class="form-control" placeholder="" name="Educationalinstitute" value="<?php echo $row['educational_institute1']?>">
    <div class="row">
    <div class="col-md-4">
        <label for="exampleInputName2">Start date</label><input type="date" class="form-control" placeholder="" name="EducationalStartdate" value="<?php echo $row['educational_start_date1']?>">
        </div>
        <div class="col-md-4">
        <label for="exampleInputName2">finish date</label><input type="date" class="form-control" placeholder="" name="Educationalfinishdate" value="<?php echo $row['educational_finish_date1']?>">
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
    <div class="col-md-4"><label for="exampleInputName2">Major</label><input type="text" class="form-control" placeholder="" name="EducationalMajor3" id="nodiploma" value="<?php echo $row['educational_majer1']?>"></div>   
    </div>
      <br>   
    <div class="row">
         <label for="exampleInputName2">2-Educational institute/University(Optional&#42;)</label><input type="text" class="form-control" placeholder="" name="Educationalinstitute2" value="<?php echo $row['educational_institute2']?>">
    <div class="row">
    <div class="col-md-4">
        <label for="exampleInputName2">Start date</label><input type="date" class="form-control" placeholder="" name="EducationalStartdate2" value="<?php echo $row['	educational_start_date2']?>">
        </div>
        <div class="col-md-4">
        <label for="exampleInputName2">finish date</label><input type="date" class="form-control" placeholder="" name="Educationalfinishdate2" value="<?php echo $row['	educational_finish_date2']?>">
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
    <div class="col-md-4"><label for="exampleInputName2">Major</label><input type="text" class="form-control" placeholder="" name="EducationalMajor3"
                                   value="<?php echo $row['educational_majer2']?>"></div>
        
    </div>
    </div>
    <br>
    <div class="row">
         <label for="exampleInputName2">3-Educational institute/University(Optional&#42;)</label><input type="text" class="form-control" placeholder="" name="Educationalinstitute3"
                                                                                                        value="<?php echo $row['educational_institute3']?>">
    <div class="row">
    <div class="col-md-4">
        <label for="exampleInputName2">Start date</label><input type="date" class="form-control" placeholder="" name="EducationalStartdate3" value="<?php echo $row['educational_start_date3']?>">
        </div>
        <div class="col-md-4">
        <label for="exampleInputName2">finish date</label><input type="date" class="form-control" placeholder="" name="Educationalfinishdate3" value="<?php echo $row['educational_finish_date3']?>">
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
    <div class="col-md-4"><label for="exampleInputName2">Major</label><input type="text" class="form-control" placeholder="" name="EducationalMajor3" value="<?php echo $row['educational_majer3']?>"></div>
      <br>  
    </div>
    </div>
     
    </div>
    </div>
</section>
<br>
<!-- start student_enrolling3-->
<section class="Student1">
    <div class="fields">
<div class="container">
<div class="row">
    <div class="col-md-12">
        <p class="text-right">Executive MBA - Application Form</p>
        <div class="container">
            <div class="row">
                    <div class="col-md-6">
    
                 <h4>5- Professional background</h4>
	 <em>Current employer</em>
                 </div>
                    </div> 
            <div class="row">
            <div class="col-md-4">
                <label for="exampleInputName2">Name organization/company</label><input type="text" class="form-control" placeholder="" name="Professionalorganization" value="<?php echo $row['professional_name_org']?>">
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
                 <label for="exampleInputName2">Business address</label><input type="text" class="form-control" placeholder="" name="ProfessionalBusinessadd" value="<?php echo $row['professional_business_add']?>">
                </div>
                <div class="col-md-3">
                 <label for="exampleInputName2">Country</label><input type="text" class="form-control" placeholder="" name="Professionalcountry" value="<?php echo $row['professional_country']?>">
                </div>
            </div>
             <div class="row">
           <div class="col-md-4">
                 <label for="exampleInputName2">City</label><input type="text" class="form-control" placeholder="" name="Professionalcity" value="<?php echo $row['professional_city']?>">
                </div>
                <div class="col-md-3">
                 <label for="exampleInputName2">Postal code</label><input type="number" class="form-control" placeholder="" name="Professionalcode" value="<?php echo $row['professional_code']?>">
                </div>
            </div>
            
            <div class="row">
  <div class="col-md-6">
    <label for="exampleInputName2">Business telephone(country code,area code,number)</label>
      <div class="row">
  <div class="col-sm-8">
<input type="text" class="form-control" placeholder="" name="Professionalbusinesstele"  value="<?php echo $row['professional_telephone']?>">
  </div>
</div>
  </div>
                     <div class="col-md-6">
     <label for="exampleInputName2">Business fax(country code,area code,number)</label>
      <div class="row">
  <div class="col-sm-8">
<input type="text" class="form-control" placeholder="" name="Professionalbusinessfax" value="<?php echo $row['professional_fax']?>">
  </div>
  </div>
                         
 </div>
                <div class="row">
  <div class="col-md-6">
    <label for="exampleInputName2">Mobile phone(country code,area code,number)</label>
      <div class="row">
  <div class="col-sm-8">
<input type="text" class="form-control" placeholder="" name="Professionalmobilephone" value="<?php echo $row['professional_mobile']?>">
  </div>
</div>
</div>
                    <div class="col-md-4">
  <label for="exampleInputName2">Business E&#45;mail</label>
    <input type="email" class="form-control" placeholder="" name="Professionalemail" value="<?php echo $row['professional_email']?>">        
        </div>
  </div>
     
                <div class="row">
                <div class="col-md-4">
                   <label for="exampleInputName2">Current position</label><input type="text" class="form-control" placeholder="" name="Professionalcurrentpos" value="<?php echo $row['professional_current_position']?>">         
                    </div>
                    <div class="col-md-4">
                   <label for="exampleInputName2">in position since</label><input type="text" class="form-control" placeholder="" name="Professionalpossince" value="<?php echo $row['professional_position_since']?>">         
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
 <input type="text" class="form-control" placeholder="" name="Professionalnameorg1"value="<?php echo $row['professional_name_org1']?>">
                    </div>
                    <div class="col-md-4">
                    <label for="exampleInputName2">Position held</label><input type="text" class="form-control" placeholder="" name="Professionalpositionheld1" value="<?php echo $row['professional_position_held1']?>">
                    </div>
                </div>
                 <div class="row">
                <div class="col-md-4">
<label for="exampleInputName2">Start date</label><input type="date" class="form-control" placeholder="" name="Professionalstartdate1" value="<?php echo $row['professional_start_date1']?>">
                    </div>
                    <div class="col-md-4">
                    <label for="exampleInputName2">finish date</label><input type="date" class="form-control" placeholder="" name="Professionalfinishdate1" value="<?php echo $row['professional_finish_date1']?>">
                    </div>
                     <div class="col-md-4">
                     <label for="exampleInputName2">Description of duties and responsibilities:</label>
    <textarea class="form-control" rows="3" name="Professionaldescription1"></textarea>
                     </div>
                     
                </div>
               
             
                <div class="row">
                <div class="col-md-4">
                    <label for="exampleInputName2">2&#45;Name organization/company <b>&nbsp;&#40;optinal&#42;&#41;</b></label>
    <input type="text" class="form-control" placeholder="" name="Professionalnameorg2" value="<?php echo $row['professional_name_org2']?>">
                    </div>
                    <div class="col-md-4">
                    <label for="exampleInputName2">Position held</label>
<input type="text" class="form-control" placeholder="" name="Professionalpositionheld2" value="<?php echo $row['professional_position_held2']?>">
                    </div>
                </div>
                 <div class="row">
                <div class="col-md-4">
                    <label for="exampleInputName2">Start date</label>
    <input type="date" class="form-control" placeholder="" name="Professionalstartdate2" value="<?php echo $row['professional_start_date2']?>">
                    </div>
                    <div class="col-md-4">
                    <label for="exampleInputName2">finish date</label>
<input type="date" class="form-control" placeholder="" name="Professionalfinishdate2" value="<?php echo $row['professional_finish_date2']?>">
                    </div>
                     <div class="col-md-4">
                     <label for="exampleInputName2">Description of duties and responsibilities:</label><textarea class="form-control" rows="3" name="Professionaldescription2"></textarea>
                     </div>
                      
                </div>
               <div class="row">
                <div class="col-md-6">
                   <label for="exampleInputName2">Professional Society memberships:<b style="color:firebrick;">&nbsp;&#40;important&#42;&#41;</b></label><textarea class="form-control" rows="3" name="ProessionalSocietymember" value="<?php echo $row['Professional_Society_memberships']?>"></textarea>
                   </div>
              
                 </div>  
                </div>
                
        </div>
    </div>
    </div>
     </div>
    </div>
</section>
<br>
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
    <label for="exampleInputName2">if yes, date taken</label><input type="date" class="form-control" placeholder="" name="areas_GMAT_yes_date" id="reason" disabled value="<?php echo $row['areas_GMAT_yes_date']?>">
  </div>
   <div class="col-md-3">
    <label for="exampleInputName2">Score</label><input type="text" class="form-control" placeholder="" name="areas_GMAT_score" value="<?php echo $row['areas_GMAT_score']?>">
  </div>
  </div>
 
 </div>
 </div>      
 </div>   
</div>
</div>
</div>
</section>
  <br>
    <!--start student enrolling5 -->
<section class="Student1">
    <div class="fields">
<div class="container">
<div class="row">
    <div class="col-md-12">
        <p class="text-right">Executive MBA - Application Form</p>
        <div class="container">
    
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
    <label for="exampleInputName2">if yes, date taken</label><input type="date" class="form-control" placeholder="" name="proficiency_lang_yes_date" value="<?php echo $row['proficiency_lang_yes_date']?>">
  </div>
   <div class="col-md-3">
    <label for="exampleInputName2">Score</label><input type="text" class="form-control" placeholder="" name="proficiency_lang_yes_score" value="<?php echo $row['proficiency_lang_yes_score']?>">
  </div>
  </div>
  <br>
   <div class="row">
  <div class="col-md-4">
    <label for="exampleInputName2">Other English Language test taken</label><input type="text" class="form-control" placeholder="" name="proficiency_lang_other" value="<?php echo $row['proficiency_lang_other']?>">
  </div>
   <div class="col-md-4">
    <label for="exampleInputName2">Result</label><input type="number" class="form-control" placeholder="" name="proficiency_result" value="<?php echo $row['proficiency_result']?>">
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

 </div>

        
 </div>
    
</div>
</div>
</div>
</section>
 <br>
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
       <input type="text" class="form-control" placeholder=""  name="other_about_PA" id="reason" disabled value="<?php echo $row['other_about_PA']?>">
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
    <input type="text" class="form-control" placeholder="" name="other_about_other" id="courseName"  value="<?php echo $row['other_about_other']?>">
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
      <input type="date" class="form-control" placeholder="" name="Statement_date" value="<?php echo $row['Statement_date']?>">
  </div>  </div> <br>
      <div class="row">
                <div class="col-md-4"></div>
            <div class="col-md-4">
     <a href=""><button class="btn btn-primary" type="submit" name="submit">Save</button></a></div>  
                </div>
            
   
                </form>                

 </div>
</div> 
 </div>    
</div>
</div>
</div>
</section>

<?php }}?>

<?php include("inc/footer.php"); ?>