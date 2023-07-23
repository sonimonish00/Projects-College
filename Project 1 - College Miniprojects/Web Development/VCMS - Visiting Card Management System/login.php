<?php include("menubar-login.html") ?>

<html>
    <head>
    <title>Visiting Card Management System</title>
        
        <link href="css/app.css" rel="stylesheet" type="text/css" />
        <link href="css/foundation-flex.css" rel="stylesheet" type="text/css" />
        <link href="css/foundation-rtl.css" rel="stylesheet" type="text/css" />
        <link href="css/foundation.css" rel="stylesheet" type="text/css" />
        <link href="css/foundation.min.css" rel="stylesheet" type="text/css" />

    </head>
    
    <style>
    
body {
  background: #F0F0F3;
}
.login-box {
  background: #fff;
  border: 1px solid #ddd; 
  margin: 100px 0;
  padding: 20px 20px 20px 20px;
}
    
</style>
    <body>
                
<center><h3>Welcome To Awosme Visiting Card Managment System !</h3></center>
<center>
<div class="large-3 large-centered columns">
  <div class="login-box">
  <div class="row">
  <div class="large-12 columns">
    <form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post">
        <img src="img/logo.png" style="hight:80px; width:80px"><br><br>
                        <h4<?php echo $_SERVER['PHP_SELF']; ?>Login Here</h4>
       <div class="row">
         <div class="large-12 columns">
             <input type="text" name="emailid" placeholder="Email Id" />
         </div>
       </div>
      <div class="row">
         <div class="large-12 columns">
             <input type="password" name="password" placeholder="Password" />
         </div>
      </div>
      <div class="row">
        <div class="large-12 large-centered columns">
          <input type="submit" class="button expand" name="login" value="Log In"/>
        </div>
          
      </div>
    </form>
  </div>
</div>
                      <p>Haven't Created Account Yet,<br><a href="signup.php">Create one Here >></a></p>

</div>

</div>
            </center>
    </body>
    <?php
    
    if(isset($_POST['login']))
    {
    include("connection.php");
    $emailid = $_POST["emailid"];
    $password = $_POST["password"];
		$sql = "SELECT * FROM user where emailid = '$emailid' and password = '$password' ";
        $result = $conn->query($sql) or trigger_error($conn->error."[$sql]");
        $row = $result->fetch_array(MYSQLI_ASSOC);
        $email = $row["emailid"];
        if($email!=null)
        {
            session_start();
            $_SESSION['s_email']=$email;
            header("Location: userprofile.php");
        }
        else
        {
            echo "<center>Wrong Username or Password</center>";
        }
    }

    ?>
</html>