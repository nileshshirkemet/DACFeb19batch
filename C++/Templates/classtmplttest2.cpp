#include <iostream>
#include <string>

using namespace std;

template<typename I, typename V>
class IndexedValue
{
public:
	IndexedValue(const I& i, const V& v) : index(i), value(v)
	{
	}

	void Print() const
	{
		cout << "[" << index << "] = " << value << endl;
	}
private:
	I index;
	V value;
};

int nid = 0;

template<>
class IndexedValue<int, string> //full specialization
{
public:
	IndexedValue(const string& v) : value(v)
	{
		index = ++nid;
	}

	void Print() const
	{
		cout << "[" << index << "] = '" << value << "'" << endl;
	}
private:
	int index;
	string value;
};


int main(void)
{
	IndexedValue<string, double> a("first", 5.6);
	a.Print();

	IndexedValue<int, double> b(2, 6.7);
	b.Print();

	IndexedValue<int, string> c("Monday");
	c.Print();
}

