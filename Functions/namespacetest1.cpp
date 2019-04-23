int age = 43;

namespace Jack
{
	int age = 22;
}

int main(void)
{
	int age = 34;
	return age + ::age + Jack::age;		
}

