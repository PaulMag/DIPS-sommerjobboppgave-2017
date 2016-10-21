using System;
using System.Collections.Generic;


public class Account
{
    public Person customer;  // Owner of account.
    public Money balance;
    public int serialno;  // Is only unique for the same customer.
    public string name; // customer.name + serialno

    public Account(Person customer, int serialno)
    {
        this.customer = customer;
        this.serialno = serialno;
        balance = 0;
        name = customer.name + serialno;
    }

    public void print()  // Print info about this Account.
    {
        System.Console.WriteLine();
        System.Console.WriteLine("account: " + name);
        System.Console.WriteLine("balance: " + balance);
    }
}
