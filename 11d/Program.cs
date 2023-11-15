using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            int productCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < productCount; i++)
            {
                string productName = Console.ReadLine();
                string description = Console.ReadLine();
                string category = Console.ReadLine();
                int quantity = int.Parse(Console.ReadLine());
                double price = double.Parse(Console.ReadLine());
                products.Add(new Product(productName, description, category, quantity, price));
            }
            string name = Console.ReadLine();
            double money = double.Parse(Console.ReadLine());
            Customer customer = new Customer(name, money);
            int count = 0;
            for (int i = 0; i < products.Count; i++)
                if (customer.Buy(products[i]))
                    count++;
            Console.WriteLine(count);
        }
    }
}
