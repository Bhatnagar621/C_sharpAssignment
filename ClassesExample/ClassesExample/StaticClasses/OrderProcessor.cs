using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExample
{
    static class OrderProcessor
    {
        public static void ProcessOrder(Order order)
        {
            Console.WriteLine("Processing order...");
        }
        public static void SendConfirmationEmail(Order order)
        {
            Console.WriteLine("Sending confirmation email...");
        }
    }
}
