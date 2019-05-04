using System;
using System.Runtime.InteropServices;

static class Program
{
	[DllImport("legacy\\x86\\asset.dll", EntryPoint = "DDB", CallingConvention = CallingConvention.Cdecl)]
	extern static double GetPriceAfter(double cost, short life, short period);	

	public static void Main()
	{
		Console.Write("Original cost: ");
		double c = double.Parse(Console.ReadLine());
		Console.Write("Useful life  : ");
		short l = short.Parse(Console.ReadLine());
	
		for(short n = 1; n <= l; ++n)
			Console.WriteLine("{0, -4}{1, 12:0.00}", n, GetPriceAfter(c, l, n));
	}
}