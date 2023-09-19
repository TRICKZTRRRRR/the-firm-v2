using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_firm_v2.Model
{
    internal class CEO : Employee
    {
        View.View view = new View.View();

        private readonly List<Executive> executives = new List<Executive>();
        private readonly HR hr = new HR();
        private readonly Administration adm = new Administration();

        public CEO(string firstName, string lastName, decimal salary)
            : base(firstName, lastName, salary)
        {
        }

        public void AddExecutive(Executive executive)
        {
            executives.Add(executive);
        }

        public void PrintExecutivesInfo()
        {
            view.CEOTeamGUI();
            foreach (var executive in executives)
            {
                executive.PrintInfo();
            }
        }

        public void PrintStaffInfo()
        {
            hr.PrintInfo();
            adm.PrintInfo();
        }
    }
}
