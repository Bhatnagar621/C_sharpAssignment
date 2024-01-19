using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Product()
        {
        }
        internal Product(int id, string name, decimal price, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
        }

        public void CreateProduct()
        {
            Console.WriteLine("Enter product Id");
            int id = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter product name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter product price");
            decimal price = decimal.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter the product description");
            string description = Console.ReadLine();
            Id = id;
            Name = name;
            Price = price;
            Description = description;
        }
    }
}