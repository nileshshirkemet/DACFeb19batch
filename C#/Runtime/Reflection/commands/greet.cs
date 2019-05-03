using System;

public class Greet
{
	public static void Main()
	{
		try
		{
			Console.WriteLine("Hello {0}.", Environment.UserName);

		}
		catch
		{
			Console.WriteLine("Hello User.");
		}
	}	
}
