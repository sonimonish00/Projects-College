<html>
<body>
    
    <img src="6otu Parth.PNG" id="card" class="p1" onclick="f1('p1')">
    <img src="6otu Parth.PNG" id="card"  class="p2" onclick="f1('p2')">
    <?php
		//include 'connection.php';
		//$conn = new mysqli("127.0.0.1","root" ,"1234");
		//mysqli_select_db($conn,"vcms");
		//$sql = "";
		//$sql = "SELECT * FROM user";
		//$result = 10;
		$x = 1;
		while($x <= 5) 
		{
    		echo "<img onclick=\"f1(".$x.")\" name=\"card\" id=\"PID001\" src=\"6otu Parth.PNG\" style=\"width:200px;height:500px;\" />&nbsp;&nbsp;&nbsp;";
    		$x++;
		}
?>
    </body>
<script>
function f1(x)
    {
        window.location.href = "profile.php?name="+x;
            alert(x);
    }
    </script>
</html>