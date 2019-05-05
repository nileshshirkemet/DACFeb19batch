using System;
using System.Threading;

static class Program
{
	private static void HandleJob(int id)
	{
		Console.WriteLine($"Thread<{Thread.CurrentThread.ManagedThreadId}> has accepted job:{id}");
		Worker.DoWork(id);
		Console.WriteLine($"Thread<{Thread.CurrentThread.ManagedThreadId}> has finished job:{id}");
	}
	
	public static void Main(string[] args)
	{
		int n = args.Length > 0 ? int.Parse(args[0]) : 50;
		
		Thread child = new Thread(delegate()
		{
			HandleJob(n);
		});
		child.IsBackground = n > 100; 
		child.Start();
				
		HandleJob(60);
	}
}