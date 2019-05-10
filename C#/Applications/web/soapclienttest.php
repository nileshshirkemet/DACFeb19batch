<?php
	//c:\php\php.exe -S localhost:5000

	$svc = 'http://localhost:8056/shopping/Customer.svc?wsdl';
	$message = '';
	
	if(isset($_POST['submit']))
	{
		$client = new SoapClient($svc);
		$order = $client->Purchase($_POST)->PurchaseResult;

		if($order->Status)
			$message = sprintf("Payment is %.2f.\n", $order->Payment);
		else
			$message = "Not available!";
	}
?>

<html>
	<head>
		<title>SoapClientTest</title>
	</head>
	<body>
		<h1>Welcome Customer</h1>

		<form method="POST">
			<p>
				<b>Name of Item</b><br/>
				<input type="text" name="item" value="<?php echo $_POST['item']?>" />
			</p>
			<p>
				<b>Quantity to Purchase</b><br/>
				<input type="text" name="quantity" value="<?php echo $_POST['quantity']?>" />
			</p>
			<p>
				<input type="submit" name="submit" value="Purchase" />
			</p>
		</form>
		<i><?php echo $message?></i>
	</body>
</html>
