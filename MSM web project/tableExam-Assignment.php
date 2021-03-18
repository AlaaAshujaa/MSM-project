<?php include("inc/header.php"); ?>
<div class="container">
         <div class="row">
              <div class="col-md-2"><img src="images/CBA-Logo-Converted.png"             style="width:120px;height:90px;"></div>
             <div class="col-md-5  ">
            <ol class="breadcrumb">
 <li><a href="admin.php">Admin</a></li>
  <li><a href="#">Exam-Assignment Deferment Request</a></li>
</ol>
            </div>
            </div>
        </div>

<?php 
$stmt=$con->prepare("SELECT * FROM request_exam");
$stmt->execute();
$rows=$stmt->fetchAll();
?>
<!-- Start table request course -->
        <h1 class="text-center">Exam-Assignment Deferment Request</h1>
        <div class="container">
            <div class="table-responsive">
                <table class="main-table text-center table table-bordered">
                    <tr>
                        <td>ID Number</td>
                        <td>Student Name</td>
                        <td>Intake</td>
                        <td>Course title</td>
                        <td>Assignment</td>
                        <td>Exam</td>
                        <td>reason request</td>
                        <td>other reason</td>
                        <td>Have you deferred previously exam</td>
                        <td>name course</td>
                        <td> date</td>
                        <td>Control</td>
                    </tr>
                    <?php 
                    foreach($rows as $row){
                        
                        echo "<tr>";
                            echo "<td>". $row['Unique_num']."</td>";
                            echo "<td>". $row['student_name']."</td>";
                            echo "<td>". $row['Intake_code']."</td>";
                            echo "<td>". $row['course_name']."</td>";
                            echo "<td>". $row['assignment']."</td>";
                            echo "<td>". $row['final_exam']."</td>";
                            echo "<td>". $row['reason_request']."</td>";
                            echo "<td>". $row['other_reson']."</td>";
                            echo "<td>". $row['previously_exam']."</td>";
                            echo "<td>". $row['name_course']."</td>";
                            echo "<td>". $row['date']."</td>";
                            echo "<td>
<a href='UpdateExam-Assignment.php?do=updateDefermentRequest&userid=".$row['code']."' class='btn btn-success'>Edit</a>
                            </td>";
                        echo "</tr>";
                    }
                    ?>
                    
                     
                </table>
            </div>
        </div>

<?php include("inc/footer.php"); ?>