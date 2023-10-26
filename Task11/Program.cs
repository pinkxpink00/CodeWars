//Given an array of integers.

//Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers. 0 is neither positive nor negative.

//If the input is an empty array or is null, return an empty array.

class Program
{
    static void Main()
    {

    }
    public static int[] CountPositivesSumNegatives(int[] input)
    {
       
        if (input == null || input.Length == 0)
        {
            return new int[0];
        }

        int countPositives = 0;
        int sumNegatives = 0;

        foreach (int num in input)
        {
            if (num > 0)
            {
                countPositives++;
            }
            else if (num < 0)
            {
                sumNegatives += num; 
            }
        }

        
        int[] result = { countPositives, sumNegatives };
        return result;
    }
}