using System;

// Made by Miguel J. Subero Saballo

public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetID()
    {
        return _id;
    }

    public double GetPrice()
    {
        return _price * _quantity;
    }
}