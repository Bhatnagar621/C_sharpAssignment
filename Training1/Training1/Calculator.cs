using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training1
{
    internal class Calculator
    {
        private double num1;
        private double num2;
        public double Value1
        {
            get => num1;
            set => num1 = value;
        }
        public double Value2
        {
            get => num2;
            set => num2 = value;
        }
        public static double addition(Calculator c)
        {
            return (c.num1 + c.num2);
        }
        public static double subtraction(Calculator c)
        {
            return (c.num1 - c.num2);
        }
        public static double multiply(Calculator c)
        {
            return (c.num1 * c.num2);
        }
        public static double divide(Calculator c)
        {
            return c.num1 / c.num2;
        }

    }
}
