#pragma once

typedef struct{
	long id;
	double amount;
	long period;
}FixedDeposit;

typedef float (*Scheme)(long);

int InitFixedDeposit(double amount, long period, FixedDeposit* fd);

double GetMaturityValue(const FixedDeposit* fd, Scheme policy);












