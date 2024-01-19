using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassesExample
{
    interface IItem
    {
        string Name { get; set; }
        decimal Price { get; set; }
        int Quantity { get; set; }

    }
    abstract class Product : IItem
    {
        string Name { get; set; }
        decimal Price { get; set; }
        int Quantity { get; set; }
        public string Description { get; set; }
        public string GetDisplayDetails()
        {
            return Description;
        }
    }
}

