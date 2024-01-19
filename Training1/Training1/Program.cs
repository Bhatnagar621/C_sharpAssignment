using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            while(true) 
            {
                Console.WriteLine("Enter value1");
                c.Value1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter value2");
                c.Value2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter operation to be performed (+, -, *, /) or 'E' to end");
                char op = Convert.ToChar(Console.ReadLine());
                switch (op)
                {
                    case '+':
                        Console.WriteLine(Calculator.addition(c));
                        break;
                    case '-':
                        Console.WriteLine(Calculator.subtraction(c));
                        break;
                    case '*':
                        Console.WriteLine(Calculator.multiply(c));
                        break;
                    case '/':
                        if (c.Value2 != 0)
                        {
                            Console.WriteLine(Calculator.divide(c));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Division by 0 not possible");
                            break;
                        }
                    case 'E':
                        Environment.Exit(0); 
                        break;
                    default:
                        Console.WriteLine("Enter a valid operation");
                        break;
                }
            }
            
        }
    }
}
