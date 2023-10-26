class Program
{
    static void Main(string[] args)
    {

    }
    public static bool IsTriangle(int a, int b, int c)
    {
        
        bool condition1 = a + b > c;
        bool condition2 = a + c > b;
        bool condition3 = b + c > a;

        
        return condition1 && condition2 && condition3;
       
    }
}