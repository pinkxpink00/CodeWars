class Program
{
    static void Main(string[] args)
    {

    }
    public static string FakeBin(string x)
    {
        char[] res = new char[x.Length];

        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] < '5')
            {
                res[i] = '0';
            }
            else
            {
                res[i] = '1';
            }
        }

        return new string(res);
    }
}