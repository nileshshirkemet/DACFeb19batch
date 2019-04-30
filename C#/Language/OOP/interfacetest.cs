using Banking;
using System;

static class Program
{
	private static void PayAnnualInterest(Account[] group)
	{
		foreach(var acc in group)
		{
			IProfitable p = acc as IProfitable;
			if(p != null)
			{
				double i = p.GetInterest(1);
				acc.Deposit(i);
			}
		}
	}

	private static void DeductTax(Account[] group)
	{
		foreach(var acc in group)
		{
			ITaxable t = acc as ITaxable;
			t?.Deduct(); //if(t != null) t.Deduct()
		}
	}

	public static void Main()
	{
		Account[] bank = new Account[4];
		bank[0] = Banker.OpenSavingsAccount();
		bank[0].Deposit(5000);
		bank[1] = Banker.OpenCurrentAccount();
		bank[1].Deposit(20000);
		bank[2] = Banker.OpenCurrentAccount();
		bank[2].Deposit(30000);
		bank[3] = Banker.OpenSavingsAccount();
		bank[3].Deposit(35000);

		PayAnnualInterest(bank);
		DeductTax(bank);		

		foreach(var acc in bank)
			Console.WriteLine("{0, -10}{1, 12:0.00}", acc.Id, acc.Balance);		
	}
}
