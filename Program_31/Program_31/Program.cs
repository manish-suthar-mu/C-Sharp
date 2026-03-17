using System;

class Employee
{
    int employeeId;
    string name;
    int salary;
    public Employee()
    {
        employeeId = 0;
        name = "Unknown";
        salary = 0;
    }

    public Employee(int id, string n, int sal)
    {
        employeeId = id;
        name = n;
        salary = sal;
    }
    public double CalSalary()
    {
        return salary * 12;
    }

    public void Display()
    {
        Console.WriteLine("Employee ID: " + employeeId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Monthly Salary: " + salary);
        Console.WriteLine("Annual Salary: " + CalSalary());
    }
}

class Program
{
    static void Main()
    {
        Employee e1 = new Employee();
        e1.Display();
        Console.WriteLine();
        Employee e2 = new Employee(101, "Manish", 25000);
        e2.Display();
    }
}