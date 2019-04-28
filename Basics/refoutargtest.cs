using System;

static class Program
{
	private static void Swap(ref double first, ref double second)
	{
		double third = first;
		first = second;
		second = third;
	}

	private static double Average(double first, double second, out double dev)
	{
		dev = first > second ? (first - second)	/ 2 : (second - first) / 2;
		return (first + second) / 2;
	}

	public static void Main(string[] args)
	{
		double x = double.Parse(args[0]);
		double y = double.Parse(args[1]);
		Console.WriteLine($"Original values: {x}, {y}");	
		Swap(ref x, ref y);
		Console.WriteLine($"Swapped values: {x}, {y}");	
		double d;
		double a = Average(x, y, out d);
		Console.WriteLine($"Average is {a} with a deviation of {d}");
	}
}
