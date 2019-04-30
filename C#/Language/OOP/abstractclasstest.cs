using Banking;
using System;

static class Program
{
	public static void Main(string[] args)
	{
		Account jack = Banker.OpenCurrentAccount();
		jack.Deposit(20000);
		Account jill = Banker.OpenSavingsAccount();
		jill.Deposit(15000);

		try
		{
			double amt = double.Parse(args[0]);
			jill.Transfer(amt, jack);
			Console.WriteLine("Transfer succeeded.");
		}
		catch(InsufficientFundsException)
		{
			Console.WriteLine("Transfer failed due to lack of funds!");
		}
		catch(Exception ex)
		{
			Console.WriteLine($"Error: {ex.Message}");
		}
		Console.WriteLine($"Jack's Account ID is {jack.Id} and Balance is {jack.Balance}");
		Console.WriteLine($"Jill's Account ID is {jill.Id} and Balance is {jill.Balance}");
	}
}
