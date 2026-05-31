using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        
       List <Product> _products1 = new List<Product>();
       List <Product> _products2 = new List<Product>();
       List <Product> _products3 = new List<Product>();

       List<Order>   orders = new List<Order>();

       Address address1 = new Address("1250 Oak Street","Dallas","USA","Texas");
       Customer customer1 = new Customer("John Smith",address1);
       Product product1 = new Product("Wireless Mouse","P001",25.99 ,2);
       Product product2 = new Product("Mechanical Keyboard", "P002", 79.99, 1);
       Product product3 = new Product("USB-C Cable","P003",12.50,3);

      
       _products1.Add(product1);
       _products1.Add(product2);
       _products1.Add(product3);

       Order order1 = new Order(_products1,customer1);


       Address address2 = new Address("742 Maple Avenue","Toronto","Canada","Ontario");
       Customer customer2 = new Customer("Sarah Johnson", address2);
       Product product4 = new Product("Laptop Stand","P004",45.00,1);
       Product product5 = new Product("Bluetooth Headphones","P005",79.99,2);
       Product product6 = new Product("Webcam HD ", "P006",59.95,1);
       _products2.Add(product4);
       _products2.Add(product5);
       _products2.Add(product6);

       Order order2 = new Order(_products2,customer2);

       orders.Add(order1);
       orders.Add(order2);

       foreach (Order  order in orders)
       {
            Console.WriteLine(" ");
            Console.WriteLine("ORDER");
            Console.WriteLine($"{order.GetPackingLabel()}"); 
            Console.WriteLine("");    ;
            Console.WriteLine($"{order.GetShippingLabel()}")    ;
            Console.WriteLine($"${order.GetTotalPrice()}") ;
            
       }

       


       

       

       

    }
}