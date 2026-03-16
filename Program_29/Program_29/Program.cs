using System;

class Rect
{
    double length;
    double width;
    public Rect()
    {
        length = 0;
        width = 0;
    }

    public Rect(double l, double w)
    {
        length = l;
        width = w;
    }
    public double FindArea()
    {
        return length * width;
    }

    public void Display()
    {
        Console.WriteLine("Length: " + length);
        Console.WriteLine("Width: " + width);
        Console.WriteLine("Area: " + FindArea());
    }
}

class Program
{
    static void Main()
    {
        Rect r1 = new Rect();
        Console.WriteLine("Rectangle 1 (Default Constructor)");
        r1.Display();

        Console.WriteLine();

        Rect r2 = new Rect(10, 5);
        Console.WriteLine("Rectangle 2 (Parameterized Constructor)");
        r2.Display();
    }
}