class Program
{
	static void Main(string[] args)
	{

	}
	public static int TotalPoints(string[] games)
	{
		int total = 0;

		foreach (string game in games)
		{
			if (game[0] > game[2])
			{
				total += 3;
			}
			else if (game[0] == game[2])
			{
				total += 1;
			}

		}

		return total;
	}
}