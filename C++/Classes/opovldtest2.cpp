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

	long operator[](int index) const
	{
		return index ? (seconds / 60) : (seconds % 60);
	}

	operator float() const
	{
		return seconds / 60.0;
	}
private:
	long seconds;
};

int main(void)
{
	Interval a(3, 45);
	cout << a[1] << "'" << a[0] << "''" << endl;  
	float b = a;
	cout << b << endl;
}

