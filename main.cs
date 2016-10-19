class Person
{
    Person()
    {
        //TODO constructor
    }
}


class Account
{
    Account()
    {
        //TODO constructor
    }
}


class Bank
{
    Bank()
    {
        //TODO constructor
    }

    Account CreateAccount(Person customer, Money initialDeposit)
    {
        //TODO
    }

    Account[] GetAccountsForCustomer(Person customer)
    {
        //TODO
    }

    void Deposit(Account to, Money amount)
    {
        //TODO
    }

    void Withdraw(Account from, Money amount)
    {
        //TODO
    }

    void Transfer(Account from, Account to, Money amount)
    {
        //TODO
    }
}


public class HelloWorld
{
    public static void Main()
    {
        System.Console.WriteLine("Hello World!");
    }
}
