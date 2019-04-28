using System;

enum RoomType {Economy, Business, Executive, Deluxe}

class HotelRoom
{
	public int Number;
	public RoomType Category = RoomType.Business;
	public bool Taken;

	public void Print()
	{
		string status = Taken ? "Occupied" : "Available";
		Console.WriteLine($"Room {Number} is of {Category} class and is currently {status}.");
	}
}

static class Program
{
	private static void CheckIn(HotelRoom room)
	{
		if(room.Taken)
			throw new ApplicationException("Room unavailable");
		room.Taken = true;
	}	

	public static void Main(string[] args)
	{
		HotelRoom myroom = new HotelRoom();
		myroom.Number = 504;
		myroom.Taken = false;
		
		myroom.Print();		
		Console.WriteLine($"Checking into room {myroom.Number}...");
		CheckIn(myroom);
		myroom.Print();
	}
}
