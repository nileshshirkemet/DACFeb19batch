using System;

class Resource : IDisposable
{
	private string id;

	static Resource()
	{
		#if TESTING
		Console.WriteLine("Resource class initialized");
		#endif
	}
	
	public Resource(string name)
	{
		id = name;
		#if TESTING
		Console.WriteLine("{0} resource acquired and object initialized", id);
		#endif	
	}

	public void Consume(int action)
	{
		Console.WriteLine("Action {0} performed on {1} resource", action, id);
	}

	public void Dispose()
	{
		#if TESTING
		Console.WriteLine("{0} resource released and object disposed", id);
		#endif		
		GC.SuppressFinalize(this);	
	}

	~Resource()
	{
		#if TESTING
		Console.WriteLine("{0} resource released and object finalized", id);
		#endif	
	}
}

static class Program
{
	private static void Run()
	{
		var b = new Resource("Second");
		b.Consume(2);
	}

	private static void Run(string arg)
	{
		using(var d = new Resource("Fourth"))
		{
			d.Consume(int.Parse(arg));
		}
	}
	
	public static void Main(string[] args)
	{
		var a = new Resource("First");
		Run();
		GC.Collect();
		GC.WaitForPendingFinalizers();
		a.Consume(1);
		var c = new Resource("Third");
		c.Consume(3);
		c.Dispose();
		try
		{
			Run(args[0]);
		}
		catch{}
	}
}