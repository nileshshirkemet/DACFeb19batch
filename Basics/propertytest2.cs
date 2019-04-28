using System;

class Customer
{
	//auto property
	public string Name {get; set;}

	public decimal Credit {get; set;} = 5000;
}

static class Program
{
	public static void Main()
	{
		Customer a = new Customer();
		a.Name = "Jack";
		Console.WriteLine($"{a.Name}'s credit is {a.Credit}");	
		Customer b = new Customer {Name = "Jill", Credit = 6000};	
		Console.WriteLine($"{b.Name}'s credit is {b.Credit}");
		var c = new Customer {Name = "John", Credit = 7000};
		Console.WriteLine($"{c.Name}'s credit is {c.Credit}");
		var d = new {Id = 23, Score = 65}; //anonymous type	
		Console.WriteLine($"Student number {d.Id} has scored {d.Score}");
	}
}
