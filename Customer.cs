// Customer.cs

using System;

public class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }

    public Customer(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public void Display()
    {
        Console.WriteLine($"Customer Name: {Name}, Email: {Email}");
    }
}
