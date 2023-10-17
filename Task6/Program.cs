using System.Text;
using System;

class Program
{
	static void Main(string[] args)
	{

	}

	public static int SquareDigits(int n)
	{
		
		StringBuilder squaredDigits = new StringBuilder();

		
		string numStr = n.ToString();

		
		foreach (char digitChar in numStr)
		{
			int digit = int.Parse(digitChar.ToString());
			int squaredDigit = digit * digit;
			squaredDigits.Append(squaredDigit);
		}

		
		return int.Parse(squaredDigits.ToString());

		
	}
}