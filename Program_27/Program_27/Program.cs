using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[8];
        int pcount = 0;
        int ncount = 0;

        Console.WriteLine("Enter 8 numbers:");

        for (int i = 0; i < 8; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());

            if (numbers[i] > 0)
            {
                pcount++;
            }
            else if (numbers[i] < 0)
            {
                ncount++;
            }
        }

        Console.WriteLine("Positive numbers: " + pcount);
        Console.WriteLine("Negative numbers: " + ncount);
    }
}