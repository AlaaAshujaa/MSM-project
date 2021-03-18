<?php include("inc/header.php");
?>
<?php
$myemail = "comments@myemail.com";
$errors  = array();
$values  = array();
$errmsg  = '';
   @$formsError=array();
        if(isset($_POST['email'])){
            
            $Filterduser=filter_var($_POST['email'],FILTER_SANITIZE_EMAIL);
            if(filter_var($Filterduser,FILTER_VALIDATE_EMAIL)!=true){
                
               $formsError[]='this email is not valid'; 
            }
        
            
        }

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    foreach($_POST as $key => $value) {
        $values[$key] = trim(stripslashes($value));} // basic input filter
        if (check_input($values['email']) == false) {
        $errors['email'] = 'Please enter your email address.';
    } else if (!preg_match('/([\w\-]+\@[\w\-]+\.[\w\-]+)/', $values['email'])) {
        $errors['email'] = 'Invalid email address format.';
    }
    if (check_input($values['password']) == false) {
        $errors['password'] = 'Please enter your password.';}
   
    if (sizeof($errors) == 0) {
    

        
    $Email=$_POST['email'];
   $Password=$_POST['password'];
  $hashedpass=sha1($Password); 
        
    
    $stmt=$con->prepare("SELECT userID,email,password FROM users WHERE email=? AND password=? LIMIT 1");
    $stmt->execute(array($Email,$hashedpass));
    $row=$stmt->fetch();    
    $count=$stmt->rowCount();
    if($count>0){
        
        $_SESSION['email']=$Email;
        $_SESSION['ID']=$row['userID'];
        $id=$_SESSION['ID'];
header("location:icons.php?do=icons&userid=$id");
        $_SESSION['email'] = $_POST['email'];
        $_SESSION['password'] =$_POST['password'];
      exit();
           
     
    }
    else{
echo
    "<h4 style='color: red;' align='center'><b></b><br />invalid email or password<h4>";
        
    }

?>

<?php
}else{
        // one or more errors
        foreach($errors as $error) {
            $errmsg .= $error . '<br />';
        }
    }
    }
        function check_input($input) {
    if (strlen($input) == 0) {
        return false;
    } else {
        // TODO: other checks?

        return true;
    }
}
?>


<div class="container">
         <div class="row">
              <div class="col-md-2"><img src="images/CBA-Logo-Converted.png"             style="width:120px;height:90px;"></div>
              <div class="col-md-5  ">
            <ol class="breadcrumb">
  <li><a href="Home.php"></a></li>
 
</ol>
            </div>
           
            </div>
        </div>
<!--start login -->


	
<h1 class="text-center">Sign Up Now </h1>
<section class="log_in text-center">
    
    <div class="container-fluid text-center">
        <div class="row">
      <i class="fa fa-user-circle fa-5x"></i>
           
<?php if ($errmsg != ''): ?>
 <p style="color: red;" align="center" ><b></b><br />
 <?php echo $errmsg; ?>
 </p>
 <?php endif; ?>  
             
        <form role="form" action="<?php $_SERVER['PHP_SELF'] ?>" method="post">
              <div class="col-md-4"></div>
             
            <div class="col-md-6">
            <div class="form-group">
                <input class="form-control" type="email" placeholder="Email" name="email">
            </div> 
        <div class="form-group">
             
       <input class="form-control " type="password" placeholder="Password" name="password" autocomplete="new-password">
          
            </div>
                 <button class="btn btn-primary btn-block">Sign up</button><br>
                  <a href="index.php"><button class="btn btn-primary btn-block" type="reset">Cancel</button></a>
               
            </div>
             <div class="col-md-2"></div>
         
        </form>
        
    </div>
    </div>
</section>
     <?php /*} */?>
 <!--footer-->       
<?php include("inc/footer.php");?>  