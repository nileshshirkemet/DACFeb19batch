	static int SquareOne(double* pVal)
	{
		double value = *pVal;
		if(value > 0)
		{
			*pVal = value * value;
			return 1;
		}
		return 0;
	}
	
	static double SquareAll(double* values, int count)
	{
		double sum = 0;
		int i;
		for(i = 0; i < count; ++i)
		{
			if(SquareOne(values + i) == 1)
				sum += values[i];
		}
		return sum;
	} 

