using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer("C101", "Shanchanaa", "0123456789");

        BankAccount account = new BankAccount("A1001", "Shanchanaa", "Savings", 1000);

        Transaction deposit = new Transaction("A1001", "Deposit", 500);
        account.balance = deposit.deposit(account.balance);

        Transaction withdraw = new Transaction("A1001", "Withdraw", 200);
        account.balance = withdraw.withdraw(account.balance);

        Console.WriteLine("----- Customer Info -----");
        customer.displayCustomerInfo();

        Console.WriteLine("\n----- Account Info -----");
        account.displayAccountInfo();

        Console.WriteLine("\n----- Deposit Transaction -----");
        deposit.displayTransactionInfo();

        Console.WriteLine("\n----- Withdrawal Transaction -----");
        withdraw.displayTransactionInfo();
    }
}
