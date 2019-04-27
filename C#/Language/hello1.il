.assembly Hello {}
.assembly extern mscorlib {}

.method public static void Run() cil managed
{
	.entrypoint
	.maxstack 1

	ldstr	"Hello World!"
	call	void [mscorlib]System.Console::WriteLine(string)
	ret
}
