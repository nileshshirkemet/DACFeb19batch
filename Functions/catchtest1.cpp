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
	try
	{
		int k = Find(name, names, 4);
		cout << "Balance: " << balances[k] << endl;
	}
	catch(string e)
	{
		cout << "No such name: " << e << endl;
	}
	catch(BadName)
	{
		cout << "Name is too small" << endl;
	}
}

int main(void)
{
	cout << "Welcome to our bank" << endl;
	Run();
	cout << "Goodbye" << endl;
}

