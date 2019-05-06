using System;
using System.IO;

static class Program
{
	public static void Main(string[] args)
	{
		using(var fin = new FileStream(args[0], FileMode.Open))
		{
			using(var fout = new FileStream(args[1], FileMode.CreateNew))
			{
				byte[] buffer = new byte[80];
				while(fin.Position < fin.Length)
				{
					int n = fin.Read(buffer, 0, buffer.Length);
					for(int i = 0; i < n; ++i)
						buffer[i] = (byte)(buffer[i] ^ '#');
					fout.Write(buffer, 0, n);
				}
			}
		}
	}
}
