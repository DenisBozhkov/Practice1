using System;
using System.Collections.Generic;

namespace _11g
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            int productCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < productCount; i++)
            {
                string name = Console.ReadLine();
                string description = Console.ReadLine();
                string category = Console.ReadLine();
                int quantity = int.Parse(Console.ReadLine());
                double price = double.Parse(Console.ReadLine());
                products.Add(new Product(name, description, category, quantity, price));
            }
            string customerName = Console.ReadLine();
            double money = double.Parse(Console.ReadLine());
            Customer customer=new Customer(customerName, money);
            int count = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (customer.Buy(products[i]))
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
