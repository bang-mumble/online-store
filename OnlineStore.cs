// OnlineStore.cs

using System;
using System.Collections.Generic;

public class OnlineStore
{
    private List<Product> products;
    private List<Customer> customers;

    public OnlineStore()
    {
        products = new List<Product>();
        customers = new List<Customer>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void AddCustomer(Customer customer)
    {
        customers.Add(customer);
    }

    public void DisplayProducts()
    {
        Console.WriteLine("Available Products:");
        foreach (var product in products)
        {
            product.Display();
        }
    }

    public void DisplayCustomers()
    {
        Console.WriteLine("Customers:");
        foreach (var customer in customers)
        {
            customer.Display();
        }
    }
}
