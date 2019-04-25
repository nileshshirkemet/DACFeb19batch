#include <iostream>

using namespace std;

class TaxPayer 
{
public:
	TaxPayer(long pn)
	{
		pin = pn;
	}

	long PIN() const
	{
		return pin;
	}

	virtual double GetAnnualIncome() const = 0;

	double GetIncomeTax() const
	{
		double ex = GetAnnualIncome() - 120000;
		return ex > 0 ? 0.15 * ex : 0;
	}

	virtual ~TaxPayer(){}
private:
	long pin;
};

void Print(const TaxPayer& payer) 
{
	cout << "P.I.N is " << payer.PIN()
		 << " and Tax is " << payer.GetIncomeTax()
		 << endl;
}

class Employee : public virtual TaxPayer
{
public:
	Employee(double sy, long pn=0) : TaxPayer(pn)
	{
		salary = sy;
	}

	double GetAnnualIncome() const
	{
		return 12 * salary + 20000;
	}
private:
	double salary;
};

class Dealer : public virtual TaxPayer
{
public:
	Dealer(double ss, long pn=0) : TaxPayer(pn)
	{
		sales = ss;
	}

	double GetAnnualIncome() const
	{
		return 0.15 * sales;
	}
private:
	double sales;
};

class SalesPerson : public Employee, public Dealer
{
public:
	SalesPerson(double sy, double ss, long pn) : Employee(sy), Dealer(ss), TaxPayer(pn)
	{
	}

	double GetAnnualIncome() const
	{
		return Employee::GetAnnualIncome() - 20000 + Dealer::GetAnnualIncome() / 3;
	}
};

int main(void)
{
	Employee jill(24000, 123456);
	Dealer jack(3600000, 234567);
	SalesPerson john(15000, 2100000, 345678);

	cout << "Jill the Employee: ";
	Print(jill);
	cout << "Jack the Dealer: ";
	Print(jack);
	cout << "John the SalesPerson: ";
	Print(john);

	cout << &jill << "\t" << static_cast<TaxPayer*>(&jill) << endl;
}

