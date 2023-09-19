using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_firm_v2.Model
{
    internal class Executive : Employee
    {
        View.View view = new View.View();

        protected List<Manager> managers = new List<Manager>();

        public Executive(string firstName, string lastName, decimal salary)
            : base(firstName, lastName, salary)
        {
        }

        public void AddManager(Manager manager)
        {
            managers.Add(manager);
        }

        public void PrintManagersInfo()
        {
            view.ManagerUnderGIU(FirstName, LastName);
            foreach (var manager in managers)
            {
                manager.PrintInfo();
            }
        }
    }
}
