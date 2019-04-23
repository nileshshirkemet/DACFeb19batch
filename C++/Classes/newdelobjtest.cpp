#include <iostream>

using namespace std;

class Interval
{
public:

	//single argument constructor which cannot be used as a conversion constructor
	explicit Interval(long time=0) 
	{
		minutes = time / 60;
		seconds = time % 60;
		cout << "Interval object activated" << endl;
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

float Speed(float distance, const Interval& duration) 
{
	return 3.6 * distance / duration.GetTime();
}

int main(void)
{
	Interval* jack = new Interval; //dynamic activation of Interval using default constructor
	jack->SetTime(125); 
	Interval* john = new Interval(200); //dynamic activation of Interval using parameterized constructor
	cout << "Jack's Interval = ";
	jack->Print();
	cout << "Jack's speed = " << Speed(500, *jack) << endl;
	cout << "John's Interval = ";
	john->Print();
	cout << "John's speed = " << Speed(500, *john) << endl;
	delete john; //explicit deactivation of a dynamically activated object
	delete jack;
}

