using System;

class Account
{
    public int accountNumber;
    public double balance;

    public Account(int accNo, double bal)
    {
        accountNumber = accNo;
        balance = bal;
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposited: " + amount);
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine("Balance: " + balance);
    }
}

class SavingsAccount : Account
{
    public SavingsAccount(int accNo, double bal)
        : base(accNo, bal)
    {
    }
}

class CurrentAccount : Account
{
    public CurrentAccount(int accNo, double bal)
        : base(accNo, bal)
    {
    }
}

class Program
{
    static void Main()
    {
        SavingsAccount s = new SavingsAccount(101, 2000);

        s.Deposit(500);
        s.Withdraw(1000);
        s.CheckBalance();

        Console.WriteLine();

        CurrentAccount c = new CurrentAccount(102, 3000);

        c.Deposit(1000);
        c.Withdraw(2000);
        c.CheckBalance();
    }
}