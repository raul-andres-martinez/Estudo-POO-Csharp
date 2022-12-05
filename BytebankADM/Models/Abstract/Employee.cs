using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankADM.Models.Abstract
{
    public abstract class Employee
    {
        public string Name { get; private set; }
        public string Cpf { get; private set; }
        public double Wage { get; protected set; }
        public static int TotalEmployees { get; private set; }

        public abstract double GetWageBonus();

        public abstract void RaiseWage();

        public Employee(string name, string cpf, double wage)
        {
            Name = name;
            Cpf = cpf;
            Wage = wage;
            TotalEmployees++;
        }
    }
}
