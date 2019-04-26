#include "interval.h"
#include <iostream>
#include <stack>
#include <list>

using namespace std;

int main(void)
{
	//stack<Interval> store;
	stack<Interval, list<Interval> > store;
	store.push(Interval(5, 31));
	store.push(Interval(7, 42));
	store.push(Interval(6, 13));
	store.push(Interval(4, 54));
	store.push(Interval(3, 25));

	while(!store.empty())
	{
		cout << store.top() << endl;
		store.pop();
	}
}

