using System;

public class Transaction
{
    public string accountNumber;
    public string transactionType;
    public double amount;
    public double newBalance;

    public Transaction(string accNum, string type, double amt)
    {
        accountNumber = accNum;
        transactionType = type;
        amount = amt;
    }

    public double deposit(double balance)
    {
        newBalance = balance + amount;
        return newBalance;
    }

    public double withdraw(double balance)
    {
        newBalance = balance - amount;
        return newBalance;
    }

    public void displayTransactionInfo()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Transaction Type: " + transactionType);
        Console.WriteLine("Amount: RM " + amount);
        Console.WriteLine("New Balance: RM " + newBalance);
    }
}
