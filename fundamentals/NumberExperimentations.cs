using System;
namespace fundamentals
{
	public class NumberExperimentations
	{
		public static int AddNumberTestIfAboveThanTen(int a, int b)
		{
			if(a > 10)
			{
				return a + b;
			}
			return a - b;
		}

		public static bool IsLong(string input)
		{
			if(input.Length > 0)
			{
				return true;
			}

			return false;
		}
	}
}

