#include "banking.h"
#include <iostream>

using namespace Banking;
using namespace std;

int main(void)
{
	Account* jack = OpenCurrentAccount();
	jack->Deposit(10000);
	Account* jill = OpenSavingsAccount();
	jill->Deposit(5000);
	double payment;
	cout << "Amount to transfer: ";
	cin >> payment;
	try
	{
		jill->Transfer(payment, jack);
		cout << "Funds transferred" << endl;
	}
	catch(InsufficientFunds)
	{
		cout << "Transfer failed due to lack of funds!" << endl;
	}
	cout << "Jack's Balance = " << jack->Balance() << endl;
	cout << "Jill's Balance = " << jill->Balance() << endl;
	CloseAccount(jack);
	CloseAccount(jill);
}

