// Program.cs

class Program
{
    static void Main()
    {
        // Create products
        var laptop = new Product(1, "Laptop", 800.0);
        var smartphone = new Product(2, "Smartphone", 400.0);

        // Create customers
        var customer1 = new Customer("Alice", "alice@example.com");
        var customer2 = new Customer("Bob", "bob@example.com");

        // Create an online store
        var onlineStore = new OnlineStore();

        // Add products and customers to the online store
        onlineStore.AddProduct(laptop);
        onlineStore.AddProduct(smartphone);
        onlineStore.AddCustomer(customer1);
        onlineStore.AddCustomer(customer2);

        // Display available products and customers
        onlineStore.DisplayProducts();
        onlineStore.DisplayCustomers();
    }
}
