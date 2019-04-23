#include <iostream>
#include <cmath>

using namespace std;

double Income(double invest, short duration, float rate=4)
{
	double amount = invest * pow(1 + rate / 100, duration);
	return amount - invest;
}

int main(void)
{
	double p;
	short n;

	cout << "Enter investment and duration: ";
	cin >> p >> n;

	cout << "Income from fixed-deposit: "
		 << Income(p, n, 6)
		 << endl;
	cout << "Income from savings-account: "
		 << Income(p, n)
		 << endl;
}

