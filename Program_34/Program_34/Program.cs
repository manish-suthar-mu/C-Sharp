using System;

class Error
{
    static void Main(String[] args)
    {
        try
        {
            int a = 10;
            int b = 0;
            int c = a / b;
            Console.WriteLine(c);
        }
        catch (Exception e) 
        { 
            Console.WriteLine("Error : ZeroDivisionError: division by zero....");
        }
    }
}