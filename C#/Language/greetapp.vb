Imports Greeting

Module App

	Sub Main()
		Dim g As New Greeter(False)
		Dim name As String = InputBox("What is your name?")
		MsgBox(g.Meet(name))
	End Sub

End Module