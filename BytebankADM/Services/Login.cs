using BytebankADM.Models;
using BytebankADM.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankADM.Services
{
    internal class Login
    {
        public bool Logon(IAuthenticate employee, string login, string password)
        {
            bool checkLogin = employee.CheckLogin(login ,password);

            if (checkLogin)
            {
                Console.WriteLine($"Logado com sucesso.\n\rBoas vindas ao sistema, {employee.Login}!");
                return true;
            } 
            else 
            {
                Console.WriteLine("Dados incorretos.");
                return false; 
            }
        }
    }
}
