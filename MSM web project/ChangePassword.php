<?php include("inc/header.php");

?>

<div class="container">
       <div class="row">
              <div class="col-md-2"><img src="images/CBA-Logo-Converted.png"             style="width:120px;height:90px;"></div>
              <div class="col-md-5  ">
            <ol class="breadcrumb">
   <li><a href="login.php">Sign Up</a></li>
  <li><a href="ChangePassword.php">Change Password</a></li>
</ol>
            </div>
            
            </div> 
        </div>
<?php
$do='';
$do=isset($_GET['do'])?$_GET['do']:'login';
if($do=='Edit'){

$userid=isset($_GET['userid'])&& is_numeric($_GET['userid'])?intval($_GET['userid']):0;
       
$stmt=$con->prepare("SELECT * FROM users WHERE userID=? LIMIT 1");
    $stmt->execute(array($userid));
    $row=$stmt->fetch();    
    $count=$stmt->rowCount();
        if($stmt->rowCount()>0) {     
?>
<!-- start ChangePassword section-->

<h1 class="text-center">Change Password </h1>
<section class="log_in text-center">
    
    <div class="container-fluid text-center">
        <div class="row">
      <i class="fa fa-lock fa-5x"></i>
            
        <form role="form" action="?do=Update" method="post">
              <div class="col-md-4"></div>
             
             
            <div class="col-md-6">
            <div class="form-group">
            <input type="hidden" name="userid" value="<?php echo $userid?>"/>    
 <input class="form-control" type="email" placeholder="Email" name="email" value="<?php echo $row['email']?>">
            </div> 
        <div class="form-group">
             
            <input class="form-control " type="password" required="required" placeholder="Old Password" name="oldpass">
            <input class="form-control " type="password" required="required" placeholder="New Password" name="newpass">
            <input class="form-control " type="password" required="required" placeholder="Password confirmation" name="passconfrm">
            </div>
                 <button class="btn btn-primary btn-block">OK</button>
                  <button class="btn btn-primary btn-block" type="reset">Cancel</button>

            </div>
             <div class="col-md-2"></div>
    </div>
    </div>
</section>

<?php 
   }
}elseif($do=='Update'){
   echo "<h1 class='text-center'>Update Info </h1>" ;
   echo "<div class='contaier'>";
   echo "<div class='row'>";
   echo "<div class='col-md-12'>";     
    
    
    if($_SERVER['REQUEST_METHOD']=='POST'){
        if ($_POST["newpass"] == $_POST["passconfrm"])
        {
     @$id    =$_POST['userid'];
     @$email =$_POST['email'];
     @$oldPass =$_POST['oldpass'];
     @$newPass =sha1($_POST['newpass']);
     @$passcon =$_POST['passconfrm'];
        /*
         $formError=array();
            if(empty($email)){
                $formError[]='email can not be empty';
            }
            if(empty($oldPass)){
                $formError[]='old pass can not be empty';
            }
            if(empty($newPass)){
                $formError[]='new can not be empty';
            }
            if(empty($passcon)){
                $formError[]='confirm can not be empty';
            }
            foreach($formError as $error){
                echo $error.'<br>';
           }*/
       
    $stmt=$con->prepare("UPDATE users SET email=?,password=? WHERE userID=?");
       $stmt->execute(array($email,$newPass,$id));
 echo "<div class='alert alert-success text-center'><h4>".$stmt->rowCount().
   " record updated,Password Updated successfully</h4</div>";
    
    
        
}
else{
        
 echo"<h4 class='alert alert-danger text-center'><strong>The password is not match</strong></h4><br>";
    
    
   
    }  
}
    else{ 
echo" <h1 class='text-center'>There is no such id</h1>" ;
}

    echo "</div>"; 
    echo "</div>"; 
    echo "</div>"; 
   

}


include("inc/footer.php");
?>