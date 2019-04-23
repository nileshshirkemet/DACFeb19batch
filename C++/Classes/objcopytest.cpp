#include <iostream>

using namespace std;

class Interval
{
public:

	Interval(long m=0, long s=0) 
	{
		minutes = m + s / 60;
		seconds = s % 60;
		cout << "Interval object activated" << endl;
	}

	//copy constructor
	Interval(const Interval& that) 
	{
		minutes = that.minutes;
		seconds = that.seconds;
		cout << "Interval object(copy) activated" << endl;
	}

	void operator=(const Interval& that)
	{
		minutes = that.minutes;
		seconds = that.seconds;
		cout << "Interval object copied" << endl;
	}
	
	long GetTime() const
	{
		return 60 * minutes + seconds;
	}

	void SetTime(long value) 
	{
		minutes = value / 60;
		seconds = value % 60;
	}

	void Print() const
	{
		if(seconds < 10)
			cout << minutes << ":0" << seconds << endl;
		else
			cout << minutes << ":" << seconds << endl;
	}

	~Interval()
	{
		cout << "Interval object deactivated" << endl;
	}

private:
	long minutes;
	long seconds;
};

class Journey
{
public:
	Journey(float dis, const Interval& dur) : duration(dur)
	{
		distance = dis;
		//duration = dur;
		cout << "Journey object activated" << endl;
	}

	float Speed() const
	{
		return 3.6 * distance / duration.GetTime();
	}

	~Journey()
	{
		cout << "Journey object deactivated" << endl;
	}

private:
	float distance;
	Interval duration;
};

void Run(void)
{
	Interval a(2, 5);
	Journey b(500, a);
	cout << "Speed = " << b.Speed() << endl;
}

int main(void)
{
	cout << "Journey begins..." << endl;
	Run();
	cout << "Journey ends" << endl;
}

