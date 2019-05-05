using FinanceLib;
using System;
using System.Runtime.InteropServices;

[ComImport]
[Guid("1A87402F-A9F3-449F-ACB3-714A9275BEE0")]	
class ReducingBalanceLoanClass {}

class CarLoanScheme : ILoanScheme
{
	public float GetInterestRate(short period)
	{
		return 9.0f + 0.5f * (period / 3);
	}
}

static class Program
{
	[STAThread]
	public static void Main()
	{
		Console.Write("Amount: ");
		double p = double.Parse(Console.ReadLine());
		Console.Write("Period: ");
		short n = short.Parse(Console.ReadLine());
		
		ILoan loan = (ILoan) new ReducingBalanceLoanClass();
		try
		{
			loan.Acquire(p, n);
			Console.WriteLine("E.M.I for Home loan: {0:0.00}", loan.GetInstallmentUsingRate(8));
			Console.WriteLine("E.M.I for Car loan : {0:0.00}", loan.GetInstallmentForScheme(new CarLoanScheme())); //a CCW of managed object will be passed to COM method which will dispatch calls to that object
		}
		catch(COMException ex)
		{
			Console.WriteLine("ERROR: {0}", (LoanError)ex.HResult);
		}
	}
}