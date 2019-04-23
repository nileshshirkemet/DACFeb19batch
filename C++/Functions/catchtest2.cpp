#include <iostream>
#include <string>

using namespace std;

struct BadName {};

int Find(string item, string items[], int count)
{
	if(item.size() < 4)
	{
		BadName bn;
		throw bn;
	}
	for(int i = 0; i < count; ++i)
	{
		if(items[i] == item)
			return i;
	}
	//return -1;
	throw item;
}

void Run(void)
{
	string names[] = {"jack", "jill", "john", "jane"};
	long balances[] = {3000, 5000, 4000, 2000};
	string name;
	cout << "Name: ";
	cin >> name;
	int k = Find(name, names, 4);
	cout << "Balance: " << balances[k] << endl;
}

int main(void)
{
	cout << "Welcome to our bank" << endl;
	try
	{
		Run();
	}
	catch(...)
	{
		cout << "Operation failed!" << endl;
	}
	cout << "Goodbye" << endl;
}

