using QuadEq;
using System;

static class Program
{
	public static void Main()
	{
		Console.Write("Perimeter: ");
		double perim = double.Parse(Console.ReadLine());
		Console.Write("Area     : ");
		double area = double.Parse(Console.ReadLine());
		double a = 1, b = -perim / 2, c = area;

		var qe = new QuadraticEquationClass(); //produces a RCW for activated COM object which dispatches calls to that object
		if(qe.HasRealRoots(a, b, c) != 0)
		{
			double r1, r2;
			qe.Solve(a, b, c, out r1, out r2);
			Console.WriteLine($"Dimensions = {r1}, {r2}");
		}
		else
		{
			Console.WriteLine("No such rectangle!");
		}	
	}
}