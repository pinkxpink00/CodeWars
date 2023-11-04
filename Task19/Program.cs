class Program
{
    static void Main(string[] args)
    {

    }
    public static string Correct(string text)
    {
       
        text = text.Replace('0', 'O').Replace('1', 'I').Replace('5', 'S');

        return text;
    }
}