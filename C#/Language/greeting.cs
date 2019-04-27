namespace Greeting
{
	public class Greeter
	{
		private bool formal;

		public Greeter(bool f)
		{
			formal = f;
		}

		public string Meet(string person)
		{
			if(formal)
				return "Hello " + person;
			return "Hi " + person;
		}

		public string Leave(string person)
		{
			return "Bye " + person;
		}
	}
}
