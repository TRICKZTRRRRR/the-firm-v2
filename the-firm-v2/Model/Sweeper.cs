using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_firm_v2.Model
{
    internal class Sweeper : Employee
    {
        public Sweeper(string fornavn, string efternavn, decimal salary)
            : base(fornavn, efternavn, salary)
        {
        }
    }
}
