#define _TESTING
#include "payroll2.h"
#include <iostream>

using namespace Payroll;
using namespace std;

double GetAverageIncome(Employee* group[], int count)
{
	double total = 0;
	for(int i = 0; i < count; ++i)
	{
		total += group[i]->GetIncome();
	}
	return total / count;
}

int main(void)
{
	Employee* dept[5];
	dept[0] = new Employee(186, 52);
	dept[1] = new Employee(195, 85);
	dept[2] = new SalesPerson(160, 40, 60000); //implicit upcasting
	dept[3] = new Employee(170, 210);
	dept[4] = new SalesPerson(190, 50, 40000); 

	cout << "Average Income = "
		 << GetAverageIncome(dept, 5)
		 << endl;

	for(int i = 0; i < 5; ++i)
		delete dept[i];
}

