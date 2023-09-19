using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace the_firm_v2.Model
{
    internal class Manager : Employee
    {
        View.View view = new View.View();

        protected List<Leader> leaders = new List<Leader>();

        public Manager(string firstName, string lastName, decimal salary)
            : base(firstName, lastName, salary)
        {
        }

        public void AddLeader(Leader leader)
        {
            leaders.Add(leader);
        }

        public void PrintLeadersInfo()
        {
            view.LeaderUnderGUI(FirstName, LastName);
            foreach (var leader in leaders)
            {
                leader.PrintInfo();
            }
        }
    }
}
