#include <iostream>

using namespace std;

extern "C" int CountPrimes(long, long);

int main(void)
{
	long l, u;
	cout << "Enter lower and upper limits: ";
	cin >> l >> u;

	cout << "Number of Primes = "
	     << CountPrimes(l, u)
	     << endl;
}

