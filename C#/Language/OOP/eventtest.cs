using System;

class QuoteEventArgs : EventArgs
{
	public double Value {get;}

	public QuoteEventArgs(double value) => Value = value;
}

delegate void QuoteEventHandler(object sender, QuoteEventArgs e);

//event-source
class Publisher 
{
	private static Random rdm = new Random();
	
	public event QuoteEventHandler Available;

	private static double Fetch(int id) 
	{
		for(int t = Environment.TickCount + 1000 * id; t > Environment.TickCount;);
		return rdm.Next(1000, 10000) / 100.0;
	}

	public void Publish(int count)
	{
		for(int i = 1; i <= count; ++i)
		{
			double value = Fetch(i);
			var e = new QuoteEventArgs(value);
			Available?.Invoke(this, e);
		}
	}
}

//event-sink
class Subscriber
{
	private Publisher pub = new Publisher();

	public Subscriber()
	{
		pub.Available += pub_Available;
		pub.Available += ShowTime;
	}

	private void pub_Available(object sender, QuoteEventArgs e)
	{
		Console.WriteLine($"Received value {e.Value}");
	}

	private void ShowTime(object sender, EventArgs e)
	{
		Console.WriteLine(DateTime.Now);
	}

	public void Run()
	{
		pub.Publish(5);
	}
}

static class Program
{
	public static void Main()
	{
		var sub = new Subscriber();		
		sub.Run();
	}
}