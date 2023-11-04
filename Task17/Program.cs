class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(SwitchItUp(4));
    }
    public static string SwitchItUp(int number)
    {
        string result = "";
        switch (number)
        {
            case 0:
                result = "Zero";
                break;
            case 1:
                result = "One";
                break;
            case 2:
                result = "Two";
                break;
            case 3:
                result = "Three";
                break;
            case 4:
                result = "Four";
                break;
            case 5:
                result = "Five";
                break;
            case 6:
                result = "Six";
                break;
            case 7:
                result = "Seven";
                break;
            case 8:
                result = "Eight";
                break;
            case 9:
                result = "Nine";
                break;
            default:
                result = "Invalid input";
                break;
        }
        return result;
    }
}