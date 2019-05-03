using System;

static class Program
{
	public static void Main(string[] args)
	{
		var t = Type.GetType($"Greeters.{args[0]},greeters");
		dynamic g = Activator.CreateInstance(t); //compiler will create DLR bindings for g
		
		Console.WriteLine(g.Meet("Jack")); //duck-typing
		Console.WriteLine(g.Leave("Jack"));
		//g.Kick("Jack");
	}
}