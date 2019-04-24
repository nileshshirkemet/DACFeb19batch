#ifndef BANKING
#define BANKING

namespace Banking
{
	class InsufficientFunds{};

	class Account
	{
	public:
		double Balance() const;
		virtual void Deposit(double) = 0; //pure virtual member function
		virtual void Withdraw(double) throw(InsufficientFunds) = 0; 
		void Transfer(double, Account*) throw(InsufficientFunds);
		virtual ~Account(){}
	protected:
		double balance;
	};

	//factory functions
	Account* OpenCurrentAccount();
	Account* OpenSavingsAccount();
	void CloseAccount(Account*);
}



#endif
