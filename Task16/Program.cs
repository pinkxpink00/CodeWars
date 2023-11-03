class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Accum("abcd"));    
        Console.WriteLine(Accum("RqaEzty")); 
        Console.WriteLine(Accum("cwAt"));
    }
    public static String Accum(string s)
    {
        string result = "";

        for(int i  = 0; i < s.Length; i++)
        {
            result += char.ToUpper(s[i]);

            for (int j = 0; j < i; j++)
            {
                result += char.ToLower(s[i]);
            }
            
            if (i < s.Length - 1)
            {
                result += "-";
            }
        }
        return result;
    }
}