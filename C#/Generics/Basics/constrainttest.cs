using System;

static class Program
{

	private static T Select<T>(T first, T second) where T : IComparable<T>
	{
		if(first.CompareTo(second) > 0)
			return first;
		return second;
	}	
		
	public static void Main(string[] args)
	{
		string ss = Select("Monday", "Tuesday");
		Console.WriteLine($"Selected string = {ss}");

		double sd = Select(4.25, 6.75);
		Console.WriteLine($"Selected double = {sd}");

		Interval si = Select(new Interval(5, 40), new Interval(4, 50));
		Console.WriteLine($"Selected Interval = {si}");
	}
}