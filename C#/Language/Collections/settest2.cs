using System;
using System.Collections.Generic;

static class Program
{
	class IntervalComparison : IComparer<Interval>
	{
		public int Compare(Interval x, Interval y)
		{
			return x.Seconds - y.Seconds;
		}
	}
	
	public static void Main()
	{
		//ISet<Interval> store = new SortedSet<Interval>();
		ISet<Interval> store = new SortedSet<Interval>(new IntervalComparison());
		store.Add(new Interval(5, 41));
		store.Add(new Interval(6, 12));
		store.Add(new Interval(7, 23));
		store.Add(new Interval(3, 34));
		store.Add(new Interval(4, 55));
		store.Add(new Interval(2, 94));

		foreach(Interval item in store)
			Console.WriteLine(item);
			
	}
}

