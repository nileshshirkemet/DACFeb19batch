using System;

static class Program
{
	//private static Nullable<double> Lookup(string name)
	private static double? Lookup(string name)
	{
		string[] names = {"jack", "jill", "john", "jane"};
		double[] balances = {5000, 9000, 7000, 3000};
		int i = Array.IndexOf(names, name);
		if(i >= 0)
			return balances[i];
		return null;
	}

	public static void Main(string[] args)
	{
		double? bal = Lookup(args[0]);
		if(bal == null)
			Console.WriteLine("No such name!");
		else
			Console.WriteLine($"Balance = {bal}");
		Console.WriteLine("Interest = {0}", 0.04 * (bal ?? 0));
	}
}