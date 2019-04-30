using System;

namespace Banking
{
	public class InsufficientFundsException : ApplicationException {}
	
	//non-activatable class
	public abstract class Account
	{
		public int Id {get; internal set;}

		public double Balance {get; protected set;}	

		//pure (must override) method
		public abstract void Deposit(double amount);

		public abstract void Withdraw(double amount);

		public void Transfer(double amount, Account that)
		{
			if(!ReferenceEquals(this, that))
			{
				this.Withdraw(amount);
				that.Deposit(amount);
			}
		}
	}

	public interface IProfitable
	{
		double GetInterest(int period);
	}

	public interface ITaxable
	{
		void Deduct();
	}	
		
	//non-inheritable class
	sealed class CurrentAccount : Account, ITaxable
	{
		public override void Deposit(double amount)
		{
			if(Balance < 0)
				amount *= 0.9;
			Balance += amount;
		}

		public override void Withdraw(double amount)
		{
			Balance -= amount;
		}

		//explicit interface implementation
		void ITaxable.Deduct()
		{
			if(Balance > 25000)
			{
				double tax = 0.05 * (Balance - 25000);
				Balance -= tax;
			} 
		}
	}

	sealed class SavingsAccount : Account, IProfitable
	{
		const double MinBal = 5000;

		internal SavingsAccount()
		{
			Balance = MinBal;
		}

		public override void Deposit(double amount)
		{
			Balance += amount;
		}

		public override void Withdraw(double amount)
		{
			if(Balance - amount < MinBal)
				throw new InsufficientFundsException();
			Balance -= amount;
		}

		public double GetInterest(int period)
		{
			float rate = Balance < 3 * MinBal ? 4 : 5;
			return Balance * period * rate / 100;
		}
	}

	public static class Banker 
	{
		private static int nid = Environment.TickCount % 1000000;
		
		public static Account OpenCurrentAccount()
		{
			var acc = new CurrentAccount();
			acc.Id = 10000000 + nid++;
			return acc;
		}

		public static Account OpenSavingsAccount()
		{
			var acc = new SavingsAccount();
			acc.Id = 20000000 + nid++;
			return acc;
		}

	} 	
}
