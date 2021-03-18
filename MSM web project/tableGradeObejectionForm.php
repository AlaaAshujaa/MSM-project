<?php include("inc/header.php"); ?>
<div class="container">
         <div class="row">
              <div class="col-md-2"><img src="images/CBA-Logo-Converted.png"             style="width:120px;height:90px;"></div>
              <div class="col-md-5  ">
            <ol class="breadcrumb">
 <li><a href="admin.php">Admin</a></li>
  <li><a href="#">Grade objection Form-MSM</a></li>
</ol>
            </div>
            </div>
        </div>

<?php 
$stmt=$con->prepare("SELECT * FROM grievance_msm");
$stmt->execute();
$rows=$stmt->fetchAll();
?>
<!-- Start table request course -->
        <h3 class="text-center">Grade objection Form to Examination &#44;Assignments ad Master Theses or final Project grades</h3>
        <div class="container">
            <div class="table-responsive">
                <table class="main-table text-center table table-bordered">
                    <tr>
                        <td>ID Number</td>
                        <td>Title</td>	
                        <td>Student Name</td>
                        <td>program_type</td>
                        <td>Intake_code</td>
                        <td>Institution_name</td>
                        <td>program_location</td>
                        <td>Course_name</td>
                        <td>lecturer_name</td>
                        <td>Assign_or_Exam</td>
                        <td>individual_or_Grop</td>
                        <td>grade_result</td>
                        <td>Project_Title</td>
                        <td>lecturer_name</td>
                        <td>Supervisor</td>
                        <td>Evaluator</td>
                        <td>Date</td>
                        <td>grade_project</td>
                        <td>BHAP_title</td>
                        <td>Coach</td>
                        <td>Evaluator_BHAP</td>
                        <td>date_BHAP</td>
                        <td>Question</td>
                        <td>Objection</td>
                        <td>Motivation</td>
                        <td>Declaration_date</td>
                        <td>Control</td>
                    </tr>
                    <?php 
                    foreach($rows as $row){
                        
                        echo "<tr>";
                            echo "<td>". $row['Unique_num']."</td>";
                            echo "<td>". $row['Title']."</td>";
                            echo "<td>". $row['student_name']."</td>";
                            echo "<td>". $row['program_type']."</td>";
                            echo "<td>". $row['Intake_code']."</td>";
                            echo "<td>". $row['Institution_name']."</td>";
                            echo "<td>". $row['program_location']."</td>";
                            echo "<td>". $row['Course_name']."</td>";
                            echo "<td>". $row['lecturer_name']."</td>";
                            echo "<td>". $row['Assign_or_Exam']."</td>";
                            echo "<td>". $row['ind_or_Grop']."</td>";
                            echo "<td>". $row['grade_result']."</td>";
                            echo "<td>". $row['Project_Title']."</td>";
                            echo "<td>". $row['lecturer_name']."</td>";
                            echo "<td>". $row['Supervisor']."</td>";
                            echo "<td>". $row['Evaluator']."</td>";
                            echo "<td>". $row['Date']."</td>";
                            echo "<td>". $row['grade_project']."</td>";
                            echo "<td>". $row['BHAP_title']."</td>";
                            echo "<td>". $row['Coach']."</td>";
                            echo "<td>". $row['Evaluator_BHAP']."</td>";
                            echo "<td>". $row['date_BHAP']."</td>";
                            echo "<td>". $row['Question']."</td>";
                            echo "<td>". $row['Objection']."</td>";
                            echo "<td>". $row['Motivation']."</td>";
                            echo "<td>". $row['Declaration_date']."</td>";
                          
                            echo "<td>
<a href='UpdateGradeObejectionForm.php?do=updatemsm&userid=".$row['code']."' class='btn btn-success'>Edit</a>
                            </td>";
                        echo "</tr>";
                    }
                    ?>
                    
                     
                </table>
            </div>
        </div>

<?php include("inc/footer.php"); ?>