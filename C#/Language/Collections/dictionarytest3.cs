using System;
using System.Collections.Generic;

static class Program
{
	public static void Main(string[] args)
	{
		IDictionary<string, Interval> store = new SortedDictionary<string, Interval>();
		store.Add("monday", new Interval(5, 41));
		store.Add("tuesday", new Interval(6, 12));
		store.Add("wednesday", new Interval(7, 23));
		store.Add("thursday", new Interval(3, 34));
		store.Add("friday", new Interval(4, 55));
		//store.Add("monday", new Interval(2, 36));

		if(args.Length > 0)
		{
			if(store.TryGetValue(args[0], out Interval val))
			{
				Console.WriteLine($"Value = {val}");
			}
			else
			{
				Console.WriteLine($"Cannot find {args[0]}");
			}
		}
		else
		{
			foreach(var entry in store)
				Console.WriteLine("{0, -12}{1}", entry.Key, entry.Value);
		}	
		
	}
}

