using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public delegate void OrderPlaced(Order order);
    public class Order
    {
        event OrderPlaced orderPlaced;
        public List<Product> Orders = new List<Product>();
        private decimal NetPrice;

        public void AddToCart(Product product, Order order)
        {
            order.Orders.Add(product);
            order.NetPrice = order.NetPrice + product.Price;
            Console.WriteLine($"Product {product.Name} added to cart");
        }
        public void RemoveFromCart(Product product, Order order)
        {
            order.Orders.Remove(product);
            order.NetPrice = order.NetPrice - product.Price;
            Console.WriteLine($"Product {product.Name} removed from cart");
        }
        public void PlaceOrder(Order order)
        {
            if (order.Orders.Count == 0)
                Console.WriteLine("No Order Exists");
            else
            {
                Console.WriteLine($"Order Placed, Your Net total is {order.NetPrice}");
                order.Orders.Clear();
                order.NetPrice = 0;
            }
                
        }
        public void CancelOrder(Order order)
        {
            if (order.Orders.Count == 0)
                Console.WriteLine("No Order Exists");
            else
            {
                order.Orders.Clear();
                order.NetPrice = 0;
                Console.WriteLine("Order Canceled, cart reset");
            }

        }
    }
}