using System;
using System.Collections.Generic;


public class Account
{
    public Person customer;
    public double balance;
    public int serialno;  // Is only unique for the same customer.
    public string name; // customer.name + serialno

    public Account(Person customer, int serialno)
    {
        this.customer = customer;
        this.serialno = serialno;
        balance = 0;
        name = customer.name + serialno;
    }

    public void print()  // For testing.
    {
        System.Console.WriteLine(name);
        System.Console.WriteLine(balance);
        System.Console.WriteLine();
    }
}
