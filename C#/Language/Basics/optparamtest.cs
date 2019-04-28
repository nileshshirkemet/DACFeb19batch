using System;

static class Program
{
	private static double GetIncome(double invest, int duration=3, string risk="medium")
	{
		float rate;
		switch(risk)		
		{
			case "low":
				rate = 6;
				break;
			case "high":
				rate = 9;
				break;
			default:
				rate = 7.5f;
				break;
		}
		double amount = invest * Math.Pow(1 + rate / 100, duration);
		return amount - invest;
	}

	public static void Main(string[] args)
	{
		try
		{
			double amt = double.Parse(args[0]);
			Console.WriteLine("Income in Bronze scheme: {0:0.00}", GetIncome(amt, 2, "low"));
			Console.WriteLine("Income in Silver scheme: {0:0.00}", GetIncome(amt, 4));
			Console.WriteLine("Income in Gold scheme: {0:0.00}", GetIncome(amt, risk:"high"));
		}
		catch(IndexOutOfRangeException)
		{
			Console.WriteLine("Error: No input!");
		}
		catch(FormatException)	
		{
			Console.WriteLine("Error: Bad input!");
		}
	}
}
