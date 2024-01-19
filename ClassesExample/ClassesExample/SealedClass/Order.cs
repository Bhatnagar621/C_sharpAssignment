using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExample
{
    sealed class Order
    {
        public List<IItem> Items { get; set; } = new List<IItem>();
        public decimal CalculateTotalCost()
        {
            return Items.Sum(item => item.Price * item.Quantity);
        }
    }
}
