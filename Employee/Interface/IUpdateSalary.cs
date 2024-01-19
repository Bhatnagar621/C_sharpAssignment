using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Interface
{
    public interface IUpdateSalary
    {
        /// <summary>
        /// Update the salary, give appraisal based on department
        /// </summary>
        void UpdateSalary();
        void SalaryUpdated(Employee employee, double newSalary);
    }
}
