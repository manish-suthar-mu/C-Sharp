using System;
class Student
{
    int rollNo;
    string name;
    int marks;
    public Student()
    {
        rollNo = 0;
        name = "Unknown";
        marks = 0;
    }
    public Student(int r, string n, int m)
    {
        rollNo = r;
        name = n;
        marks = m;
    }
    public string Grade()
    {
        if (marks >= 90)
            return "A";
        else if (marks >= 75)
            return "B";
        else if (marks >= 50)
            return "C";
        else
            return "Fail";
    }
    public void Display()
    {
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Marks: " + marks);
        Console.WriteLine("Grade: " + Grade());
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student();
        s1.Display();

        Console.WriteLine();

        Student s2 = new Student(101, "Manish", 92);
        s2.Display();
    }
}