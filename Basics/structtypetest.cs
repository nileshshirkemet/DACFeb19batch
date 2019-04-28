using System;

enum RoomType {Economy, Business, Executive, Deluxe}

struct HotelRoom
{
	public int Number;
	public RoomType Category;
	public bool Taken;

	public void Print()
	{
		string status = Taken ? "Occupied" : "Available";
		Console.WriteLine($"Room {Number} is of {Category} class and is currently {status}.");
	}
}

static class Program
{
	private static void CheckIn(ref HotelRoom room)
	{
		if(room.Taken)
			throw new ApplicationException("Room unavailable");
		room.Taken = true;
	}	

	public static void Main(string[] args)
	{
		HotelRoom myroom;
		myroom.Number = 504;
		myroom.Category = RoomType.Business;
		myroom.Taken = false;
		
		myroom.Print();		
		Console.WriteLine($"Checking into room {myroom.Number}...");
		CheckIn(ref myroom);
		myroom.Print();
		//CheckIn(ref myroom);
	}
}
