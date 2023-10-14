class Program
{
	static void Main(string[] args)
	{
		HoopCount(22);
	}

	public static string HoopCount(int n)
	{
		if(n > 10 || n == 10)
{
			return "Great, now move on to tricks";
		}
        else if (n < 10)
		{
			return "Keep at it until you get it";
		}

		return "";
	}
}