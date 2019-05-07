using System;
using System.IO;
using System.IO.MemoryMappedFiles;

static class Program
{
	public static void Main(string[] args)
	{
		FileInfo fi = new FileInfo(args[0]);
		using(var mapping = MemoryMappedFile.CreateFromFile(fi.Name))
		{
			using(var view = mapping.CreateViewAccessor())
			{
				for(long i = 0, j = fi.Length - 1; i < j; ++i, j--)
				{
					byte ib = view.ReadByte(i);
					byte jb = view.ReadByte(j);
					view.Write(i, jb);
					view.Write(j, ib);
				}
			}
		}
	}
}