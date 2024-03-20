using System;
namespace Practical1;

class Account
{
    int acc_num;
    {
        get { return acc_num_; }
        set { acc_num = value; }
    }
    string name;
    {
        get { return name; }
        set { name = value; }
    }
    string type;
    {
        get { return type;}
        set { type = value; }
    }
    double balance;
    {
        get { return balance; }
    }

    Account(int acc_num, string name, string type, double balance)
    {
        this.acc_num = acc_num;
        this.name = name;
        this.type = type;
        this.balance = balance; 
    }


    public void deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("You Deposited: " + amount + "Your balance is: " + balance);
    }
     public void withdraw(double amount)
    {
        balance -= amount;
        Console.WriteLine("You withdrawed: " + amount + "Your balance is:" + balance);

    }

    public void checkBalance()
    {
        Console.WriteLine("Your balance is: " + balance);
    }
}

