class Program
{
	static void Main(string[] args)
	{
		StringToNumber("2");
	}

	static void StringToNumber(String str)
	{
		Console.WriteLine(Convert.ToInt32(str));
	}
}