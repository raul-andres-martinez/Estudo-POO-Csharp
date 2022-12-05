using BytebankADM.Models;
using BytebankADM.Services;
using BytebankADM.Utilities;

#region
//Employee raul = new Employee("Raul", "123456", 1200);

//Manager erin = new Manager("Erin", "1234");


//Console.WriteLine(raul.Name);
//Console.WriteLine(raul.Cpf);
//Console.WriteLine(raul.Wage);
//Console.WriteLine(raul.GetWageBonus());

//Console.WriteLine(erin.Name);
//Console.WriteLine(erin.Cpf);
//Console.WriteLine(erin.Wage);
//Console.WriteLine(erin.GetWageBonus());

//WageBonusManager manager = new WageBonusManager();
//manager.Register(erin);
//manager.Register(raul);

//Console.WriteLine(manager.TotalWageBonus);

//Console.WriteLine(Employee.TotalEmployees);

//raul.RaiseWage();
//erin.RaiseWage();

//Console.WriteLine(raul.Wage);
//Console.WriteLine(erin.Wage);
#endregion

useAuth();
//GetTotalBonus();

void GetTotalBonus()
{
    WageBonusManager wageBonusManager = new WageBonusManager();

    Designer joao = new Designer("Joao", "123456");

    Manager maria = new Manager("Maria", "123123");
    maria.Password = "123123";

    Assistant paulo = new Assistant("Paulo", "435676");

    AccountManager paula = new AccountManager("Paula", "132567");
    paula.Password = "senha";

    wageBonusManager.Register(joao);
    wageBonusManager.Register(maria);
    wageBonusManager.Register(paulo);
    wageBonusManager.Register(paula);

    Console.WriteLine("Total de bonificação: " + wageBonusManager.TotalWageBonus);
}

void useAuth()
{
    Login authentication = new Login();

    Manager maria = new Manager("Maria", "123456");
    maria.Login = "Maria2";
    maria.Password = "123123";

    AccountManager paula = new AccountManager("Paula", "132567");
    paula.Login = "Paula3";
    paula.Password = "senha";

    BusinessPartner roberto = new BusinessPartner("Roberto", "123");

    authentication.Logon(maria, "Maria2", "123123");
    authentication.Logon(paula, "Paula1", "senha1");
    authentication.Logon(roberto, "Roberto", "123");
}
