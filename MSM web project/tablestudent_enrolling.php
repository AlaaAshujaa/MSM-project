<?php include("inc/header.php"); ?>
<div class="container">
         <div class="row">
              <div class="col-md-2"><img src="images/CBA-Logo-Converted.png"             style="width:120px;height:90px;"></div>
              <div class="col-md-5  ">
            <ol class="breadcrumb">
 <li><a href="admin.php">Admin</a></li>
  <li><a href="#">Student Enrolling</a></li>
</ol>
            </div>
            </div>
        </div>

<?php 
$stmt=$con->prepare("SELECT * FROM student");
$stmt->execute();
$rows=$stmt->fetchAll();
?>
<!-- Start table request course -->
        <h1 class="text-center">Student Enrolling</h1>
        <div class="container">
            <div class="table-responsive">
                <table class="main-table text-center table table-bordered">
                    <tr>
                        <td>Control</td>
                        <td>Student ID</td>
                       <td> M_F</td>
                        <td>first_name</td>
                         <td>middle_name</td>
                         <td>family_name</td>
                         <td>home_address</td>
                         <td>city</td>
                         <td>postal_code</td>
                         <td>country</td>
                        <td> home_telephone</td>
                        <td> home_fax</td>
                         <td>mobile_phone</td>
                         <td>personal_email</td>
                         <td>date_birth</td>
                         <td>place_birth</td>
                         <td>nationality</td>
                         <td>preferred_address</td>
                         <td>data_id</td>
                         <td>data_passport_num</td>
                         <td>data_issue_place</td>
                         <td>data_date_issue</td>
                         <td>data_date_expiration</td>
                         <td>emergency_person</td>
                         <td>emergency_type_relation</td>
                         <td>emergency_address</td>
                         <td>emergency_city</td>
                         <td>emergency_code</td>
                         <td>emergency_country</td>
                         <td>emergency_telephone</td>
                        <td> emergency_fax</td>
                         <td>emergency_mobile</td>
                        <td> emergency_email</td>
                    
                        <td> educational_highest</td> 
                       <td> educational_highest_other</td> 
                       <td> educational_list_academic</td> 
                        <td>educational_institute1</td> 
                        <td>educational_start_date1</td> 
                        <td>educational_finish_date1</td> 
                        <td>educational_degree1</td> 
                        <td>educational_majer1</td> 
                       <td> educational_institute2</td> 
                       <td> educational_start_date2</td> 
                        <td>educational_finish_date2</td> 
                        <td>educational_degree2</td> 
                        <td>educational_majer2</td> 
                        <td>educational_institute3</td> 
                        <td>educational_start_date3</td> 
                        <td>educational_finish_date3</td> 
                        <td>educational_degree3</td> 
                        <td>educational_majer3</td>
                        
                        <td>professional_name_org</td>
                        <td>professional_type_org</td>
                        <td>professional_business_add</td>
                        <td>professional_country</td>
                        <td>professional_city</td>
                        <td>professional_code</td>
                        <td>professional_telephone</td>
                        <td>professional_fax</td>
                        <td>professional_mobile</td>
                        <td>professional_email</td>
                        <td>professional_current_position</td>
                        <td>professional_position_since</td>	
                        <td>professional_description</td>
                        <td>professional_name_org1</td>
                        <td>professional_position_held1</td>
                        <td>professional_start_date1</td>
                        <td>professional_finish_date1</td>
                        <td>professional_description1</td>	
                        <td>professional_name_org2</td>
                        <td>professional_position_held2</td>
                        <td>professional_start_date2</td>
                       <td> professional_finish_date2</td>
                        <td>professional_description2</td>
                        <td>Professional_Society_memberships</td>
                        
                        <td>recommend_name</td>
                        <td>areas_account</td>
                        <td>areas_law</td>
                        <td>areas_ethics</td>
                        <td>areas_economic</td>
                        <td>areas_finance</td>
                        <td>areas_IB</td>
                        <td>areas_MIS</td>
                        <td>areas_market</td>
                        <td>areas_math</td>
                        <td>areas_operation</td>
                        <td>areas_org_behavior</td>
                        <td>areas_research_skill</td>
                        <td>areas_statistic</td>
                        <td>areas_strategy</td>
                        <td>areas_GMAT</td>
                        <td>areas_GMAT_yes_date</td>
                        <td>areas_GMAT_score</td>
                        <td>proficiency_oral</td>
                       <td> proficiency_written</td>
                        <td>proficiency_english_lang</td>
                        <td>proficiency_lang_yes_date</td>
                        <td>proficiency_lang_yes_score</td>
                        <td>proficiency_lang_other</td>
                        <td>proficiency_result</td>
                       <td> profes_obj_learning</td>
                        <td>profes_obj_expectation</td>
                        <td>profes_obj_AC</td>
                        <td>other_program</td>
                        <td>other_about_program</td>
                        <td>other_about_PA</td>
                        <td>other_about_other</td>
                        <td>Statement_date</td>
                    </tr>
                    <?php 
                    foreach($rows as $row){
                        
                        echo "<tr>";
                         echo "<td>
<a href='updatestudent_enrolling.php?do=updatestudent&userid=".$row['ID']."' class='btn btn-success'>Edit</a>
                            </td>";
                             echo "<td>". $row['student_id']."</td>";
                            echo "<td>". $row['first_name']."</td>";
                            echo "<td>". $row['middle_name']."</td>";
                            echo "<td>". $row['family_name']."</td>";
                            echo "<td>". $row['home_address']."</td>";
                            echo "<td>". $row['city']."</td>";
                            echo "<td>". $row['postal_code']."</td>";
                            echo "<td>". $row['country']."</td>";
                             echo "<td>". $row['home_telephone']."</td>";
                         echo "<td>". $row['home_fax']."</td>";
                         echo "<td>". $row['mobile_phone']."</td>";
                         echo "<td>". $row['personal_email']."</td>";
                         echo "<td>". $row['date_birth']."</td>";
                         echo "<td>". $row['place_birth']."</td>";
                         echo "<td>". $row['nationality']."</td>";
                         echo "<td>". $row['preferred_address']."</td>";
                         echo "<td>". $row['data_id']."</td>";
                        echo "<td>". $row['data_passport_num']."</td>";
                        echo "<td>". $row['data_issue_place']."</td>";
                        echo "<td>". $row['data_date_expiration']."</td>";
                        echo "<td>". $row['emergency_person']."</td>";
                        echo "<td>". $row['emergency_type_relation']."</td>";
                        echo "<td>". $row['emergency_address']."</td>";
                        echo "<td>". $row['emergency_city']."</td>";
                        echo "<td>". $row['emergency_code']."</td>";
                        echo "<td>". $row['emergency_country']."</td>";
                        echo "<td>". $row['emergency_telephone']."</td>";
                         echo "<td>". $row['emergency_fax']."</td>";
                         echo "<td>". $row['emergency_mobile']."</td>";
                         echo "<td>". $row['emergency_email']."</td>";
                        
                         echo "<td>". $row['educational_highest']."</td>";
                         echo "<td>". $row['educational_highest_other']."</td>";
                         echo "<td>". $row['educational_list_academic']."</td>";
                         echo "<td>". $row['educational_institute1']."</td>";
                         echo "<td>". $row['educational_start_date1']."</td>";
                         echo "<td>". $row['educational_finish_date1']."</td>";
                         echo "<td>". $row['educational_degree1']."</td>";
                         echo "<td>". $row['educational_majer1']."</td>";
                         echo "<td>". $row['educational_institute2']."</td>";
                         echo "<td>". $row['educational_start_date2']."</td>";
                         echo "<td>". $row['educational_finish_date2']."</td>";
                         echo "<td>". $row['educational_degree2']."</td>";
                        echo "<td>". $row['educational_majer2']."</td>";
                        echo "<td>". $row['educational_institute3']."</td>";
                        echo "<td>". $row['educational_start_date3']."</td>";
                        echo "<td>". $row['educational_finish_date3']."</td>";
                        echo "<td>". $row['educational_degree3']."</td>";
                        echo "<td>". $row['educational_majer3']."</td>";
                        
                        echo "<td>". $row['professional_name_org']."</td>";
                        echo "<td>". $row['professional_type_org']."</td>";
                        echo "<td>". $row['professional_business_add']."</td>";
                        echo "<td>". $row['professional_country']."</td>";
                        echo "<td>". $row['professional_city']."</td>";
                        echo "<td>". $row['professional_code']."</td>";
                        echo "<td>". $row['professional_telephone']."</td>";
                        echo "<td>". $row['professional_fax']."</td>";
                        echo "<td>". $row['professional_mobile']."</td>";
                        echo "<td>". $row['professional_email']."</td>";
                        echo "<td>". $row['professional_current_position']."</td>";
                        echo "<td>". $row['professional_position_since']."</td>";
                        echo "<td>". $row['professional_description']."</td>";
                        echo "<td>". $row['professional_name_org1']."</td>";
                        echo "<td>". $row['professional_position_held1']."</td>";
                        echo "<td>". $row['professional_start_date1']."</td>";
                        echo "<td>". $row['professional_finish_date1']."</td>";
                        echo "<td>". $row['professional_description1']."</td>";
                        echo "<td>". $row['professional_name_org2']."</td>";
                        echo "<td>". $row['professional_position_held2']."</td>";
                        echo "<td>". $row['professional_start_date2']."</td>";
                        echo "<td>". $row['professional_finish_date2']."</td>";
                        echo "<td>". $row['professional_description2']."</td>";
                        echo "<td>". $row['Professional_Society_memberships']."</td>";
                        echo "<td>". $row['recommend_name']."</td>";
                        
                        echo "<td>". $row['areas_account']."</td>";
                        echo "<td>". $row['areas_law']."</td>";
                        echo "<td>". $row['areas_ethics']."</td>";
                        echo "<td>". $row['areas_economic']."</td>";
                        echo "<td>". $row['areas_finance']."</td>";
                        echo "<td>". $row['areas_IB']."</td>";
                        echo "<td>". $row['areas_MIS']."</td>";
                        echo "<td>". $row['areas_market']."</td>";
                        echo "<td>". $row['areas_math']."</td>";
                        echo "<td>". $row['areas_operation']."</td>";
                        echo "<td>". $row['areas_org_behavior']."</td>";
                        echo "<td>". $row['areas_research_skill']."</td>";
                        echo "<td>". $row['areas_statistic']."</td>";
                        echo "<td>". $row['areas_strategy']."</td>";
                        echo "<td>". $row['areas_GMAT']."</td>";
                        echo "<td>". $row['areas_GMAT_yes_date']."</td>";
                        echo "<td>". $row['areas_GMAT_score']."</td>";
                        echo "<td>". $row['proficiency_oral']."</td>";
                           echo "<td>". $row['proficiency_written']."</td>";
                           echo "<td>". $row['proficiency_english_lang']."</td>";
                           echo "<td>". $row['proficiency_lang_yes_date']."</td>";
                           echo "<td>". $row['proficiency_lang_yes_score']."</td>";
                           echo "<td>". $row['proficiency_lang_other']."</td>";
                           echo "<td>". $row['proficiency_result']."</td>";
                           echo "<td>". $row['profes_obj_learning']."</td>";
                           echo "<td>". $row['profes_obj_expectation']."</td>";
                           echo "<td>". $row['profes_obj_AC']."</td>";
                           echo "<td>". $row['other_program']."</td>";
                           echo "<td>". $row['other_about_program']."</td>";
                              echo "<td>". $row['other_about_PA']."</td>";
                              echo "<td>". $row['other_about_other']."</td>";
                              echo "<td>". $row['Statement_date']."</td>";
                        
                        
                        
                        
                        
                           
                        echo "</tr>";
                    }
                    ?>
                    
                     
                </table>
            </div>
        </div>

<?php include("inc/footer.php"); ?>