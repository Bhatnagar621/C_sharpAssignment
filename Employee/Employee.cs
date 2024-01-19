using Employee.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{

    public abstract class Employee 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
       
        public Employee(string firstname, string lastName, double salary) { 
            FirstName = firstname;
            LastName = lastName;
            if (salary < 0)
                throw new SalaryLessThanZeroException();
            Salary = salary; //Update salary event added to all employees on creation

        }

        
    }
}
