using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_firm_v2.Model
{
    internal class Leader : Employee
    {
        View.View view = new View.View();

        private readonly List<Employee> employees = new List<Employee>();

        public Leader(string firstName, string lastName, decimal salary)
            : base(firstName, lastName, salary)
        {
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void PrintEmployeesInfo()
        {
            view.LeaderUnderGUI(FirstName, LastName);
            foreach (var employee in employees)
            {
                employee.PrintInfo();
            }
        }
    }
}
