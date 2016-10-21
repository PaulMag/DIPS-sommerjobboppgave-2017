using System;
using System.Collections.Generic;


public class Person
{
    public string name;
    public Money balance;

    public Person(string name, Money initialBalance)
    {
        this.name = name;
        this.balance = initialBalance;
    }

    public void print()  // Print info about this Person.
    {
        System.Console.WriteLine();
        System.Console.WriteLine("person: " + name);
        System.Console.WriteLine("cash: " + balance);
    }
}
