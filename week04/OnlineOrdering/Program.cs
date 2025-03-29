using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Avenue", "São Paulo", "SP", "Brazil");
        Customer customer1 = new Customer("Carol Pereira", address1);

        Product p1 = new Product("Book", "B123", 10.00, 2);
        Product p2 = new Product("Pen", "P456", 2.50, 5);

        Order order1 = new Order(customer1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        Address address2 = new Address("123 Street", "Rio de Janeiro", "RJ", "Brazil");
        Customer customer2 = new Customer("Caroline Silva", address2);

        Product p3 = new Product("Notebook", "N789", 5.00, 3);
        Product p4 = new Product("Eraser", "E321", 1.00, 2);

        Order order2 = new Order(customer2);
        order2.AddProduct(p3);
        order2.AddProduct(p4);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}
