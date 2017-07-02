<?php
session_start();
unset($_SESSION['s_email']);
$_COOKIE["pid"]=" ";
session_destroy();
header("Location: login.php");
?>