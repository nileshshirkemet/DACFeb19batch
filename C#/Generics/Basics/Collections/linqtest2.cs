using System;
using System.Linq;
using System.Collections.Generic;

static class Program
{
	public static void Main(string[] args)
	{
		int limit = args.Length > 0 ? int.Parse(args[0]) : 0;
		double distance = 500;
		List<Interval> store = new List<Interval>
		{
			new Interval(5, 31),
			new Interval(3, 42),
			new Interval(4, 53),
			new Interval(6, 14),
			new Interval(7, 25),
			new Interval(2, 36)
		};
		
		var selection = from i in store
				where i.Time > limit
				orderby i.Seconds descending
				select new 
				{
					Duration = i,
					Speed = 3.6 * distance / i.Time
				};
		foreach(var entry in selection)
			Console.WriteLine("{0}\t{1:0.0}", entry.Duration, entry.Speed);
	}
}