#ifndef INTERVAL
#define INTERVAL
#include <iostream>

class Interval
{
public:
	explicit Interval(long m=0, long s=0)
	{
		minutes = m + s / 60;
		seconds = s % 60;
	}

	long Minutes() const
	{
		return minutes;
	}

	long Seconds() const
	{
		return seconds;
	}

	long Time() const
	{
		return 60 * minutes + seconds;
	}

	bool operator==(const Interval& other) const
	{
		return (minutes == other.minutes) && (seconds == other.seconds);
	}

	bool operator<(const Interval& other) const
	{
		long t1 = 60 * minutes + seconds;
		long t2 = 60 * other.minutes + other.seconds;
		return t1 < t2;
	}
private:
	long minutes;
	long seconds;
friend std::ostream& operator<<(std::ostream& out, const Interval& value);
};

std::ostream& operator<<(std::ostream& out, const Interval& value)
{
	if(value.seconds < 10)
		out << value.minutes << ":0" << value.seconds;
	else
		out << value.minutes << ":" << value.seconds;
	return out;
}

#endif

