class Program
{
    static void Main(string[] args)
    {

    }
    public static int RentalCarCost(int d)
    {
        int dailyRate = 40;
        int threeDayDiscount = 20;
        int weeklyDiscount = 50;

        int calculatedCost = 0;

        calculatedCost = d * dailyRate;

        if ((d >= 3) && (d <= 6))
            calculatedCost = calculatedCost - threeDayDiscount;

        if (d >= 7)
            calculatedCost = calculatedCost - weeklyDiscount;

        return calculatedCost;
    }
}