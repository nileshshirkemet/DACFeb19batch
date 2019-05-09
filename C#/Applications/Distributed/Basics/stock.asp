<%
	Function Rand(Low, High)
  		Rand = Int((High - Low + 1) * Rnd) + Low
	End Function

	Function InArray(Element, Elements)
		Dim entry
		For Each entry In Elements
			If entry = Element Then
				InArray = True
				Exit For
			End If
		Next
	End Function

	Dim symbols, symbol

	symbols = Array("APPL", "GOGL", "INTC", "MSFT", "ORCL")
	symbol = Request.QueryString("symbol")

	If InArray(symbol, symbols) Then
		Randomize
		Response.Write "Price is " & Rand(1000, 10000) / 100.0
	Else
		Response.Write "Price not available"
	End If
%>
