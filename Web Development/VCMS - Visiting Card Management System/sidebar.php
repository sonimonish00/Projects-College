<div class="off-canvas position-left reveal-for-large" id="my-info" data-off-canvas data-position="left" style="height:100%">

<div class="row column" >

<br>
    <?php
        $emailid = $_SESSION['s_email'];
        include("connection.php");
		$sql = "SELECT * FROM user where emailid= '$emailid' ";
		$result = $conn->query($sql);
	
        while($row = $result->fetch_assoc())
        {
                echo "<div class=\"column\">
                <img style=\"height:150px; width:160px;\"; class=\"thumbnail\" src=\"".$row["image"]."\" \"></div>";
                echo "<h5>Name: ".$row["name"]."</h5>";
                echo "<p>Email:".$row["emailid"]."</p>";
                echo "<p>Mobile:".$row["mobile"]."</p>";
        }
    
    ?>
<!--<img class="thumbnail" src="img/profilepic.jpg">-->

</div>
</div>