#include "banking.h"
#include <iostream>

using namespace Banking;
using namespace std;

void PayAnnualInterest(Account* group[], int count)
{
	for(int i = 0; i < count; ++i)
	{
		Profitable* p = dynamic_cast<Profitable*>(group[i]); //explicit side-casting
		if(p)
		{
			double amt = p->GetInterest(1);
			group[i]->Deposit(amt); 
		}
	}
}

int main(void)
{
	Account* bank[4];
	bank[0] = OpenSavingsAccount();
	bank[0]->Deposit(5000);
	bank[1] = OpenCurrentAccount();
	bank[1]->Deposit(20000);
	bank[2] = OpenCurrentAccount();
	bank[2]->Deposit(30000);
	bank[3] = OpenSavingsAccount();
	bank[3]->Deposit(35000);

	PayAnnualInterest(bank, 4);

	for(int i = 0; i < 4; ++i)
	{
		cout << (i + 1) << "\t" << bank[i]->Balance() << endl;
		CloseAccount(bank[i]);
	}
}

