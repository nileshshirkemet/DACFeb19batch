<%
	Function Encode(bytes)
  		Dim i, ch, result
  		For i = 1 To LenB(bytes)
    			ch = Chr(AscB(MidB(bytes, i, 1)))
			result = result & ChrB(Asc(ch) Xor Asc("#"))
  		Next
  		Encode = result
	End Function

	Response.BinaryWrite Encode(Request.BinaryRead(Request.TotalBytes))
%>