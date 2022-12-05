using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BytebankADM.Models.Abstract;

namespace BytebankADM.Models
{
    public class Assistant : Employee
    {
        public Assistant(string name, string cpf) : base(name, cpf, 2000)
        {
        }

        public override double GetWageBonus()
        {
            return this.Wage * 0.2;
        }

        public override void RaiseWage()
        {
            this.Wage *= 1.1;
        }
    }
}
