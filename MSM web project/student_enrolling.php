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
    
       if(empty($MF) || empty($FIRSTNAME) || empty($MiddleName) || empty($FamilyName) || empty($Homeaddress) || empty($City) || empty($PostalCode) || empty($Country) || empty($Personalemail) || empty($Nationalty) || empty($BirthDate) || empty($BirthPlace) || empty($PreferredAddress) || empty($IDnum) || empty($Passport) || empty($Issue) || empty($IssueDate) || empty($ExpirationDate) || empty($Person) || empty($Relation) || empty ($EmergecyAddress) || empty($EmergecyCity) || empty($EmergecyPostal) || empty($EmergecyCountry) || empty($EmergecyTelephone) || empty($EmergecyFax) || empty($EmrgecyMobile) || empty($EmergecyEmail)){
  
           echo " <h4 style=\"color: red;\" align=\"center\" class='alert alert-danger'><i class='fa fa-thumbs-down'></i><br>please complete the fields</h4> "; 
           
       }else{
$stmt=$con->prepare("INSERT INTO student
(M_F,first_name,middle_name,family_name,home_address,city,postal_code,country,home_telephone,home_fax,mobile_phone,personal_email,date_birth,place_birth,nationality,preferred_address,data_id,data_passport_num,data_issue_place,data_date_issue,data_date_expiration,emergency_person,emergency_type_relation,emergency_address,emergency_city,emergency_code,emergency_country,emergency_telephone,emergency_fax,emergency_mobile,emergency_email) VALUES ('$MF','$FIRSTNAME','$MiddleName','$FamilyName','$Homeaddress','$City','$PostalCode','$Country','$HomeTelephone','$HomeFax','$MobilePhone','$Personalemail','$BirthDate','$BirthPlace','$Nationalty','$PreferredAddress','$IDnum','$Passport','$Issue','$IssueDate','$ExpirationDate','$Person','$Relation','$EmergecyAddress','$EmergecyCity','$EmergecyPostal','$EmergecyCountry','$EmergecyTelephone','$EmergecyFax','$EmergecyMobile','$EmergecyEmail')");
  
$stmt->execute(array($MF,$FIRSTNAME,$MiddleName,$FamilyName,$Homeaddress,$City,$PostalCode,$Country,$HomeTelephone,$HomeFax,$MobilePhone,$Personalemail,$BirthDate,$BirthPlace,$Nationalty,$PreferredAddress,$IDnum,$Passport,$Issue,$IssueDate,$ExpirationDate,$Person,$Relation,$EmergecyAddress,$EmergecyCity,$EmergecyPostal,$EmergecyCountry,$EmergecyTelephone,$EmergecyFax,$EmergecyMobile,$EmergecyEmail));
     
echo "<h4 style=\"color: green;\" align=\"center\" class='alert alert-success'>
<i class='fa fa-thumbs-up'></i><br>Insert data done successfully</h4> ";
     header("location:student_enrolling2.php?execute=done");
    //exit();
$string='E-MBA';
$date=date("y");
 
$id = $con->lastInsertId();
           @$id1= $id.'/'.$string.'/'.$date;

           $stmt=$con->prepare("UPDATE student SET student_id=? WHERE ID=?");                 $stmt->execute(array($id1,$id));
           
           
//           $q = "UPDATE student SET student_id=$id1 WHERE ID=$id";
//           var_dump($q);
//           $r = $con->exec($q);
//           var_dump($r);
           
}
 }
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
    <label for="exampleInputName2">First Name (as in passport)</label><input type="text" class="form-control" placeholder="" name="firstname">
  </div>
  <div class="col-md-3">
    <label for="exampleInputName2">Middle Name (as in passport)</label><input type="text" class="form-control" placeholder="" name="midname">
  </div>
  <div class="col-md-3">
    <label for="exampleInputName2">Family Name (as in passport)</label><input type="text" class="form-control" placeholder="" name="familyname">
  </div>
 
</div>
                
                <div class="row">
                    <div class="col-md-3">
    <label for="exampleInputName2">Home address (no.+street)</label><input type="text" class="form-control" placeholder="" name="homeadd">
  </div>
  <div class="col-md-3">
    <label for="exampleInputName2">City</label><input type="text" class="form-control" placeholder="" name="city">
  </div>
  <div class="col-md-3">
    <label for="exampleInputName2">Postal code</label><input type="number" class="form-control" placeholder="" name="postalcode">
  </div>
  
 </div>
                <div class="row">
                <div class="col-md-3">
    <label for="exampleInputName2">country</label><input type="text" class="form-control" placeholder="" name="country">
  </div>
                </div>
                 <div class="row">
                     
  <div class="col-md-6">
      <br>
    <label for="exampleInputName2">Home telephone(country code,area code,number)</label>
      <div class="row">
  <div class="col-sm-8">
    <input type="text" class="form-control" placeholder="" name="hometelephone">
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
    <input type="text" class="form-control" placeholder="" name="homefax">
  </div>
 </div>
 </div>
  </div>    
                <div class="row">
  <div class="col-md-6  "><br>
    <label for="exampleInputName2">Mobile phone(country code,number)</label>
      <div class="row">
  <div class="col-sm-8">
    <input type="text" class="form-control" placeholder="" name="mobilephone">
  </div>
