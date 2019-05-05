using System;
using System.Threading;

class JointAccount
{
	private static int nid = 1000;

	public int Id {get; private set;}
	
	public int Balance {get; private set;}
	
	public JointAccount()
	{
		this.Id = Interlocked.Increment(ref nid);
		this.Balance = 0;
	}

	public void Deposit(int amount)
	{
		Worker.DoWork(amount / 1000);
		lock(this)
		{
			this.Balance += amount;
		}
	}

	public bool Withdraw(int amount)
	{
		bool result = false;

		Monitor.Enter(this);
		if(this.Balance >= amount)
		{
			Worker.DoWork(amount / 1000);
			this.Balance -= amount;
			result = true;
		}
		Monitor.Exit(this);

		return result;
	}
}

static class Program
{
	public static void Main()
	{
		JointAccount acc = new JointAccount();
		acc.Deposit(10000);
		Console.WriteLine("Joint-Account with ID {0} opened for Jack and Jill.", acc.Id);
		Console.WriteLine("Initial balance = {0}", acc.Balance);

		Thread child = new Thread(delegate()
		{
			Console.WriteLine("Jack withdraws 6000 from joint-account...");
			if(acc.Withdraw(6000) == false)
				Console.WriteLine("Jack's withdraw operation failed!");	
		});
		child.Start();

		Console.WriteLine("Jill withdraws 7000 from joint-account...");
		if(acc.Withdraw(7000) == false)
			Console.WriteLine("Jill's withdraw operation failed!");

		child.Join(); //wait for child thread to exit
		Console.WriteLine("Final balance = {0}", acc.Balance);
	}
}