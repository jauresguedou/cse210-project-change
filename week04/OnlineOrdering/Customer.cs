using System;
using System.Collections.Generic;
using System.IO;

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer (string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }


    public string GetCustomerName()
    {
        return _customerName;
    }
    

    public Address GetCustomerAddress()
    {
        return _address;
    }

    public bool LiveInUSA()
    {
         return _address.LiveInUsa();
    }
    


}