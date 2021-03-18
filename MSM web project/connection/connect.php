<?php 

$dsn='mysql:host=localhost;dbname=MSM';
$user='root';
$pass='';
$option= array(
    PDO::MYSQL_ATTR_INIT_COMMAND =>'SET NAMES utf8',
);
try{
    
    $con=new PDO($dsn,$user,$pass,$option);
    $con->setAttribute(PDO::ATTR_ERRMODE,PDO::ERRMODE_EXCEPTION);
}
catch(PDOException $e){
    
    echo'failed' . $e->getMessage();
}

//$servername="MARWA\SQLEXPRESS";
//$databaseName="MSM";
//$connectionInfo=array("Database"=>$databaseName);
//$conn=sqlsrv_connect($servername,$connectionInfo);
//
//if($conn){
//    
//    echo "connection established";
//}
//else{echo "connection cannot established";
//    die(print_r(sqlsrv_errors(),true));
//     
//     
//    }
//sqlsrv_close($conn);
?>