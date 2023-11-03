class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsIsogram("mOose"));
        Console.WriteLine(IsIsogram("aba"));
        Console.WriteLine(IsIsogram("German"));
    }
    public static bool IsIsogram(string str)
    {
        HashSet<char> seenChar = new HashSet<char>();

        foreach (char c in str.ToLower())
        {
            if (seenChar.Contains(c))
            {
                return false;
            }

            seenChar.Add(c);
        }

        return true;
    }
}