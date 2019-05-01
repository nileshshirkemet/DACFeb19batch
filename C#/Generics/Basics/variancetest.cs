using System;

interface IStackReader<out V>
{
	V Pop();
	bool Empty();
}

interface IStackWriter<in V>
{
	void Push(V value);
}

class SimpleStack<V> : IStackReader<V>, IStackWriter<V>
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

	public void Copy(IStackWriter<V> target)
	{
		for(Node n = top; n != null; n = n.Previous)
			target.Push(n.Value);
	}
}

class FiniteStack<V> : IStackReader<V>, IStackWriter<V>
{
	private V[] values;
	private int count;

	public FiniteStack(int size)
	{
		values = new V[size];
	}

	public void Push(V value)
	{
		values[count++] = value;
	}

	public V Pop()
	{
		return values[--count];
	}

	public bool Empty()
	{
		return count == 0;
	}
	
}

static class Program
{
	private static void PrintStack(IStackReader<object> source)
	{
		for(int i = 0; !source.Empty(); ++i)
		{
			if(i > 0) Console.Write(", ");
			Console.Write(source.Pop());
		}
		Console.WriteLine();
	}

	public static void Main()
	{
		SimpleStack<string> a = new SimpleStack<string>();
		a.Push("Monday");
		a.Push("Tuesday");
		a.Push("Wednesday");
		a.Push("Thursday");
		a.Push("Friday");

		FiniteStack<string> b = new FiniteStack<string>(10);
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
		c.Copy(d); //contravariance(Interval -> object) for IStackWriter			

		PrintStack(a); //covariance(object -> string) for IStackReader
		PrintStack(b); 
		PrintStack(c);
		PrintStack(d);
	}
}