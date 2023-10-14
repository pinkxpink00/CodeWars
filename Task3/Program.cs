class Program
{
	static void Main(string[] args)
	{
		HoopCount(22);
	}

	static void HoopCount(int n)
	{
		if (n > 10)
		{
            Console.WriteLine("Great, now move on to tricks");
        }
		else
		{
            Console.WriteLine("Keep at it until you get it");
        }
	}
}