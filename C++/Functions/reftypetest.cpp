#include <iostream>

using namespace std;

void Swap(double& first, double& second)
{
	double third = first;
	first = second;
	second = third;
}

int main(void)
{
	double x = 3.4, y = 4.3;
	cout << "Original values: " << x << ", " << y << endl;
	Swap(x, y);
	cout << "Swapped values: " << x << ", " << y << endl;
}

