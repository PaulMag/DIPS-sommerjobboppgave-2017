using System;
using System.Collections.Generic;


public class Testing
{
    /* This is a test script showing an example of how all the functionality in
     * the classes Person, Account, Bank, and Money can be used.
     * To verify that everything is working as intended, run this script, then
     * look at the commands and their comments step by step and verify that the
     * results printed in the terminal for each command are as expected.
     */

    public static void Main()
    {
        Bank bank = new Bank();

        Person p1 = new Person("Abraham", 5000);
        Person p2 = new Person("Berit", 10005);

        p1.print();  // $ 50.00 in cash
        p2.print();  // $ 100.05 in cash

        Account a1 = bank.CreateAccount(p1, 6000);
            // Abraham cannot afford this account, so it is not created.
            // a1 = null
        Account a2 = bank.CreateAccount(p1, 3000);
        Account a3 = bank.CreateAccount(p1, 500);
            // These accounts are created.

        p1.print();
            // Abraham has 50.00-30.00-5.00 = $ 15.00 left in his pocket.

        foreach (Account account in bank.GetAccountsForCustomer(p1)) {
            account.print();
            // Abraham's accounts 1 and 2 should contain $ 30.00 and $ 5.00.
        }

        Account a4 = bank.CreateAccount(p2, 0);
        Account a5 = bank.CreateAccount(p2, 0);
            // Berit creates two empty accounts.

        bank.Deposit(a4, 10000);
            // She deposits $ 100.00 in the first one.
        bank.Deposit(a5, 10000);
            // This doesn't work, since she no longer has that amount of money.

        p2.print();
            // Berit now has $ 0.05 cash remaining.

        foreach (Account account in bank.GetAccountsForCustomer(p2)) {
            account.print();
            // Berit's accounts 1 and 2 should contain $ 100.00 and $ 0.00.
        }

        bank.Transfer(a4, a5, 4000);  // Transfer $ 40.00 from Berit1 to Berit2.
        a4.print();  // 100-40 = 60
        a5.print();  // 0+40 = 40

        bank.Transfer(a3, a5, 1000);
            // Abraham tries to transfer to Berit, but this account has not enough.
        bank.Transfer(a2, a5, 1000);
            // Abraham successfully transfers $ 100.00 to Berit's account.

        a2.print();  // 30-10=20
        a3.print();  // Transfer didn't happen, so still $ 5.00 here.
        a5.print();  // 40+10 = 50

        bank.Withdraw(a5, 7500);
            // Berit tries to withdraw $ 75.00 from account Berit2, but the
            // balance is not that high, so nothing happens.
        bank.Withdraw(a5, 750);
            // Berit successfully withdraws $ 7.50.

        p2.print();  // Berit has 0.05 + 7.50 = 7.55 in cash.
        a5.print();  // Account Berit2 has balance of 50.00 - 7.50 = 42.50

        System.Console.WriteLine("\nCreate a new bank.");
        Bank bank2 = new Bank();

        Account a6 = bank2.CreateAccount(p1, 100);
        bank2.CreateAccount(p1, 200);
        bank2.CreateAccount(p1, 300);
            // Abraham creates three new accounts in a different bank.

        System.Console.WriteLine("\nAbraham's accounts in the first bank:");
        foreach (Account account in bank.GetAccountsForCustomer(p1)) {
            account.print();
        }

        System.Console.WriteLine("\nAbraham's accounts in the second bank:");
        foreach (Account account in bank2.GetAccountsForCustomer(p1)) {
            account.print();
            // Each bank has their own set of serial numbers, so the account
            // names in the two banks can be the same.
            // If we wanted to I could make the serial
            // numbers also be unique across different banks by having an
            // account counter in the Person class.
        }

        bank.Transfer(a2, a6, 10);
            // Abraham transfers $ 0.10 from account 1 in the first bank to
            // account 2 in the second bank.

        a2.print();  // 20.00 - 0.10 = 19.90
        a6.print();  // 1.00 + 0.10 = 1.10
    }
}
