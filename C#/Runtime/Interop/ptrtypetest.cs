using System;

unsafe static class Program
{
	static int SquareOne(double* pVal)
	{
		double value = *pVal;
		if(value > 0)
		{
			*pVal = value * value;
			return 1;
		}
		return 0;
	}
	
	static double SquareAll(double* values, int count)
	{
		double sum = 0;
		int i;
		for(i = 0; i < count; ++i)
		{
			if(SquareOne(values + i) == 1)
				sum += values[i];
		}
		return sum;
	} 

	public static void Main(string[] args)
	{
		int n = args.Length > 0 ? int.Parse(args[0]) : 10;
		double result = 0;

		if(n <= 20)
		{
			double* list = stackalloc double[n];
			for(int i = 0; i < n; ++i)
				list[i] = 1.1 * (i + 1);
			result = SquareAll(list, n);
		}
		else
		{
			double[] list = new double[n];
			for(int i = 0; i < n; ++i)
				list[i] = 1.1 * (i + 1);
			fixed(double* first = &list[0])
			{
				result = SquareAll(first, n);
			}
		}
		
		Console.WriteLine("Result = {0}", result);
	}
}