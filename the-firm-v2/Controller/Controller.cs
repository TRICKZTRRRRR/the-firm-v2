using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using the_firm_v2.Model;

namespace the_firm_v2.Controller
{
    internal class Controller
    {
        public void MainController()
        {
            View.View view = new View.View();

            // Create CEO and Executives
            CEO ceo = new CEO("John", "Doe", 1000000);
            Executive cfo = new Executive("Alice", "Smith", 500000);
            Executive coo = new Executive("Bob", "Johnson", 500000);

            // Create Managers
            Manager manager1 = new Manager("Eva", "Brown", 200000);
            Manager manager2 = new Manager("David", "Lee", 200000);

            // Create Leaders
            Leader leader1 = new Leader("Linda", "Wilson", 100000);
            Leader leader2 = new Leader("Frank", "Davis", 100000);

            // Create Employees
            Employee employee1 = new Employee("Anna", "Garcia", 60000);
            Employee employee2 = new Employee("Michael", "Martinez", 60000);
            Employee employee3 = new Employee("Sophia", "Lopez", 60000);
            Employee employee4 = new Employee("William", "Brown", 60000);

            // Build the hierarchy
            ceo.AddExecutive(cfo);
            ceo.AddExecutive(coo);

            cfo.AddManager(manager1);
            coo.AddManager(manager2);

            manager1.AddLeader(leader1);
            manager2.AddLeader(leader2);

            leader1.AddEmployee(employee1);
            leader1.AddEmployee(employee2);
            leader1.AddEmployee(employee3);

            leader2.AddEmployee(employee4);

            // Print the hierarchy
            Console.WriteLine("Organizational Hierarchy:");
            view.PrintLine();
            ceo.PrintInfo();
            ceo.PrintExecutivesInfo();
            ceo.PrintStaffInfo();
            view.PrintLine();

            cfo.PrintManagersInfo();
            coo.PrintManagersInfo();

            manager1.PrintLeadersInfo();
            manager2.PrintLeadersInfo();

            leader1.PrintEmployeesInfo();
            leader2.PrintEmployeesInfo();

            view.PrintLine();
            view.ReadLine();
        }
    }
}
