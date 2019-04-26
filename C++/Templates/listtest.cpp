#include "interval.h"
#include <iostream>
#include <list>

using namespace std;

int main(void)
{
	list<Interval> store;
	store.push_back(Interval(5, 31));
	store.push_back(Interval(7, 42));
	store.push_back(Interval(6, 13));
	store.push_back(Interval(4, 54));
	store.push_back(Interval(3, 25));
	store.push_front(Interval(2, 40));

	for(list<Interval>::iterator i = store.begin(); i != store.end(); ++i)
		cout << *i << "\t" << i->Time() << endl;
}

