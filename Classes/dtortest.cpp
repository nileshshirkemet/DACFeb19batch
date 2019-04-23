#include <iostream>

using namespace std;

class Interval
{
public:
	
	Interval(long s=0, long m=0)
	{
		seconds = 60 * m + s; //initialization
		++count; //side-effect
	}
	
	long GetTime()
	{
		return seconds;
	}

	void SetTime(long value)
	{
		seconds = value; 
	}

	//instance method - must be called on an object.
	//receives 'this' argument which points to the object on which it is called
	void Print() 
	{
		long m = seconds / 60, s = seconds % 60;
		if(s < 10)
			cout << m << ":0" << s << endl;
		else
			cout << m << ":" << s << endl;
	}

	//static method - can be called on the class 
	//does not receive 'this' argument and as such it can only 
	//refer to other static members
	static int CountInstances()
	{
		return count;
	}

	//destructor - cancels side-effect of constructor
	~Interval()
	{
		count--;
	}

private:
	long seconds; //instance field - each object stores its own value
	static int count; //static field - all objects share its common value
};

int Interval::count = 0; //allocating memory for static field in global space

void Run(void)
{
	cout << "activating John's Interval" << endl;
	Interval john = 200;  
	cout << "John's Interval = ";
	john.Print();
	cout << "deactivating John's Interval" << endl;
	//stack-semantics - the destructor of an automatically activated object
	//is called as soon as it goes out of scope
}

int main(void)
{
	cout << "activating Jack's Interval" << endl;
	Interval jack; 
	jack.SetTime(125); 
	cout << "Jack's Interval = ";
	jack.Print();
	Run();
	cout << "activating Jeff's Interval" << endl;
	Interval jeff(70, 3); 
	cout << "Jeff's Interval = ";
	jeff.Print();
	cout << "Number of active Interval =  " << Interval::CountInstances() << endl;
	cout << "deactivating Jeff's Interval" << endl;
	cout << "deactivating Jack's Interval" << endl;
}

