<?php include("menubar-login.html") ?>

<?php
    if(isset($_POST['signup']))
    {
        if(isset($_FILES['fileToUpload']) && !empty($_FILES['fileToUpload']['tmp_name']))
        {
            echo "<script>alert(\"You are here\");</script>";
            $target_dir = "Uploads/";
            $target_file = $target_dir."profile_".$_POST["emailid"]. basename($_FILES["fileToUpload"]["name"]); 
            $uploadOk = 1;
            $imageFileType = pathinfo($target_file,PATHINFO_EXTENSION); // Check if image file is a actual image or fake image
            $check = getimagesize($_FILES["fileToUpload"]["tmp_name"]); 
            if($check !== false)
            {
                echo "File is an image - " . $check["mime"] . ".";  
                $uploadOk = 1; 
            }
            else
            {
                echo "File is not an image.";   
                $uploadOk = 0; 
            }

           
            
            if ($uploadOk == 0)
            {
                echo "Sorry, your file was not uploaded."; // if everything is ok, try to upload file
            } 
            else
            {
                if (move_uploaded_file($_FILES["fileToUpload"]["tmp_name"], $target_file))
                {
                    $path=$target_dir."profile_".$_POST["emailid"]. basename($_FILES["fileToUpload"]["name"]);
                }
                else 
                {
                    echo "Sorry, there was an error uploading your file.";   
                }
            }                      
        }
        else
        {
                        echo "<script>alert(\"You are here in else\");</script>";
             $path="img/logo.png";
        }
    
    include("connection.php");
    $name = $_POST["name"];
    $mobile = $_POST["mobile"];
    $emailid = $_POST["emailid"];
    $password = $_POST["password"];
	 $sql="INSERT INTO user (`name`,`image`, `mobile`, `emailid`, `password`) VALUES ('$name','$path','$mobile','$emailid','$password');";
	 $conn->query($sql) or  trigger_error($conn->error."[$sql]"); 
	echo "<script type= 'text/javascript'>alert('Account Created Successfully');</script>";
   // header("Location: login.php");
	$conn->close();
    }

?>    
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
  margin: 20px 0;
  padding: 20px 20px 0 20px;
}
    
</style>
    <body>
                
<center><h3>Welcome To Awosme Visiting Card Managment System !</h3></center>
<center>
<div class="large-3 large-centered columns">
  <div class="login-box">
  <div class="row">
  <div class="large-12 columns">
    <form action="" method="post" enctype="multipart/form-data" multiple accept='image/*|audio/*|video/*'>
        <img src="img/logo.png" style="hight:75px; width:75px">
                        <h4>Sign Up Here</h4>
        
         <div class="row">
         <div class="large-12 columns">
             <input type="text" name="name" placeholder="Full Name" />
         </div>
      </div>
        
        <div class="row">
         <div class="large-12 columns">
             <input type="text" name="emailid" placeholder="Email Id" />
         </div>
      </div>
        
        <div class="row">
         <div class="large-12 columns">
             <input type="text" name="mobile" placeholder="Mobile Number" />
         </div>
      </div>
        
      <div class="row">
         <div class="large-12 columns">
             <input type="password" name="password" placeholder=" New Password" />
         </div>
      </div>
        <div class="row">
         <div class="large-12 columns">
             <input type="password" name="con_password" placeholder="Confirm New Password" />
         </div>
      </div>
        <div class="row">
         <div class="large-12 columns">
             <input type="file" name="fileToUpload" id="fileToUpload">
         </div>
      </div>
        
      <div class="row">
        <div class="large-12 large-centered columns">
          <input type="submit" class="button expand" name="signup" value="Sign Up"/>
        </div>
          
      </div>
    </form>
  </div>
</div>
                      <p>Already Have Account,<br><a href="login.php">Login Here >></a></p>

</div>

</div>
            </center>
        

    </body>
</html>

