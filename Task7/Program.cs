using System.Linq;
class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine(Longest("acdvfbh", "asscvbmfmg"));
	}
	public static string Longest(string s1, string s2)
	{
		string combinate = s1 + s2;

		string result = new string(combinate.Distinct().OrderBy(x => x).ToArray());

		return result;
	}
}