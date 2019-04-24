#include "payroll2.h"
#include <iostream>

using namespace Payroll;
using namespace std;

class Dealer : public SalesPerson
{
public:
	Dealer(double s) : SalesPerson(0, 0, s)
	{
	}

	double GetIncome() const
	{
		return 0.15 * GetSales();
	}
};

double GetTotalSales(Employee* group[], int count)
{
	double total = 0;
	for(int i = 0; i < count; ++i)
	{
		SalesPerson* sp = dynamic_cast<SalesPerson*>(group[i]); //explicit downcasting
		if(sp)
			total += sp->GetSales();
	}
	return total;
}

int main(void)
{
	Employee* dept[6];
	dept[0] = new Employee(186, 52);
	dept[1] = new Employee(195, 85);
	dept[2] = new SalesPerson(160, 40, 60000); //implicit upcasting
	dept[3] = new Employee(170, 210);
	dept[4] = new SalesPerson(190, 50, 40000); 
	dept[5] = new Dealer(200000);
	cout << "Total Sales = "
		 << GetTotalSales(dept, 6)
		 << endl;

	for(int i = 0; i < 5; ++i)
		delete dept[i];
}

