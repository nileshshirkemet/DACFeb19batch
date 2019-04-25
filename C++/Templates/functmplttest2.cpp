#include <iostream>
#include <string>

using namespace std;

template<typename Any>
void Print(string name, Any value)
{
	cout << name << " = " << value << endl;
}

template<>
void Print(string name, bool value) //explicit specialization of Print function template for Any=bool
{
	cout << name << " = " << (value ? "true" : "false") << endl;
}

int main(void)
{
	double a = 5.6;
	Print("first", a);

	string b = "Monday";
	Print("second", b);

	bool c = true;
	Print("third", c);
}

