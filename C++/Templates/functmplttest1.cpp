#include <iostream>
#include <string>

using namespace std;

/*
void Swap(double& first, double& second)
{
	double third = first;
	first = second;
	second = third;
}

void Swap(string& first, string& second)
{
	string third = first;
	first = second;
	second = third;
}
*/

template<typename T>
void Swap(T& first, T& second) //Swap function template
{
	T third = first;
	first = second;
	second = third;
}
int main(void)
{
	double dx = 3.4, dy = 4.3;
	cout << "Original double values: " << dx << ", " << dy << endl;
	Swap<double>(dx, dy); //calling templated Swap function for T=double
	cout << "Swapped double values: " << dx << ", " << dy << endl;

	string sx = "Monday", sy = "Tuesday" ;
	cout << "Original string values: " << sx << ", " << sy << endl;
	Swap(sx, sy); //Swap<string>(sx, sy)
	cout << "Swapped string values: " << sx << ", " << sy << endl;
}

