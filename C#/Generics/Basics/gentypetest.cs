using System;

class SimpleStack<V>
{
	class Node
	{
		internal V Value;
		internal Node Previous;

		internal Node(V val, Node prev)
		{
			Value = val;
			Previous = prev;
		}
	}

	private Node top;

	public void Push(V value)
	{
		top = new Node(value, top);
	}

	public V Pop()
	{
		V value = top.Value;
		top = top.Previous;
		return value;
	}

	public bool Empty()
	{
		return top == null;
	}
}

static class Program
{
	public static void Main()
	{
		SimpleStack<string> a = new SimpleStack<string>();
		a.Push("Monday");
		a.Push("Tuesday");
		a.Push("Wednesday");
		a.Push("Thursday");
		a.Push("Friday");
		//a.Push(45.6);

		SimpleStack<string> b = new SimpleStack<string>();
		b.Push("June");
		b.Push("May");
		b.Push("April");
		b.Push("March");

		SimpleStack<Interval> c = new SimpleStack<Interval>();
		c.Push(new Interval(5, 41));
		c.Push(new Interval(7, 32));
		c.Push(new Interval(6, 53));
		c.Push(new Interval(3, 24));
		c.Push(new Interval(4, 15));

		SimpleStack<object> d = new SimpleStack<object>();
		d.Push("Saturday");
		d.Push(45.6);
		d.Push(new Interval(2, 36));

		while(!a.Empty())
			Console.WriteLine(a.Pop());
		Console.WriteLine("----------------------");
		while(!b.Empty())
			Console.WriteLine(b.Pop());
		Console.WriteLine("----------------------");
		while(!c.Empty())
			Console.WriteLine(c.Pop());
		Console.WriteLine("----------------------");
		while(!d.Empty())
			Console.WriteLine(d.Pop());
	}
}