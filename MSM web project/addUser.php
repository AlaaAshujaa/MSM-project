<?php include("inc/header.php"); ?>

    <div class="container">
        <div class="row">
            <div class="col-md-2"><img src="images/CBA-Logo-Converted.png" style="width:120px;height:90px;"></div>
        </div>
    </div>

<?php

if (isset($_POST['submit'])) {

    @$Email = $_POST['email'];
    @$Password = $_POST['password'];

    $stmt = $con->prepare("SELECT ID FROM student WHERE student_id='$Password'");
    $stmt->execute();
    $rows = $stmt->fetch();
    $count = $stmt->rowCount();
    if ($count > 0) {
        echo $count;
        $id = $rows['ID'];
    }
    @$Password = sha1($_POST['password']);

    $stmt = $con->prepare("INSERT INTO users(userID,email,password) VALUES('$id','$Email','$Password')");
    $stmt->execute(array($Email, $Password));

    echo "<h4 style=\"color: green;\" align=\"center\" class='alert alert-success'>
<i class='fa fa-thumbs-up'></i><br>Add user done successfully</h4> ";


}
?>
    <!--start Add user section-->

    <h1 class="text-center">Add New User</h1>
    <section class="login_table text-center">
        <div class="fields">
            <div class="container-fluid text-center">
                <div class="row">
                    <i class="fa fa-user fa-5x"></i>


                    <form role="form" action="<?php $_SERVER['PHP_SELF'] ?>" method="post">
                        <div class="col-md-4"></div>

                        <div class="col-md-6">
                            <div class="form-group">
                                <input class="form-control" type="email" placeholder="Email of Student" name="email"
                                       required="required">
                            </div>
                            <div class="form-group">

                                <input class="form-control " type="password" placeholder="Password As ID of Student"
                                       name="password" autocomplete="new-password" required="required">

                            </div>
                            <button class="btn btn-primary btn-block" name="submit" type="submit"><i
                                        class="fa fa-plus"></i>&nbsp;Add User
                            </button>
                            <br>

                        </div>
                        <div class="col-md-2"></div>

                    </form>

                </div>
            </div>
        </div>
    </section>

<?php include("inc/footer.php"); ?>