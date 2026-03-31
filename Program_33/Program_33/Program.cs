using System;

interface IResult
{
    bool Pass(int mark);
}

interface IDivision
{
    string Division(int average);
}

class Student : IResult, IDivision
{
    public bool Pass(int mark)
    {
        if (mark >= 50)
            return true;
        else
            return false;
    }

    public string Division(int average)
    {
        if (average >= 60)
            return "First Division";
        else if (average >= 50)
            return "Second Division";
        else if (average >= 40)
            return "Third Division";
        else
            return "Fail";
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        int marks = 55;
        int avg = 58;

        Console.WriteLine("Pass Status: " + s.Pass(marks));
        Console.WriteLine("Division: " + s.Division(avg));
    }
}