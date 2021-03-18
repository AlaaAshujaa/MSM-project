<?php include("inc/header.php"); ?>
<div class="container">
         <div class="row">
              <div class="col-md-2"><img src="images/CBA-Logo-Converted.png"             style="width:120px;height:90px;"></div>
             <div class="col-md-5  ">
            <ol class="breadcrumb">
 <li><a href="admin.php">Admin</a></li>
  <li><a href="#">Course Retake Request</a></li>
</ol>
            </div>
            </div>
        </div>

<?php 
$stmt=$con->prepare("SELECT * FROM request_course");
$stmt->execute();
$rows=$stmt->fetchAll();
?>
<!-- Start table request course -->
        <h1 class="text-center">Course Retake Request</h1>
        <div class="container">
            <div class="table-responsive">
                <table class="main-table text-center table table-bordered">
                    <tr>
                        <td>ID Number</td>
                        <td>Student Name</td>
                        <td>Intake</td>
                        <td>Course to be retaken</td>
                        <td>Segment take in</td>
                        <td>Date</td>
                        <td>Date when originally taken</td>
                        <td>Retake Intake</td>
                        <td>Absence Reason</td>
                        <td>Control</td>
                    </tr>
                    <?php 
                    foreach($rows as $row){
                        
                        echo "<tr>";
                            echo "<td>". $row['Unique_num']."</td>";
                            echo "<td>". $row['student_name']."</td>";
                            echo "<td>". $row['Intake_code']."</td>";
                            echo "<td>". $row['course_name']."</td>";
                            echo "<td>". $row['segment_taken']."</td>";
                            echo "<td>". $row['data']."</td>";
                            echo "<td>". $row['originally_taken']."</td>";
                            echo "<td>". $row['retake_intake']."</td>";
                            echo "<td>". $row['Reason']."</td>";
                            echo "<td>
<a href='updatecourseRetake.php?do=updatecourseRetake&userid=".$row['code']."' class='btn btn-success'>Edit</a>
                            </td>";
                        echo "</tr>";
                    }
                    ?>
                    
                     
                </table>
            </div>
        </div>

<?php include("inc/footer.php"); ?>