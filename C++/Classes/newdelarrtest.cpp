#include <iostream>

using namespace std;

class Interval
{
public:

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

int main(void)
{
	int n;
	cout << "Number of Intervals: ";
	cin >> n;

	Interval* store = new Interval[n];
	for(int i = 0; i < n; ++i)
	{
		store[i].SetTime(100 + 50 * i);
		store[i].Print();
	}
	delete[] store;
}

