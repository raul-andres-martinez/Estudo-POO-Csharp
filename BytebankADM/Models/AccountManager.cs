using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BytebankADM.Interface;
using BytebankADM.Models.Abstract;

namespace BytebankADM.Models
{
    public class AccountManager : AuthenticateEmployee
    {
        public AccountManager(string name, string cpf) : base(name, cpf, 4000)
        {

        }

        public override double GetWageBonus()
        {
            return this.Wage * 0.25;
        }

        public override void RaiseWage()
        {
            this.Wage *= 1.05;
        }
    }
}
