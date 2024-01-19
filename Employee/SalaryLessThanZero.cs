using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    /// <summary>
    /// Custom Exception class
    /// </summary>
    public class SalaryLessThanZeroException : Exception
    {
        /// <summary>
        /// Custon exception to check if the salary is less than 0
        /// </summary>
        public SalaryLessThanZeroException() : base("The Salary can not be less than zero")
        {
        }
    }
}
