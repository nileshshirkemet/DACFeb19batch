using System;
using System.Collections.Generic;

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

	public IEnumerator<V> GetEnumerator()
	{
		for(Node n = top; n != null; n = n.Previous)
			yield return n.Value;
	}
}

static class Program
{
	public static void Main()
	{
		int[] array = {10, 20, 30, 40, 50};
		Console.WriteLine("All integers in array");
		foreach(int n in array)
			Console.WriteLine(n);
		
		SimpleStack<Interval> stack = new SimpleStack<Interval>();
		stack.Push(new Interval(5, 41));
		stack.Push(new Interval(7, 32));
		stack.Push(new Interval(6, 53));
		stack.Push(new Interval(3, 24));
		stack.Push(new Interval(4, 15));
		Console.WriteLine("All Intervals on stack");
		foreach(Interval t in stack)
			Console.WriteLine(t);
	}
}