using System;

namespace ServerApp
{
	static class Store
	{

		internal static int Find(string name)
		{
			string[] items = {"apple", "mango", "orange", "peach", "pear"};

			return Array.IndexOf(items, name.ToLower());
		}

		internal static double PriceOf(int item)
		{
			double[] prices = {21.75, 24.50, 9.25, 5.75, 6.50};

			return prices[item];
		}

		internal static int StockOf(int item)
		{
			int[] stocks = {100, 200, 300, 250, 150};

			return stocks[item];
		}
	}
}
