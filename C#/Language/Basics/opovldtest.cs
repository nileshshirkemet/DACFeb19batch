using System;

class Interval
{
	public int Minutes {get;}

	public int Seconds {get;}

	public Interval(int min, int sec)
	{
		Minutes = min + sec / 60;
		Seconds = sec % 60;	
	}

	public int Time => 60 * Minutes + Seconds;

	public void Print()
	{
		Console.WriteLine("{0}:{1:00}", Minutes, Seconds);
	}

	public static Interval operator+(Interval lhs, Interval rhs)
	{
		return new Interval(lhs.Minutes + rhs.Minutes, lhs.Seconds + rhs.Seconds);	
	}

	public static Interval operator*(int lhs, Interval rhs)
	{
		return new Interval(lhs * rhs.Minutes, lhs * rhs.Seconds);
	}

	public static Interval operator++(Interval val)
	{
		return new Interval(val.Minutes, val.Seconds + 1);
	}

	//public static implicit operator double(Interval val)
	public static explicit operator double(Interval val)
	{
		return val.Minutes + val.Seconds / 60.0;
	}	
}

static class Program
{
	public static void Main()
	{
		Interval a = new Interval(3, 40);
		a.Print();
		Interval b = new Interval(4, 85);
		b.Print();
		Interval c = a + b; //Interval.operator+(a, b)
		c.Print();
		Interval d = 4 * c; //Interval.operator*(4, c)
		d.Print();
		Interval e = ++a;
		a.Print();
		e.Print();
		Interval f = b++;
		b.Print();
		f.Print();
		Interval g = new Interval(6, 45);
		g.Print(); 
		double h = (double)g;
		Console.WriteLine(h);
	}
}
