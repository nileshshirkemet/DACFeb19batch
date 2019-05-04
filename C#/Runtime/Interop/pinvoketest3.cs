using System;
using System.Text;
using System.Runtime.InteropServices;

static class Program
{
	[StructLayout(LayoutKind.Sequential)]
	struct FixedDeposit
	{
		public int Id;
		public double Amount;
		public int Period;
	}

	[DllImport(@"legacy\x86\invest.dll", CallingConvention = CallingConvention.Cdecl)]
	extern static int InitFixedDeposit(double amount, int period, out FixedDeposit fd);
	
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	delegate float Scheme(int period);

	[DllImport(@"legacy\x86\invest.dll", CallingConvention = CallingConvention.Cdecl)]
	extern static double GetMaturityValue(ref FixedDeposit fd, Scheme policy);

	public static void Main()
	{
		Console.Write("Amount: ");
		double p = double.Parse(Console.ReadLine());
		Console.Write("Period: ");
		int n = int.Parse(Console.ReadLine());
		FixedDeposit fd;

		InitFixedDeposit(p, n, out fd);
		Console.WriteLine($"New fixed-deposit ID is {fd.Id}");
		double mv = GetMaturityValue(ref fd, y => y < 4 ? 6 : 7);
		Console.WriteLine($"Maturity value is {mv:0.00}");
	}
}