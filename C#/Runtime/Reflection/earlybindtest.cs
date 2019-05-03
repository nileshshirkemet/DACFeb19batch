using Finance;
using System;

static class Program
{
	public static void Main(string[] args)
	{
		double p = double.Parse(args[0]);
		Type t = args.Length > 1 ? Type.GetType(args[1]) : typeof(PersonalLoan);
		ILoanPolicy pol = (ILoanPolicy)Activator.CreateInstance(t);
		int m = 10;
		
		for(int n = 1; n <= m; ++n)
		{
			float r = pol.GetInterestRate(n);
			float i = r / 1200;
			double emi = p * i / (1 - Math.Pow(1 + i, -12 * n));
			Console.WriteLine("{0, -4}{1, 12:0.00}", n, emi);
		}
	}
}