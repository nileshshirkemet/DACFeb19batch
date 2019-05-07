using System;

static class Worker
{
	public static int DoWork(int count=0)
	{
		int t = Environment.TickCount;
		
		if(count == 0)
			count = t % 10 + 1;

		while(Environment.TickCount < t + 100 * count);

		return count;
	}
}