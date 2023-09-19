using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_firm_v2.View
{
    internal class View
    {

        public void AdminInfoGUI()
        {
            Console.WriteLine("\nAdministration Department");
        }

        public void HRInfoGUI()
        {
            Console.WriteLine("HR Department");
        }

        public void EmployeeUnderGUI(string FirstName, string LastName)
        {
            Console.WriteLine($"Employees under {FirstName} {LastName}:");
        }

        public void LeaderUnderGUI(string FirstName, string LastName)
        {
            Console.WriteLine($"Leaders under {FirstName} {LastName}:");
        }

        public void ManagerUnderGIU(string FirstName, string LastName)
        {
            Console.WriteLine($"Manager under {FirstName} {LastName}:");
        }

        public void CEOTeamGUI()
        {
            Console.WriteLine("Executive Team:");
        }

        public void EmployeeGUI(string FirstName, string LastName, decimal Salary)
        {
            Console.WriteLine($"Name: {FirstName} {LastName}" +
                $"Salary: {Salary:C}\n");
        }


        public void ReadLine()
        {
            Console.ReadLine();
        }

        public void PrintLine()
        {
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
