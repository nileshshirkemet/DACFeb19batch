using System;

public class Dice
{
	public static void Main()
	{
		Random rnd = new Random();
		Console.WriteLine("Value = {0}", rnd.Next(1, 7));
	}
}
