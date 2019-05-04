using System;
using System.Text;
using System.Runtime.InteropServices;

static class Program
{
	[DllImport(@"legacy\x86\hashenc.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	extern static int HashOfString(string str);

	[DllImport(@"legacy\x86\hashenc.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	extern static int EncodeBuffer(StringBuilder buf, int sz);

	
	public static void Main()
	{
		Console.Write("Original string: ");
		string pwd = Console.ReadLine();
		
		Console.WriteLine("Hash of string: {0:X}", HashOfString(pwd));

		var sb = new StringBuilder(pwd);
		EncodeBuffer(sb, sb.Length);
		Console.WriteLine("Encoded string: {0}", sb);
	}
}