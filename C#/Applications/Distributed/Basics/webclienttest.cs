using System;
using System.IO;
using System.Net;

static class Program
{
	public static void Main(string[] args)
	{
		string url = $"http://localhost/stock.asp?symbol={args[0]}";
		WebClient client = new WebClient();
		Stream content = client.OpenRead(url);
		StreamReader reader = new StreamReader(content);
		Console.WriteLine(reader.ReadLine());
		reader.Close();
	}
}