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
			var writer = new BinaryWriter(new FileStream("item.dat", FileMode.Create));
			writer.Write(price);
			writer.Write(stock);
			writer.Write(name); 
			writer.Close();
		}
		else
		{
			var reader = new BinaryReader(new FileStream("item.dat", FileMode.Open));
			float price = reader.ReadSingle();
			short stock = reader.ReadInt16();
			string name = reader.ReadString();
			reader.Close();
			Console.WriteLine($"{price} {stock} {name}");
		}
	}
}