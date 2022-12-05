using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankADM.Services
{
    public interface IAuthenticate
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool CheckLogin(string login, string password);
    }
}
