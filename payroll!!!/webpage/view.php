<!DOCTYPE html>
<html>
<head>
<title>Time Record</title>
<style>
table {
border-collapse: collapse;
width: 100%;
color: black;
font-family: monospace;
font-size: 25px;
text-align: left;
}
th {
background-color: #4682b4;
color: #191970;
}
tr {background-color: #f2f2f2}
h1 {
	color: #b4aba6;
	font-family: monospace;
	font-size:60px;
	border-radius: 5px;
	letter-spacing: 3px;
}
body {
	background-color: #191970;
}
</style>
</head>
<body>
<center> 
 <h1> Employee Time Records </h1>
</center>
<table>
<tr>
<th>Employee ID</th>
<th>Log Date</th>
<th>Time In</th>
<th>Before Status</th>
<th>Time Out</th>
<th>After Status</th>
<th>Hours Worked</th>
</tr>
<?php
$conn = mysqli_connect("localhost", "root", "", "payroll_database");
// Check connection
if ($conn->connect_error) {
die("Connection failed: " . $conn->connect_error);
}
$sql = "SELECT Employee_Id, Log_Date, Time_in, Before_Status, Time_Out, After_Status, Hrs_worked FROM time_record";
$result = $conn->query($sql);
if ($result->num_rows > 0) {
// output data of each row
while($row = $result->fetch_assoc()) {
echo "<tr><td>" . $row["Employee_Id"]. "</td><td>" . $row["Log_Date"] . "</td><td>" . $row["Time_in"]. "</td><td>" . $row["Before_Status"]. "</td><td>" . $row["Time_Out"]. "</td><td>". $row["After_Status"]. "</td><td>" . $row["Hrs_worked"]. "</td></tr>";
}
echo "</table>";
} else { echo "0 results"; }
$conn->close();
?>
</table>
</body>
</html>