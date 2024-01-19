using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal interface IOperations
    {
        void Addition(params decimal[] num);
        void Subtraction(params decimal[] num);
        void Multiplication(params decimal[] num);
        void Divide(params decimal[] num);
        void Modulo(params decimal[] num);
    }
}
