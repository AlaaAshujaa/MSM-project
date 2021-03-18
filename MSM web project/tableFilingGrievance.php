<?php include("inc/header.php"); ?>
<div class="container">
         <div class="row">
              <div class="col-md-2"><img src="images/CBA-Logo-Converted.png"             style="width:120px;height:90px;"></div>
               <div class="col-md-5  ">
            <ol class="breadcrumb">
 <li><a href="admin.php">Admin</a></li>
  <li><a href="#">Filing Grievance-CBA</a></li>
</ol>
            </div>
            </div>
        </div>

<?php 
$stmt=$con->prepare("SELECT * FROM grievance_cba");
$stmt->execute();
$rows=$stmt->fetchAll();
?>
<!-- Start table request course -->
        <h1 class="text-center">Filing Grievance</h1>
        <div class="container">
            <div class="table-responsive">
                <table class="main-table text-center table table-bordered">
                    <tr>
                        <td>ID Number</td>
                        <td>Student Name</td>
                        <td>Intake</td>
                        <td>what Being Grieved</td>
                        <td>date occurrence</td>
                        <td>explanation grieved</td>
                        <td>reason grieved</td>
                        <td>date_filing</td>
                        <td>Control</td>
                    </tr>
                    <?php 
                    foreach($rows as $row){
                        
                        echo "<tr>";
                            echo "<td>". $row['Unqiue_num']."</td>";
                            echo "<td>". $row['student_name']."</td>";
                            echo "<td>". $row['Intake_code']."</td>";
                            echo "<td>". $row['what_BeingGrieved']."</td>";
                            echo "<td>". $row['date_occurrence']."</td>";
                            echo "<td>". $row['explanation_grieved']."</td>";
                            echo "<td>". $row['reason_grieved']."</td>";
                            echo "<td>". $row['date_filing']."</td>";
                            echo "<td>
<a href='UpdateFilingGrievance.php?do=updatecba&userid=".$row['ID']."' class='btn btn-success'>Edit</a>
                            </td>";
                        echo "</tr>";
                    }
                    ?>
                    
                     
                </table>
            </div>
        </div>

<?php include("inc/footer.php"); ?>