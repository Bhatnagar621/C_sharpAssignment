using Employee.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public delegate void SalaryUpdateHandler(Employee employee, double newSalary);
    public class Manager: Employee, IUpdateSalary
     {
        public event SalaryUpdateHandler SalaryUpdate;
        public Manager(string firstname, string lastName, double salary): base(firstname, lastName, salary)
        {
            
        }
        /// <summary>
        /// Give appraisal of 20%
        /// </summary>
        /// <exception cref="SalaryLessThanZeroException"></exception>
        public void UpdateSalary()
        {
            if (this.Salary < 0)
                throw new SalaryLessThanZeroException();
            this.Salary += (this.Salary * 0.2);
            SalaryUpdate += SalaryUpdated;
            SalaryUpdate?.Invoke(this, this.Salary);
            SalaryUpdate -= SalaryUpdated;
        }

        /// <summary>
        /// Method added in the events SalaryUpdate
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="newSalary"></param>
        public void SalaryUpdated(Employee employee, double newSalary)
        {
            Console.WriteLine($"event called, {employee.FirstName}'s salary changed to {newSalary}");
        }
    }

     public class Developer: Employee, IUpdateSalary
    {
        public event SalaryUpdateHandler SalaryUpdate;
        public Developer(string firstname, string lastName, double salary): base(firstname, lastName, salary)
        {

        }
        /// <summary>
        /// Give appraisal of 30%
        /// </summary>
        /// <exception cref="SalaryLessThanZeroException"></exception>
        public void UpdateSalary()
        {
            if (this.Salary < 0)
                throw new SalaryLessThanZeroException();
            this.Salary += (this.Salary*0.3);
            SalaryUpdate += SalaryUpdated;
            SalaryUpdate?.Invoke(this, this.Salary);
            SalaryUpdate -= SalaryUpdated;
        }

        /// <summary>
        /// Method added in the events SalaryUpdate
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="newSalary"></param>
        public void SalaryUpdated(Employee employee, double newSalary)
        {
            Console.WriteLine($"event called, {employee.FirstName}'s salary changed to {newSalary}");
        }
    }

}
