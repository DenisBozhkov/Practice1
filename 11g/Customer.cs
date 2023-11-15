using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11g
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
            if (product.Price <= Money && product.Quantity > 0)
            {
                Money -= product.Price;
                product.Quantity--;
                Console.WriteLine("The product {0} was bought successfully by {1}!", product, Name);
                return true;
            }
            Console.WriteLine("{0} cannot buy {1}!", Name, product);
            return false;
        }
    }
}
