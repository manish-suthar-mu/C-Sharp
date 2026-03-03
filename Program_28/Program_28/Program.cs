using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];
        int sum = 0;
        double average;

        Console.WriteLine("Enter 5 numbers:");

        for (int i = 0; i < 5; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
            sum += numbers[i];
        }

        average = (double)sum / 5;

        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Average = " + average);
    }
}