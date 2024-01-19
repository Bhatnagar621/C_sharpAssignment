using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List to contain the manager employees
            List<Manager> manager = new List<Manager> {     
                new Manager("Kushagra", "Bhatnagar", 100000), 
                new Manager("Ashwat", "Prakash", 10000) 
            };

            //List to contain the developer employees
            List<Developer> developer = new List<Developer> {
                new Developer("Charvi", "Keswani", 10000),
                new Developer("Ashish", "Dixit", 2000) 
            };


            //updating salary of ashwat and charvi
            var managerEmp = manager.First(m => m.FirstName == "Ashwat");
            var developerEmp = developer.First(d => d.FirstName == "Charvi");
            managerEmp.UpdateSalary();
            developerEmp.UpdateSalary();

            //displaying the Custom Excpetion
            try
            {
                developer.Add(new Developer("Sarthak", "Pathek", -400));
            }
            catch(SalaryLessThanZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}
