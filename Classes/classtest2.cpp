#include <iostream>

using namespace std;

class Interval
{
public:
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

float Speed(float distance, Interval duration)
{
	return 3.6 * distance / duration.GetTime();
}

int main(void)
{
	Interval jack;
	jack.SetTime(125); 
	Interval john;
	john.SetTime(200); 
	cout << "Jack's Interval = ";
	jack.Print();
	cout << "Jack's speed = " << Speed(500, jack) << endl;
	cout << "John's Interval = ";
	john.Print();
	cout << "John's speed = " << Speed(500, john) << endl;
}

