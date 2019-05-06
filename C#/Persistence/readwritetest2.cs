using System;
using System.IO;

static class Program
{
	public static void Main(string[] args)
	{
		if(args.Length > 2)
		{
			float price = float.Parse(args[0]);
			short stock = short.Parse(args[1]);
			string name = args[2].ToUpper();
			var writer = new StreamWriter(new FileStream("item.txt", FileMode.Create));
			writer.WriteLine(price);
			writer.WriteLine(stock);
			writer.WriteLine(name); 
			writer.Close();
		}
		else
		{
			var reader = new StreamReader(new FileStream("item.txt", FileMode.Open));
			float price = float.Parse(reader.ReadLine());
			short stock = short.Parse(reader.ReadLine());
			string name = reader.ReadLine();
			reader.Close();
			Console.WriteLine($"{price} {stock} {name}");
		}
	}
}