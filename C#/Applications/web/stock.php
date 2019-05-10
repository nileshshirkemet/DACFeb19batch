<?php
	if(isset($_GET['symbol'])){
		header('Content-type:text/plain');
		$symbol = $_GET['symbol'];
		$symbols = array('APPL' => 'A', 'GOGL' => 'G', 'INTC' => 'I', 'MSFT' => 'M', 'ORCL' => 'O');
		if (array_key_exists($symbol, $symbols)) {
		    $price = rand(1000, 9000) / 100.0;
		    echo "Price is $price";
		}else{
			echo "Price not available";
		}
	}
?>


