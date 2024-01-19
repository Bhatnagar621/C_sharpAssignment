using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public delegate string OperationPerformed();
    public delegate void DecimalArrayParams(params decimal[] num);
    class Calculator: IOperations
    {
        private decimal result;

        event OperationPerformed performed;
        public void Addition(params decimal[] num)
        {
            for (int i = 0;i<num.Length;i++)
                result += num[i];
        }
        public void Subtraction(params decimal[] num)
        {
            for (int i = 0; i < num.Length; i++)
                result -= num[i];
        }
        public void Multiplication(params decimal[] num)
        {
            for (int i = 0; i < num.Length; i++)
                result *= num[i];
        }
        public void Divide(params decimal[] num)
        {
            for (int i = 0; i < num.Length; i++) 
            {
                if (num[i] != 0)
                {
                    result /= num[i];
                }
                else
                {
                    result = Decimal.MaxValue;
                    Console.WriteLine("Division by 0 is not possible");
                }
            }
        }
        public void Modulo(params decimal[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] != 0)
                {
                    result %= num[i];
                }
                else
                {
                    result = Decimal.MaxValue;
                    Console.WriteLine("Division by 0 is not possible");
                }
            }
        }
        void PerformOperation(DecimalArrayParams operation) 
        {
            List<decimal> numbers = new List<decimal>();
            Console.WriteLine("Enter decimal numbers (type 'end' when finished)");
            while (true)
            {
                string input = Console.ReadLine();
                if(input.ToLower() == "end")
                {
                    break;
                }
                decimal num;
                if (decimal.TryParse(input, out num))
                {
                    numbers.Add(num);
                }
                else { 
                    Console.WriteLine("Invalid Input"); 
                }
            }
            operation(numbers.ToArray());
            if(result != Decimal.MaxValue)
            {
                Console.WriteLine(result);
                this.performed += new OperationPerformed(this.OperationComplete);
            }
            else
            {
                this.performed += new OperationPerformed(this.OperationFailed);
            }
            Console.WriteLine(this.performed());
        }

        public void DisplayMenu()
        {
            int check = 1;
            while (check != 0)
            {
                Console.WriteLine("Enter the operation you wish to perform (+, -, *, /, %)");
                char op = Convert.ToChar(Console.ReadLine());
                switch (op)
                {
                    case '+':
                        PerformOperation(Addition);
                        break;
                    case '-':
                        PerformOperation(Subtraction);
                        break;
                    case '*':
                        PerformOperation(Multiplication);
                        break;
                    case '/':
                        PerformOperation(Divide);
                        break;
                    case '%':
                        PerformOperation(Modulo);
                        break;
                    default:
                        Console.WriteLine("Enter a valid operator");
                        break;
                }
                Console.WriteLine("Enter 1 to continue, 0 to Exit");
                check = Convert.ToInt16(Console.ReadLine());
            }
        }
        public string OperationComplete()
        {
           return "Operation Successful";
        }
        public string OperationFailed()
        {
            return "Operation Failed";
        }
    }
}
