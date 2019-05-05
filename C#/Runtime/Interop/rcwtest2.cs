using System;

static class Program
{
	[STAThread]
	public static void Main()
	{
		Console.Write("Weight  : ");
		double w = double.Parse(Console.ReadLine());
		Console.Write("Distance: ");
		double d = double.Parse(Console.ReadLine());

		Type t = Type.GetTypeFromProgID("METLogistics.AirCargo");
		dynamic cargo = Activator.CreateInstance(t); //produces RCW which dispatches call through IDispatch
		
		Console.WriteLine("Payment: {0:0.00}", cargo.QuoteTariff(w, d));
	}	
}