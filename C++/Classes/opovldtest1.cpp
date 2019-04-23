#include <iostream>

using namespace std;

class Interval
{
public:

	explicit Interval(long time=0)
	{
		seconds = time;
	}

	Interval(long m, long s)
	{
		seconds = 60 * m + s;
	}

	long GetTime() const
	{
		return seconds;
	}

	void SetTime(long value)
	{
		seconds = value; 
	}

	void Print() const
	{
		long m = seconds / 60, s = seconds % 60;
		if(s < 10)
			cout << m << ":0" << s << endl;
		else
			cout << m << ":" << s << endl;
	}

	Interval operator+(const Interval& other) const
	{
		return Interval(seconds + other.seconds);
	}

	Interval operator++() 
	{
		return Interval(++seconds);
	}

	Interval operator++(int) 
	{
		return Interval(seconds++);
	}
private:
	long seconds;

	//friend function - a non-member function define by 
	//the author of the current class which has access 
	//to its private member
	friend Interval operator*(long, const Interval&);
};

Interval operator*(long lhs, const Interval& rhs)
{
	return Interval(lhs * rhs.seconds);
}

int main(void)
{
	Interval a(3, 45);
	a.Print();

	Interval b(4, 30);
	b.Print();

	Interval c = a + b; //a.operator+(b)
	c.Print();

	Interval d = 4 * c; //operator*(4, c)
	d.Print();

	Interval e = ++a; //a.operator++()
	a.Print();
	e.Print();

	Interval f = b++; //b.operator++(0)
	b.Print();
	f.Print();
}

