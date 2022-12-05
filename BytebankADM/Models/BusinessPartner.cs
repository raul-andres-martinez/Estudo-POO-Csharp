using BytebankADM.Models.Abstract;
using BytebankADM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankADM.Models
{
    public class BusinessPartner : IAuthenticate
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool CheckLogin(string login, string password)
        {
            return this.Login == login && this.Password == password;
        }

        public BusinessPartner(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }
    }
}
