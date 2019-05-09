using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

static class Program
{
	public static void Main()
	{
		IPAddress address = IPAddress.Parse("230.0.0.1");
		UdpClient subscriber = new UdpClient(5010);
		subscriber.JoinMulticastGroup(address);

		IPEndPoint remote = null;
		for(int i = 0; i < 5; ++i)
		{
			byte[] message = subscriber.Receive(ref remote);
			string text = Encoding.UTF8.GetString(message);
			Console.WriteLine(text);
		}

		subscriber.DropMulticastGroup(address);
		subscriber.Close();
	}
}