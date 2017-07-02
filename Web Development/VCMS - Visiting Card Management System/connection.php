<?php
$servername = "127.0.0.1";
$username = "root";
$password = "";
// Create connection
$conn = new mysqli($servername, $username, $password); 
mysqli_select_db($conn,"vcms");

//if($conn==null)
//{
//    die("Connection failed: ");
//}  
//echo "Connected successfully";
?> 