</div>
  </div>           
 </div>
                <div class="row">
                   <div class="col-md-4"><br>
                     <label for="exampleInputName2">Personal e-mail</label><input type="email" class="form-control" placeholder="" name="Pemail">
  </div>
                </div>
                   <div class="row">
  <div class="col-md-4"><br>
    <label for="exampleInputName2">Date of birth(day/month/year)</label><input type="date" class="form-control" placeholder="" name="birthdate">
  </div>
  <div class="col-md-4">
    <label for="exampleInputName2">Place of birth</label><input type="text" class="form-control" placeholder="" name="birthplace">
  </div>
  <div class="col-md-4">
    <label for="exampleInputName2">Nationalty</label><input type="text" class="form-control" placeholder="" name="nationalty">
  </div>
 </div>
              
                   <div class="row">
  <div class="col-md-4"><br>
    <label for="exampleInputName2">preferred address for further correspondence:</label><label class="radio-inline">
  <input type="radio" name="preferredaddress"  value="Home address" id="inlineRadio"> Home address
</label>
<label class="radio-inline">
  <input type="radio" name="preferredaddress"  value="Business address" id="inlineRadio"> Business address
</label>
  </div>
  
 </div>  
                
    <h4>2- Data needed</h4>
                 <div class="row">
  <div class="col-md-4">
    <label for="exampleInputName2">ID Number</label><input type="text" class="form-control" placeholder="" name="idnum">

  </div>
  <div class="col-md-4">
    <label for="exampleInputName2">Passport number</label><input type="text" class="form-control" placeholder="" name="passport">
  </div>
  <div class="col-md-4">
    <label for="exampleInputName2">Issue place</label><input type="text" class="form-control" placeholder="" name="issue">
  </div>
                     <div class="row">
                         <div class="col-md-4">
    <label for="exampleInputName2">Date of issue(day/month/year)</label><input type="date" class="form-control" placeholder="" name="issuedate">
                        
  </div>
    <div class="col-md-4"> <label for="exampleInputName2">Date of expiration</label><input type="date" class="form-control" placeholder="" name="expirationdate"></div>                     
</div>
 
</div>
             <hr><hr>
                <h4>3- Emergecy data</h4>
                <div class="row">
  <div class="col-md-3">
    <label for="exampleInputName2">Person to be notified</label><input type="text" class="form-control" placeholder="" name="person">
  </div>
  <div class="col-md-3">
    <label for="exampleInputName2">Type of relation:&nbsp;</label>
<!--      <input type="text" class="form-control" placeholder="" name="relation">-->
      <select class="combobox" name="relation">
      <option value="Father">Father</option>
           <option value="Mother">Mother</option>
          <option value="Uncle">Uncle</option>
          <option value="Unit">Unit</option>
          <option value="Friend">Friend</option>
          <option value="sister">sister</option>
          <option value="Brother">Brother</option>
      
      </select>
  </div>
  <div class="col-md-3">
    <label for="exampleInputName2">Address</label><input type="text" class="form-control" placeholder="" name="Emergecyaddress">
      
  </div>
                   
 
                </div>
                <div class="row">
  <div class="col-md-3">
    <label for="exampleInputName2">City</label><input type="text" class="form-control" placeholder="" name="Emergecycity">
  </div>
  <div class="col-md-3">
    <label for="exampleInputName2">Postal code</label><input type="number" class="form-control" placeholder="" name="Emergecypostal">
  </div>
                    
                     <div class="col-md-3">
    <label for="exampleInputName2">Country</label><input type="text" class="form-control" placeholder="" name="Emergecycountry">
      
  </div> 
                    
</div>
                <div class="row">
                <div class="col-md-6">
      <label for="exampleInputName2">Telephone(country code,area code,number)</label>
      <div class="row">
  <div class="col-sm-8">
    <input type="text" class="form-control" placeholder="" name="Emergecytelephone">
                    </div>
                     </div>
                    </div> 
                </div>
  <div class="row">
     <div class="col-md-6">
        <label for="exampleInputName2">fax(country code,area code,number)</label>
      <div class="row">
  <div class="col-sm-8">
    <input type="text" class="form-control" placeholder="" name="Emergecyfax">
  </div>
    </div>
 </div> 
                 </div>
                <div class="row">
                     <div class="col-md-6">
        <label for="exampleInputName2">Mobile phone(country code,number)</label>
      <div class="row">
  <div class="col-sm-8">
    <input type="text" class="form-control" placeholder="" name="Emergecymobile">
                     </div>
                     </div>
                    </div> 
     
         </div>
                <div class="row">
                 <div class="col-md-4"><label for="exampleInputName2">E-mail</label><input type="email" class="form-control" placeholder="" name="Emergecyemail"></div>
                </div>
      <div class="row">
                <div class="col-md-4"></div>
            <div class="col-md-4">
     <a href=""><button class="btn btn-primary" type="submit" name="submit">Next</button></a></div>  
                </div> <br>
             <div class="row">
                <div class="col-md-4"></div>
            <div class="col-md-4">
     <a href=""><button class="btn btn-primary" type="reset" name="">Cancel</button></a></div>  
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

    <li class="active"><a href="student_enrolling.php">Form Page1</a></li>
    <li class="disabled"><a href="student_enrolling2.php">Form Page2</a></li>
    <li class="disabled"><a href="#">Form Page3</a></li>
    <li class="disabled"><a href="#">Form Page4</a></li>
    <li class="disabled"><a href="#">Form Page5</a></li>
    <li class="disabled"><a href="#">Form Page6</a></li>
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
<script type="text/javascript">
$(document).ready(function(){
    $('.combobox').combobox();
});
</script>

<?php include("inc/footer.php"); ?>