#include <iostream>

using namespace std;

class Interval
{
public:
	long GetTime()
	{
		return 60 * minutes + seconds;
	}

	void SetTime(long value) //void _ZN8Interval7SetTimeEl(Interval* this, long value)
	{
		minutes = value / 60; //this->minutes = value / 60
		seconds = value % 60; //this->seconds = value % 60
	}

	void Print() 
	{
		if(seconds < 10)
			cout << minutes << ":0" << seconds << endl;
		else
			cout << minutes << ":" << seconds << endl;
	}
private:
	long minutes;
	long seconds;
};

float Speed(float distance, Interval duration)
{
	return 3.6 * distance / duration.GetTime();
}

int main(void)
{
	Interval jack;
	jack.SetTime(125); //_ZN8Interval7SetTimeEl(&jack, 125)
	Interval john;
	john.SetTime(200); //_ZN8Interval7SetTimeEl(&john, 200)
	cout << "Jack's Interval = ";
	jack.Print();
	cout << "Jack's speed = " << Speed(500, jack) << endl;
	cout << "John's Interval = ";
	john.Print();
	cout << "John's speed = " << Speed(500, john) << endl;
}

