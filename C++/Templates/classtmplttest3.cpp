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

template<typename V>
class IndexedValue<int, V> //partial specialization
{
public:
	IndexedValue(const V& v) : value(v)
	{
		index = ++nid;
	}

	void Print() const
	{
		cout << "[" << index << "] = (" << value << ")" << endl;
	}
private:
	int index;
	V value;
};


int main(void)
{
	IndexedValue<string, double> a("first", 5.6);
	a.Print();

	IndexedValue<int, double> b(6.7);
	b.Print();

	IndexedValue<int, string> c("Monday");
	c.Print();
}

