using BytebankADM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankADM.Models.Abstract
{
    public abstract class AuthenticateEmployee: Employee, IAuthenticate
    {
        protected AuthenticateEmployee(string name, string cpf, double wage) : base(name, cpf, wage)
        {
        }

        public string Login { get; set; }
        public string Password { get; set; }

        public bool CheckLogin(string login, string password)
        {
            return this.Login == login && this.Password == password;
        }
    }
}
