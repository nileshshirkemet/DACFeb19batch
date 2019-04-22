#include <iostream>

using namespace std;

class Interval
{
public:
	//default (zero-argument) constructor 
	Interval()
	{
		seconds = 0;
	}
	
	//conversion (single-argument) constructor
	Interval(long time)
	{
		seconds = time;
	}

	//parameterized constructor
	Interval(long m, long s)
	{
		seconds = 60 * m + s;
	}
	
	long GetTime()
	{
		return seconds;
	}

	void SetTime(long value)
	{
		seconds = value; 
	}

	void Print() 
	{
		long m = seconds / 60, s = seconds % 60;
		if(s < 10)
			cout << m << ":0" << s << endl;
		else
			cout << m << ":" << s << endl;
	}
private:
	long seconds;
};


int main(void)
{
	Interval jack; //activation using default constructor
	jack.SetTime(125); 
	Interval john = 200; //activation using conversion constructor 
	cout << "Jack's Interval = ";
	jack.Print();
	cout << "John's Interval = ";
	john.Print();
	Interval jeff(3, 70); //activation using parameterized constructor
	cout << "Jeff's Interval = ";
	jeff.Print();
}

