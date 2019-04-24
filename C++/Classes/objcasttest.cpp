#include <iostream>

using namespace std;

class Interval
{
public:

	Interval(long m=0, long s=0) 
	{
		minutes = m + s / 60;
		seconds = s % 60;
		id = 0;
	}

	int GetId() const
	{
		static int nid = 1;
		if(id == 0) 
			id = ++nid;
		return id;
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

	static const Interval* Primary()
	{
		static Interval first;
		first.id = 1;
		return &first;
	}

private:
	long minutes;
	long seconds;
	mutable int id; //mutable field - can be assigned in a const method
};

void Show(const Interval& entry)
{
	cout << "Interval with ID " << entry.GetId() << " is ";
	entry.Print();
}

int main(void)
{
	Interval jack(3, 45);
	Show(jack);

	Interval jill(4, 30);
	Show(jill);

	const Interval* john = Interval::Primary();
	Interval* j = const_cast<Interval*>(john);
	j->SetTime(70);
	struct _Interval
	{
		long minutes;
		long seconds;
		int id;
	};
	_Interval* jj = reinterpret_cast<_Interval*>(j);
	jj->id = 10;
	Show(*john);
}

