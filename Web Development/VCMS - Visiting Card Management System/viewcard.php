<?php
session_start();
if($_SESSION['s_email']==null)
{
    header("Location: login.php");
}
?>

<!doctype html>
<html class="no-js" lang="en">
<head>
<meta charset="utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1.0"/>
<title>VCMS | Welcome</title>
<link rel="stylesheet" href="css/foundation.min.css">
</head>
<body>
    <?php include("menubar.html") ?>
    <div class="off-canvas-wrapper">
<div class="off-canvas-wrapper-inner" data-off-canvas-wrapper>
    
    
        // ahiya thi lai ne
<?php include("sidebar.php") ?>
<div class="off-canvas-content" data-off-canvas-content>
<div class="title-bar hide-for-large">
<div class="title-bar-left">
<button class="menu-icon" type="button" data-open="my-info"></button>
<span class="title-bar-title">VCMS</span>
</div>
</div>
<div class="callout primary">
<div class="row column">
<h3>View Profile</h3>
</div>
</div>
    <div class="row small-up-2 medium-up-3 large-up-4">
    <?php
        include("connection.php");
		
        $x = $_COOKIE["pid"];
  
		$sql = "SELECT * FROM person where pid=".$x;
		$result = $conn->query($sql);
$row = $result->fetch_assoc();
    $name = $row["name"];
            $designation = $row["designation"];
            $company = $row["company"];
            $mobile = $row["mobile"];
            $address = $row["address"];
            $emailid = $row["emailid"];
            $website = $row["website"];
             $image = $row["image"];
            
// output data of each row
		echo "<center><table>";
        echo "<tr><td rowspan=7 style=\"width:400px\"> <img style=\" width:400px;\"; src=\"".$image."\" /></td>";
        echo " <td>Name :</td><td>".$name."</td></tr>";
        echo "<tr><td>Designation :</td>  <td>".$designation."</td></tr>";
        echo "<tr><td>Company :</td>  <td>".$company."</td></tr>";
        echo "<tr><td>mobile :</td>  <td>".$mobile."</td></tr>";
        echo "<tr><td>Address :</td>  <td>".$address."</td></tr>";
        echo "<tr><td>Email Id :</td>  <td>".$emailid."</td></tr>";
        echo "<tr><td>Website :</td>  <td>".$website."</td></tr>";
        echo "<tr><td colspan=3><center><a href=\"edit.php\" class=\"button\" >Edit Card</a></center></td></td></tr>";
        echo "</center></table>";
    
   
   //     }
		
$conn->close();
      
    ?>

</div>
<hr>
</div>
</div>
</div>
<script src="js/jquery-2.1.4.min.js"></script>
<script src="js/foundation.js"></script>
<script>
      $(document).foundation();
    </script>
</body>
    <script>

    function f1(x)
        {
             window.location.href = "viewcard.php?name="+x;
        }
    </script>
</html>
