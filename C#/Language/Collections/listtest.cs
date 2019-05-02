using System;
using System.Collections.Generic;

static class Program
{
	public static void Main()
	{
		IList<Interval> store = new List<Interval>();
		store.Add(new Interval(5, 41));
		store.Add(new Interval(6, 12));
		store.Add(new Interval(7, 23));
		store.Add(new Interval(3, 34));
		store.Add(new Interval(4, 55));
		store.Add(new Interval(2, 94));

		foreach(Interval item in store)
			Console.WriteLine(item);
			
		Console.WriteLine("Third Interval = {0}", store[2]);
	}
}

