using System;
using System.IO;
using System.Net.Sockets;

static class Program
{
	public static void Main(string[] args)
	{
		string symbol = args[0].ToUpper();
		string host = args.Length > 1 ? args[1] : "localhost";
		
		TcpClient client = new TcpClient(host, 4010);
		StreamReader reader = new StreamReader(client.GetStream());
		StreamWriter writer = new StreamWriter(client.GetStream());
		Console.WriteLine(reader.ReadLine());
		writer.WriteLine(symbol);
		writer.Flush();
		Console.WriteLine(reader.ReadLine());
		writer.Close();
		reader.Close();
		client.Close();
	}
}