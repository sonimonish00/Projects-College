<?php
		//include 'connection.php';
		$conn = new mysqli("127.0.0.1","root" ,"1234");
		mysqli_select_db($conn,"vcms");
		//$sql = "";
		$sql = "SELECT * FROM user";
		$result = $conn->query($sql);
		if ($result->num_rows > 0) {
// output data of each row
		echo "<table border='1'>";
		echo "<tr><td>Name</td><td>Mobile No</td><td>Email Id</td></tr>";
		
		while($row = $result->fetch_assoc()) 
		{
		echo "<tr>";
			echo "<td>".$row["name"]."</td><td>".$row["mobile"]."</td><td>".$row["emailid"]."</td></tr>";
//			echo "name: " . $row["name"]. " - Mobile: " . $row["mobile"]. " " . $row["emailid"]. "<br>";
    	}
		echo"</tr></table>";
		}
		else 
		{
    		echo "0 results";
		}
$conn->close();
?>
<!--<script type="text/javascript">
    var xdata = <?php echo json_encode($xdata); ?>;

    alert(xdata['foo']);
    alert(xdata['baz'][0]);

    // Dot notation can be used if key/name is simple:
    alert(xdata.foo);
    alert(xdata.baz[0]);
</script>-->