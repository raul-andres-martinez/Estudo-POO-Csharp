using BytebankADM.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankADM.Utilities
{
    internal class WageBonusManager
    {
        public double TotalWageBonus { get; private set; }  

        public void Register(Employee employee)
        {
            this.TotalWageBonus += employee.GetWageBonus();
        }
    }
}
