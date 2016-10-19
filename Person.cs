using System;
using System.Collections.Generic;


public class Person
{
    public string name;
    public double balance;

    public Person(string name, double initialBalance)
    {
        this.name = name;
        this.balance = initialBalance;
    }

    public void print()  // For testing.
    {
        System.Console.WriteLine(name);
        System.Console.WriteLine(balance);
        System.Console.WriteLine();
    }
}
