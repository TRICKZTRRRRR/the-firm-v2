using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_firm_v2.Model
{
    internal class HR : Employee
    {
        View.View view = new View.View();

        public HR()
    : base("HR", "Department", 0)
        {
        }

        public override void PrintInfo()
        {
            view.HRInfoGUI();
        }
    }
}
