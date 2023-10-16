class Program
{
	static void Main(string[] args)
	{
		UpdateLight("green");
	}

	public static string UpdateLight(string current)
	{
		if (current == "green")
		{
			return "yellow";
		}
		else if (current == "yellow")
		{
			return "red";
		}
		else if (current == "red")
		{
			return "green";
		}
		return "exception";
	}
}