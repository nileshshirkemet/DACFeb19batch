#include "interval.h"
#include <iostream>
#include <queue>
#include <vector>
#include <functional>
#include <utility>

using namespace std;
using std::rel_ops::operator>;

int main(void)
{
	//priority_queue<Interval> store;
	priority_queue<Interval, vector<Interval>, greater<Interval> > store;
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

