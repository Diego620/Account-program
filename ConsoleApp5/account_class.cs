using System;
namespace Practical1;

class Account
{
    int acc_num;
    String name;
    String type;
    double balance;

    Account(int acc_num, string name, string type, double balance)
    {
        this.acc_num = acc_num;
        this.name = name;
        this.type = type;
        this.balance = balance; ;
    }

    public void withdraw(double amount)
    {
        balance -= amount;
        System.Console.WriteLine("You withdrawed: " + amount + "Your balance is:" + balance);

    }
}

