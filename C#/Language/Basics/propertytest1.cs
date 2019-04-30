using System;

struct Rectangle
{
	private int length;
	private int breadth;

	public Rectangle(int l, int b)
	{
		length = l;
		breadth = b;
	}

	//property - get/set methods which can be invoked 
	//using field-access syntax
	public int Length
	{
		get
		{
			return length;
		}
		set
		{
			length = value;	
		}
	}

	public int Breadth
	{
		get => breadth;
		set => breadth = value;
	}

	//read-only property
	public int Perimeter
	{
		get => 2 * (length + breadth);
	}

	//indexer - default parameterized property
	public int this[short thickness] 
	{
		get => (length - 2 * thickness) * (breadth - 2 * thickness);
	}
}

static class Program
{
	public static void Main()
	{
		Rectangle a = new Rectangle();
		a.Length = a.Breadth = 10;
		Console.WriteLine($"Perimeter of first rectangle is {a.Perimeter}");
		
		Rectangle b = new Rectangle(19, 14);
		Console.WriteLine($"Inner area of second rectangle is {b[2]}");
	}
}
