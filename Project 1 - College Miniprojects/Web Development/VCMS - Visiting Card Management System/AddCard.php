<?php
session_start();
if($_SESSION['s_email']==null)
{
    header("Location: login.php");
}

?>

<!DOCTYPE html>
    <head>
    <title>Visiting Card Management System</title>
        
        <link href="css/app.css" rel="stylesheet" type="text/css" />
        <link href="css/foundation-flex.css" rel="stylesheet" type="text/css" />
        <link href="css/foundation-rtl.css" rel="stylesheet" type="text/css" />
        <link href="css/foundation.css" rel="stylesheet" type="text/css" />
        <link href="css/foundation.min.css" rel="stylesheet" type="text/css" />

    </head>
<script>
</script>	
    <style>
    ::-webkit-input-placeholder
	{
		color:black;
	}
body {
  background: #F0F0F3;
}
.login-box {
  background: #fff;
  border: 1px solid #ddd; 
  
  margin-bottom:10px;
margin-left:10px;
margin-right:10px;
margin-up:10px;
  width:70%;
}
    
</style>
    <body>

<?php include("menubar.html"); ?>
<center>
<div >
  <div class="login-box">
  <div class="row">
  <div class="large-12 columns">
<?php include("sidebar.php"); ?>

        <img src="img/logo.png" style="hight:75px; width:75px">
                        <h4>Add Visiting Card</h4>
<table style="width:70%;">    
<tr>
<form action="" method="post" enctype="multipart/form-data" multiple accept='image/*|audio/*|video/*'>
	<td align="center" style="width:200px;">
		Person
		<div  class="row">
        		<div class="large-12 columns">
         			<input type="text" name="name" placeholder="Full Name" />
         		</div>
		</div>     
		<div class="row">
			<div class="large-12 columns">
             			<input type="text" name="designation" placeholder="Designation" />
         		</div>
      		</div>
	        <div class="row">
        		 <div class="large-12 columns">
				<select name="company">
					<option value=''>Select Company</option>
<?php
		include("connection.php");
		//$sql = "";
		$sql = "SELECT * FROM company";
		$result = $conn->query($sql);
		if ($result->num_rows > 0) {
		while($row = $result->fetch_assoc()) 
		{
			echo "<option value='".$row["cname"]."'>".$row["cname"]."</option>";
    	}
		}
		else 
		{
    		echo "0 results";
		}
$conn->close();
?>
				</select>
         		 </div>
      		</div>
	       <div class="row">
               		<div class="large-12 columns">
             			<input type="text" name="contact" placeholder="Contact Number" />
         		</div>
      		</div>
	        <div class="row">
         		<div class="large-12 columns">
		             <input type="text" name="address" placeholder="Address" />
         		</div>
     		 </div>
	        <div class="row">
         		<div class="large-12 columns">
		             <input type="text" name="email" placeholder="Email ID" />
         		</div>
     		 </div>
	        <div class="row">
         		<div class="large-12 columns">
		             <input type="text" name="website" placeholder="Website" />
         		</div>
     		 </div>
   <div class="row">
         		<div class="large-12 columns">
		              Upload Image<input type="file" name="fileToUpload" id="fileToUpload">
         		</div>
     		 </div>
		
		<div class="row">
        		<div class="large-12 large-centered columns">
				<br>
          			<input name="save" type="submit" class="button expand" value="Save"/>
        		</div>
		</div>
</form>
        <?php
   if(isset($_POST['save']))
   { 
        if(!empty($_FILES["fileToUpload"]["tmp_name"]))
        {
            $target_dir = "Uploads/";
            $target_file = $target_dir."Card_".$_SESSION['s_email']. basename($_FILES["fileToUpload"]["name"]); 
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
                $uploadOk = 1; 
            }

           if ($_FILES["fileToUpload"]["size"] > 3000000) 
            {
                echo "Sorry, your file is too large.";   
                $uploadOk = 0; 
            }
            if($imageFileType != "jpg" && $imageFileType != "png" && $imageFileType != "jpeg" && $imageFileType != "gif" )
            {
                echo "Sorry, only JPG, JPEG, PNG & GIF files are allowed.";   
                $target_file="img/c1.jpg";
                $uploadOk = 1; 
            }
            if ($uploadOk == 0)
            {
                echo "Sorry, your file was not uploaded."; // if everything is ok, try to upload file
            } 
            else
            {
                if (move_uploaded_file($_FILES["fileToUpload"]["tmp_name"], $target_file))
                {
                    $path=$target_dir."Card_".$_SESSION['s_email']. basename($_FILES["fileToUpload"]["name"]);
                }
                else 
                {
                    echo "Sorry, there was an error uploading your file.";   
                }
            }                      
        }
        else
        {
             $path="img/c1.jpg";
        }
        include("connection.php");
        $s_email = $_SESSION['s_email'];
        $name=$_POST["name"];
        $designation=$_POST["designation"];
        $company=$_POST["company"];
        $mobile=$_POST["contact"];
        $address=$_POST["address"];
        $emailid=$_POST["email"];
        $website=$_POST["website"];
        $sql = "INSERT INTO person (image,name,designation,company,mobile,address,emailid,website,u_email) VALUES ('$path','$name','$designation','$company',' $mobile','$address','$emailid','$website','$s_email');";
        //echo "<script>alert($sql)</script>";
        $result = $conn->query($sql) or trigger_error($conn->error."[$sql]");;
        //echo "<script> location.replace(\"AddCard.php\"); </script>";

   }
    ?>		
	</td>

<form method="post">
	<td align="center" style="width:200px;">
		Company Details
		
		<div class="row">
        		<div class="large-12 columns">
         			<input id="id_row1" type="text" name="company_name" placeholder="Company Name" />
         		</div>
		</div>     
		<div class="row">
			<div class="large-12 columns">
             			<input id="id_row2" type="text" name="Business_Type" placeholder="Business Type" />
         		</div>
      		</div>
	        <div class="row">
        		 <div class="large-12 columns">
             			<input id="id_row3" type="text" name="city" placeholder="City" />
         		 </div>
      		</div>
	       <div class="row">
               		<div class="large-12 columns">
             			<input id="id_row4" type="text" name="state" placeholder="State" />
         		</div>
      		</div>
	        <div class="row">
         		<div class="large-12 columns">
		             <input id="id_row5" type="text" name="country" placeholder="Country" />
         		</div>
     		 </div>
	        <div class="row">
         		<div class="large-12 columns">
		             <input id="id_row6" type="text" name="Zip_Code" placeholder="Zip Code" />
         		</div>
     		 </div>
		<div class="row">
        		<div style="height:140px" class="large-12 large-centered columns">          			
        		</div>
		</div>
		<div id="BtnAdd" class="row">
        		<div class="large-12 large-centered columns">
          			<input name="add" type="submit" class="button expand" value="Add"/>
        		</div>
		</div>
</form>
        <?php
            
            if(isset($_POST['add']))
            {
              
                include("connection.php");
                $cname=$_POST["company_name"];
                $btype=$_POST["Business_Type"];
                $city=$_POST["city"];
                $state=$_POST["state"];
                $country=$_POST["country"];
                $zip=$_POST["Zip_Code"];
                $sql = "INSERT INTO company (cname,btype,city,state,country,zip) VALUES ('$cname','$btype','$city','$state','$country','$zip');";
                //echo "<script>alert($sql)</script>";
                $result = $conn->query($sql);
                echo "<script> location.replace(\"AddCard.php\"); </script>";
            }
            
               
        ?>	
</td>
</tr>
</table>        
  </div>
</div>
                      

</div>

</div>
            </center>
    </body>
</html>