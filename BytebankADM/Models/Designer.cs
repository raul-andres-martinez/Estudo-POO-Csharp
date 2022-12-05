using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BytebankADM.Models.Abstract;

namespace BytebankADM.Models
{
    public class Designer : Employee
    {
        public Designer (string name, string cpf) : base(name, cpf, 3000)
        {
        }
        public override double GetWageBonus()
        {
            return this.Wage * 0.17;
        }

        public override void RaiseWage()
        {
            this.Wage *= 1.11;
        }
    }
}
