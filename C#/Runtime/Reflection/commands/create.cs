using System;

class SimpleObject
{
	private static int count;
	private int id;

	static SimpleObject()
	{
		Console.WriteLine("SimpleObject class initialized in app-domain<{0}>", AppDomain.CurrentDomain.Id);
	}

	public SimpleObject()
	{
		id = ++count;
		Console.WriteLine("SimpleObject instance<{0}> created in app-domain<{1}>", id, AppDomain.CurrentDomain.Id);
	}

	~SimpleObject()
	{
		Console.WriteLine("SimpleObject instance<{0}> destroyed in app-domain<{1}>", id, AppDomain.CurrentDomain.Id);
	}
}

public class Create
{
	public static void Main()
	{
		SimpleObject obj = new SimpleObject();
	}
}

