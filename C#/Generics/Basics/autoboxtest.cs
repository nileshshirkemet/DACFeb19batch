using System;

static class Program
{
	/*
	private static string Select(int sign, string first, string second)
	{
		if(sign < 0)
			return first;
		return second;
	}	

	private static double Select(int sign, double first, double second)
	{
		if(sign < 0)
			return first;
		return second;
	}	
	*/

	private static object Select(int sign, object first, object second)
	{
		if(sign < 0)
			return first;
		return second;
	}	
		
	public static void Main(string[] args)
	{
		int s = int.Parse(args[0]);
		
		string ss = (string)Select(s, "Monday", "Tuesday");
		Console.WriteLine($"Selected string = {ss}");

		double sd = (double)Select(s, 4.25, 6.75);
		Console.WriteLine($"Selected double = {sd}");

		int si = (int)Select(s, 123456, "ABCDEF");
		Console.WriteLine($"Selected int = {si}");
	}
}