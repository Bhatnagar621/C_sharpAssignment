using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class MainShop
    {
        public static void DisplayMenu()
        {
            int loop = 1;
            Product defaultProduct = new Product(1, "Watch", 1000, "A Fossil watch, that tells the time.");
            Product product = new Product();
            Order order = new Order();
            while (loop != 0)
            {
                Console.WriteLine(
                "Press 1 to create new product\n" +
                "Press 2 to add a prodct to cart\n" +
                "Press 3 to remove a product from cart\n" +
                "Press 4 to place an order\n" +
                "Press 5 to cancel an order\n"
                );
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        product.CreateProduct();
                        break;
                    case 2:
                        if (product.Id == 0)
                        {
                            order.AddToCart(defaultProduct, order);
                        }
                        else
                        {
                            order.AddToCart(product, order);
                        }
                        break;
                    case 3:
                        if (product.Id == 0)
                        {
                            order.RemoveFromCart(defaultProduct, order);
                        }
                        else
                        { 
                            order.RemoveFromCart(product, order);
                        }
                        break;
                    case 4:
                        
                            order.PlaceOrder(order);
                        
                        break;
                    case 5:
                        
                            order.PlaceOrder(order);
                        
                        break;
                    default:
                        Console.WriteLine("Enter a valid choice!!");
                        break;
                }
                Console.WriteLine("Enter 0 to exit, 1 to continue");
                loop = int.Parse(Console.ReadLine() ?? string.Empty);
            }

        }
    }
}
