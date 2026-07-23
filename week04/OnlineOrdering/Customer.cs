using System;
using System.Dynamic;

// Made by Miguel J. Subero Saballo

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address Address)
    {
        _name = name;
        _address = Address;
    }

    public string GetCustomer()
    {
        return _name;
    }

    public string GetCustomerAddress()
    {
        return _address.GetAdress();
    }

    public bool CheckCustomer()
    {
        return _address.CheckPlace();
    }
}