using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_firm_v2.Model
{
    internal class Employee
    {
        View.View view = new View.View();

        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected decimal Salary { get; set; }

        public Employee(string firstName, string lastName, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public virtual void PrintInfo()
        {
            view.EmployeeGUI(FirstName, LastName, Salary);
        }
    }
}
