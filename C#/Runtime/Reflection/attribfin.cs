using System;

namespace Finance
{	
	public interface ILoanPolicy
	{
		float GetInterestRate(int period);
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class MaxDurationAttribute : Attribute
	{
		public int Limit {get; set;}

		public MaxDurationAttribute(int limit = 5) => Limit = limit;
	}

	[MaxDuration]
	public class EducationLoan : ILoanPolicy
	{
		public float GetInterestRate(int period)
		{
			return 6;
		}
	}
	
	[MaxDuration(12)]
	public class HomeLoan : ILoanPolicy
	{
		public float GetInterestRate(int period)
		{
			return period < 10 ? 7 : 8;
		}
	}

	[MaxDuration(Limit = 4)]
	public class PersonalLoan : ILoanPolicy
	{
		public float GetInterestRate(int period)
		{
			return period < 3 ? 8 : 9;
		}
	}

	[Serializable]
	public class BusinessLoan : ILoanPolicy
	{
		public float GetInterestRate(int period)
		{
			return 10 + 0.5f * (period / 3);
		}
	}

}
