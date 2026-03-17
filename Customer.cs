using System;

public class Customer
{
    private string customerID;
    private string customerName;
    private string phoneNumber;

    public Customer(string id, string name, string phone)
    {
        customerID = id;
        customerName = name;
        phoneNumber = phone;
    }

    public string GetCustomerID()
    {
        return customerID;
    }

    public void SetCustomerID(string id)
    {
        customerID = id;
    }

    public string GetCustomerName()
    {
        return customerName;
    }

    public void SetCustomerName(string name)
    {
        customerName = name;
    }

    public string GetPhoneNumber()
    {
        return phoneNumber;
    }

    public void SetPhoneNumber(string phone)
    {
        phoneNumber = phone;
    }

    public void displayCustomerInfo()
    {
        Console.WriteLine("Customer ID: " + customerID);
        Console.WriteLine("Customer Name: " + customerName);
        Console.WriteLine("Phone Number: " + phoneNumber);
    }
}
