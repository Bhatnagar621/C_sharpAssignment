using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExample
{
    class Book : Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public Book(string name, decimal price, int quantity, string author, string isbn)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Author = author;
            ISBN = isbn;
        }
        public string GetDisplayDetails()
        {
            return $"{Name} by {Author} (ISBN: {ISBN})";
        }
    }
}
