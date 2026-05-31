using System;
using System.Collections.Generic;
using System.IO;


public class Address
{
    private string _streetAddress;
    private string _city;

    private string _country;

    private string _state;

    public Address(string streetAddress, string city, string country, string state)
    {
        _streetAddress = streetAddress;
        _city = city;
        _country = country;
        _state = state;
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress},\n{_city},{_state},\n{_country}";
    }

    public bool LiveInUsa()
    {
        if (_country == "usa"|| _country == "USA" || _country == "Usa")
        {
            return true;
        }

        else
        {
            return false;
        }
    }



}