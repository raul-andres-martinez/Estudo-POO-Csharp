using BytebankADM.Interface;
using BytebankADM.Models.Abstract;
using BytebankADM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankADM.Models
{
    public class Manager: AuthenticateEmployee
    {
        public Manager(string name, string cpf) : base(name, cpf, 5000)
        {
        }

        public override double GetWageBonus()
        {
            return this.Wage * 0.5;
        }

        public override void RaiseWage()
        {
            this.Wage *= 1.15;
        }
    }
}


