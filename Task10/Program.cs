class Program
{
	static void Main(string[] args)
	{

	}
	public static int CountSheeps(bool[] sheeps)
	{
		int count = 0;
		foreach (bool b in sheeps)
		{
			if (b == true)
			{
				count++;
			}
		}
		return count;
	}

}