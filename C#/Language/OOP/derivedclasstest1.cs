using Payroll;
using System;

static class Program
{
	//extension method - a method of static class which can be 
	//invoked as an instance method of its 'this' qualified first argument type 
	private static double GetIncomeTax(this Employee emp)
	{
		double i = emp.GetIncome();
		return i > 10000 ? 0.15 * (i - 10000) : 0;
	}

	public static void Main()
	{
		Employee jack = new Employee();
		jack.Hours = 186;
		jack.Rate = 52;

		SalesPerson jill = new SalesPerson(186, 52, 48000);
		
		Console.WriteLine("Jack's ID is {0}, Income is {1:0.00} and Tax is {2:0.00}", jack.Id, jack.GetIncome(), jack.GetIncomeTax()); //Program.GetIncomeTax(jack)		
		Console.WriteLine("Jill's ID is {0}, Income is {1:0.00} and Tax is {2:0.00}", jill.Id, jill.GetIncome(), jill.GetIncomeTax());		

		Console.WriteLine("Number of Employees = {0}", Employee.CountInstances());
	}
}
