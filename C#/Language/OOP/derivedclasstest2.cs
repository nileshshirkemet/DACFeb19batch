using Payroll;
using System;

static class Program
{
	private static double GetAverageIncome(Employee[] group)
	{
		double total = 0;
		foreach(var member in group)
		{
			total += member.GetIncome();
		}
		return 	total / group.Length;
	}

	private static double GetTotalBonus(Employee[] group)
	{
		double total = 0;
		foreach(var member in group)
		{
			if(member is SalesPerson)
				total += 1200;
			else
				total += 1500;
		}
		return 	total;
	}

	private static double GetTotalSales(Employee[] group)
	{
		double total = 0;
		foreach(var member in group)
		{
			SalesPerson sp = member as SalesPerson;
			if(sp != null)
				total += sp.Sales;
		}
		return 	total;
	}
	

	public static void Main()
	{
		Employee[] dept = new Employee[5];
		dept[0] = new Employee(186, 52);
		dept[1] = new Employee(175, 95);
		dept[2] = new SalesPerson(160, 40, 30000);
		dept[3] = new Employee(188, 206);
		dept[4] = new SalesPerson(190, 60, 70000);

		Console.WriteLine("Average income: {0:0.00}", GetAverageIncome(dept));		
		Console.WriteLine("Total bonus: {0:0.00}", GetTotalBonus(dept));
		Console.WriteLine("Total sales: {0:0.00}", GetTotalSales(dept));
	}
}
