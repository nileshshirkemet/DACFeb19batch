using System;

static class Program
{

	private static T Select<T>(int sign, T first, T second)
	{
		if(sign < 0)
			return first;
		return second;
	}	
		
	public static void Main(string[] args)
	{
		int s = int.Parse(args[0]);
		
		string ss = Select(s, "Monday", "Tuesday");
		Console.WriteLine($"Selected string = {ss}");

		double sd = Select(s, 4.25, 6.75);
		Console.WriteLine($"Selected double = {sd}");

		int si = Select(s, 123456, 0xABCDEF);
		Console.WriteLine($"Selected int = {si}");
	}
}