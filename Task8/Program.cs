class Program
{
	static void Main(string[] args)
	{

	}
	public static string RepeatStr(int n, string s)
	{
		var res = "";
		for (int i = 0; i < n; i++)
		{
			res += s;
		}
		return res;
	}
}