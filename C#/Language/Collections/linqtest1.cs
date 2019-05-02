using System;
using System.Linq;

static class Program
{
	public static void Main()
	{
		int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
		
		/*
		foreach(int n in numbers)
		{
			if((n % 2) == 1)
				Console.WriteLine(n * n);
		}
		*/
		//var selection = numbers.Where(n => (n % 2) == 1).Select(n => n * n);
		var selection = from n in numbers where (n % 2) == 1 select n * n;
		foreach(int n in selection)
			Console.WriteLine(n);
	}
}