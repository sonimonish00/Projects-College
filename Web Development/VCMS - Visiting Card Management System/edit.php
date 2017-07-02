<?php include("menubar.html") ?>

<?php
session_start();
if($_SESSION['s_email']==null)
{
    header("location:login.php");
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

<center>
<div >
  <div class="login-box">
  <div class="row">
  <div class="large-12 columns">
      <br>
<?php include("sidebar.php") ?>
<form method="post">
        <img src="img/logo.png" style="hight:75px; width:75px">
                        <h4>Edit Visiting Card</h4>
<table style="width:40%;">
    <?php
        include("connection.php");
        $u_email=$_SESSION['s_email'];
       // $pid=$_GET["pid"];
      $pid = $_COOKIE["pid"];
		//$sql = "";
		$sql = "SELECT * FROM person WHERE u_email = '$u_email' AND pid = '$pid'";
		$result = $conn->query($sql);
        $row = $result->fetch_assoc();
       
echo "    
<tr>
	<td align=\"center\">
		Person
		
		<div  class=\"row\">
        		<div class=\"large-12 columns\">
         			<input type=\"text\" name=\"name\" placeholder=\"Full Name\" value=".$row["name"]." />
         		</div>
		</div>     
		<div class=\"row\">
			<div class=\"large-12 columns\">
             			<input type=\"text\" name=\"designation\" placeholder=\"Designation\" value=".$row["designation"]." />
         		</div>
      		</div>
            
	        <div class=\"row\">
        		 <div class=\"large-12 columns\">
				<select name=\"company\">";
    	$sql1 = "SELECT * FROM company";
        echo "<option value=\"\">Select Company</option>";
		$result1 = $conn->query($sql1);
		if ($result1->num_rows > 0) {
		while($row1 = $result1->fetch_assoc()) 
		{
			echo "<option value='".$row1["cname"]."'>".$row1["cname"]."</option>";
    	}
		}
		else 
		{
    		echo "0 results";
		}
$conn->close();

    echo "
				</select>
         		 </div>
      		</div>
	       <div class=\"row\">
               		<div class=\"large-12 columns\">
             			<input type=\"text\" name=\"contact\" placeholder=\"Contact Number\" value=".$row["mobile"]." />
         		</div>
      		</div>
	        <div class=\"row\">
         		<div class=\"large-12 columns\">
		             <input type=\"text\" name=\"address\" placeholder=\"Address\" value=".$row["address"]." />
         		</div>
     		 </div>
	        <div class=\"row\">
         		<div class=\"large-12 columns\">
		             <input type=\"text\" name=\"email\" placeholder=\"Email ID\" value=".$row["emailid"]." />
         		</div>
     		 </div>
	        <div class=\"row\">
         		<div class=\"large-12 columns\">
		             <input type=\"text\" name=\"website\" placeholder=\"Website\" value=".$row["website"]." />
         		</div>
     		 </div>
   
		
	</td>
</tr>" ;
?>    
<tr>
<td style="background-color:#CCCCCC" align="center" colspan="2">
	<div style="margin-top:20px" class="row">
        		<div class="large-12 large-centered columns">
				
          			<input type="submit" class="button expand" value="Save" name="save"/>
        		</div>
		</div>	
</td>
</tr>
</table>        
        
        
    </form>
  </div>
</div>
                      

</div>

</div>
            </center>
    </body>

<?php
            
            if(isset($_POST['save']))
            { 
                include("connection.php");
               // $pid = $_GET["pid"];
                $pid = $_COOKIE["pid"]; 
                $email=$_SESSION['s_email'];
                $name=$_POST["name"];
                $designation=$_POST["designation"];
                $company=$_POST["company"];
                $mobile=$_POST["contact"];
                $address=$_POST["address"];
                $emailid=$_POST["email"];
                $website=$_POST["website"];
                $sql = "update person SET name='$name',designation='$designation',company='$company',mobile='$mobile',address='$address',emailid='$emailid',website='$website' where pid='$pid' AND u_email='$email'";
                //echo "<script>alert($sql)</script>";
                $result = $conn->query($sql) or trigger_error($conn->error."[$sql]");
                //echo "<script> location.replace(\"AddCard.php\"); </script>";
                header("Location: userprofile.php " );
                $conn->close();
            }
    ?>	
</html>