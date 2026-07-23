using System;

// Made by Miguel J. Subero Saballo

class Program
{
    static void Main(string[] args)
    {
        string dude = "Ramon Arturo";
        string street = "De la Flor";
        string city = "Miraflor";
        string state = "Gran Flor";
        string country = "Mexico";

        Address a1 = new Address(street, city, state, country);

        Customer c1 = new Customer(dude, a1);

        Order o1 = new Order(c1);

        string name = "Banana";
        string code = "AA1120";
        double price = 1.7;
        int amount = 2;

        Product p1 = new Product(name, code, price, amount);

        o1.AddProduct(p1);

        string name2 = "Arroz";
        string code2 = "AA320";
        double price2 = 2.5;
        int amount2 = 1;

        Product p2 = new Product(name2, code2, price2, amount2);

        o1.AddProduct(p2);

        string name3 = "Juguito";
        string code3 = "AABC20";
        double price3 = 8;
        int amount3 = 4;

        Product p3 = new Product(name3, code3, price3, amount3);

        o1.AddProduct(p3);

        
        Console.WriteLine("Packing Label:");
        o1.PrintPackingLabel();
        Console.WriteLine("Shipping Label:");
        o1.PrintShippingLabel();
        Console.WriteLine($"Total: {o1.GetTotalPrice()}$");

        Console.WriteLine("");
        Console.WriteLine("");

        string dude2 = "Steve Deeds";
        string street2 = "George Washington";
        string city2 = "Capital";
        string state2 = "Florida";
        string country2 = "USA";

        Address a2 = new Address(street2, city2, state2, country2);

        Customer c2 = new Customer(dude2, a2);

        Order o2 = new Order(c2);

        int amount4 = 2;

        Product p4 = new Product(name, code, price, amount4);

        o2.AddProduct(p4);

        int amount5 = 1;

        Product p5 = new Product(name3, code3, price3, amount5);

        o2.AddProduct(p5);


        Console.WriteLine("Packing Label:");
        o2.PrintPackingLabel();
        Console.WriteLine("Shipping Label:");
        o2.PrintShippingLabel();
        Console.WriteLine($"Total: {o2.GetTotalPrice()}$");
    }
}