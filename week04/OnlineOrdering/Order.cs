using System;
using System.Numerics;

// Made by Miguel J. Subero Saballo

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer Customer)
    {
        _customer = Customer;
    }

    public void AddProduct(Product Product)
    {
        _products.Add(Product);
    }

    public void PrintPackingLabel()
    {
        foreach (var product in _products)
        {
            Console.WriteLine($"Name: {product.GetName()} ID: {product.GetID()}");
        }
    }

    public void PrintShippingLabel()
    {
        Console.WriteLine($"Customer: {_customer.GetCustomer()}");
        Console.WriteLine($"Address: {_customer.GetCustomerAddress()}");
    }

    public double GetTotalPrice()
    {
        double total = 0;
        
        foreach (var product in _products)
        {
            total = total + product.GetPrice();
        }

        int fee = 5;

        if (_customer.CheckCustomer() == false)
        {
            fee = 35;
        }

        return total + fee;
    }
}