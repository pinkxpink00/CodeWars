class Program
{
	static void Main(string[] args)
	{

	}

	public static int SumMix(object[] x)
	{
		int sum = 0;

		foreach (var element in x)
		{
			if (element is int)
			{
				sum += (int)element;
			}
			else if (element is string)
			{
				if (int.TryParse((string)element, out int num))
				{
					sum += num;
				}
			}
		
		}
		return sum;
	}
}