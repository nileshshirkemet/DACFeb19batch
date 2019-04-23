#include <iostream>

using namespace std;

class Interval
{
public:
	
	Interval(long s=0, long m=0)
	{
		seconds = 60 * m + s; 
		++count; 
	}
	
	long GetTime() const //long _ZNK8Interval7GetTimeEv(const Interval* this)
	{
		return seconds; //this->seconds
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

	static int CountInstances() 
	{
		return count;
	}

	~Interval()
	{
		count--;
	}

private:
	long seconds; 
	static int count;
};

int Interval::count = 0;

float Speed(float distance, const Interval& duration) 
{
	return 3.6 * distance / duration.GetTime(); //_ZNK8Interval7GetTimeEv(&duration)
}

int main(void)
{
	Interval jack; 
	jack.SetTime(125); 
	cout << "Jack's Interval = ";
	jack.Print();
	cout << "Jack's Speed = " << Speed(500, jack) << endl;
	Interval jeff(70, 3); 
	cout << "Jeff's Interval = ";
	jeff.Print();
	cout << "Jeff's Speed = " << Speed(500, jeff) << endl;
	cout << "Number of active Interval =  " << Interval::CountInstances() << endl;
}

