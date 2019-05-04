using System;

static class Program
{
	public static void Main()
	{
		Console.Write("Length : ");
		int l = int.Parse(Console.ReadLine());
		Console.Write("Breadth: ");
		int b = int.Parse(Console.ReadLine());
		Console.Write("Height : ");
		int h = int.Parse(Console.ReadLine());

		var box = new Ijw.LegacyBox(l, b, h);

		Console.WriteLine("Inner volume of box = {0}", box.GetInnerVolume(1));

	}
}