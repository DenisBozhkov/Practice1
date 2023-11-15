using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11d
{
    internal class Customer
    {
        public string Name { get; set; }
        public double Money { get; set; }
        public Customer(string name, double money)
        {
            Name = name;
            Money = money;
        }
        public bool Buy(Product product)
        {
            if (product.Quantity > 0 && product.Price < Money)
            {
                Money -= product.Price;
                product.Quantity--;
                Console.WriteLine("{0} was bought by {1}!", product, Name);
                return true;
            }
            Console.WriteLine("{0} cannot be bought by {1}!", product, Name);
            return false;
        }
    }
}
