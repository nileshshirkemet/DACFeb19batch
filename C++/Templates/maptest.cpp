#include "interval.h"
#include <iostream>
#include <string>
#include <map>

using namespace std;

int main(void)
{
	map<string, Interval> store;
	store.insert(make_pair("monday", Interval(5, 31)));
	store.insert(make_pair("tuesday", Interval(7, 42)));
	store.insert(make_pair("wednesday", Interval(6, 13)));
	store.insert(make_pair("thursday", Interval(4, 54)));
	store.insert(make_pair("friday", Interval(3, 25)));

	for(map<string, Interval>::iterator i = store.begin(); i != store.end(); ++i)
		cout << i->second << "\t" << i->first << endl;

	string k;
	cout << "Key: ";
	cin >> k;
	map<string, Interval>::iterator j = store.find(k);
	if(j != store.end())
		cout << "Value = " << j->second << endl;
	else
		cout << "No such key!" << endl;
}

