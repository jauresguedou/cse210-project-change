using System;
using System.Collections.Generic;
using System.IO;


public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    



    public Order (List<Product> products, Customer customer)
    {
         _customer = customer;
         _products = products;
    }

    public string GetPackingLabel()
    {
        string packingLabel = " ";

        foreach (Product product in _products)
        {
             packingLabel += $"\n{product.GetProductId()}:{product.GetProductName()}";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
         return $"{_customer.GetCustomerName()}\n{_customer.GetCustomerAddress().GetFullAddress()}";
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        int shippingCost;
        foreach (Product product in _products)
        {
             totalPrice += product.GetTotalCost(); 
        }

        if(_customer.LiveInUSA())
        {
             shippingCost = 5;
        }
        else
        {
             shippingCost = 35;
        }
        return totalPrice + shippingCost;
    }

}