using System;
using System.Collections.Generic;


public class Bank
{
    public List<Account> accounts;

    public Bank()
    {
        accounts = new List<Account>();
    }

    public Account CreateAccount(Person customer, Money initialDeposit)
    {
        if (initialDeposit <= customer.balance) {
            Account newAccount = new Account(
                customer,
                GetAccountsForCustomer(customer).Length + 1
            );
            Deposit(newAccount, initialDeposit);
            accounts.Add(newAccount);
            return newAccount;
        }
        else {
            return null;
        }
    }

    public Account[] GetAccountsForCustomer(Person customer)
    {
        List<Account> customerAccounts = new List<Account>();
        foreach (Account account in accounts) {
            if (account.customer == customer) {
                customerAccounts.Add(account);
            }
        }
        return customerAccounts.ToArray();
    }

    public void Deposit(Account to, Money amount)
    {
        if (amount <= to.customer.balance) {
            to.customer.balance -= amount;
            to.balance += amount;
        }
    }

    public void Withdraw(Account from, Money amount)
    {
       if (amount <= from.balance) {
            from.balance -= amount;
            from.customer.balance += amount;
        }
    }

    public void Transfer(Account from, Account to, Money amount)
    {
       if (amount <= from.balance) {
            from.balance -= amount;
            to.balance += amount;
        }
    }
}
