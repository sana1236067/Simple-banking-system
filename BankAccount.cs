using System;

public class BankAccount
{
    public string accountNumber;
    public string accountHolderName;
    public string accountType;
    public double balance;

    public BankAccount(string accountNumber, string accountHolderName, string accountType, double balance)
    {
        this.accountNumber = accountNumber;
        this.accountHolderName = accountHolderName;
        this.accountType = accountType;
        this.balance = balance;
    }

    public void displayAccountInfo()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolderName);
        Console.WriteLine("Account Type: " + accountType);
        Console.WriteLine("Balance: RM " + balance);
    }
}
