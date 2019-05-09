using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

static class Program
{
	public static void Main()
	{
		var listener = new TcpListener(IPAddress.Any, 4010);
		listener.Start();
		
		Communicate(listener);
	}

	private static void Communicate(TcpListener server)
	{
		string[] symbols = {"APPL", "GOGL", "INTC", "MSFT", "ORCL"};
		Random rdm = new Random();
		
		for(;;)
		{
			TcpClient client = server.AcceptTcpClient();
			client.ReceiveTimeout = 20000;
			StreamReader reader = new StreamReader(client.GetStream());
			StreamWriter writer = new StreamWriter(client.GetStream());
			writer.AutoFlush = true;
			
			try
			{
				writer.WriteLine("Welcome to stock-exchange");
				string symbol = reader.ReadLine();
				int i = Array.IndexOf(symbols, symbol);
				if(i >= 0)
					writer.WriteLine("Price is {0}", 0.01 * rdm.Next(1000, 10000));
				else
					writer.WriteLine("Price not available");
			}
			catch(Exception ex)
			{
				Console.WriteLine($"Communication failure: {ex.Message}");
			}

			writer.Close();
			reader.Close();
			client.Close();
		}
	}
}
