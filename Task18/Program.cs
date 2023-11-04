class Program
{
    static void Main(string[] args)
    {

    }
    public static int Number(List<int[]> peopleList)
    {
        int totalPeople = 0;

        foreach (var stop in peopleList)
        {
            totalPeople += stop[0]; // People getting on the bus
            totalPeople -= stop[1]; // People getting off the bus
        }

        return totalPeople;
    }
}