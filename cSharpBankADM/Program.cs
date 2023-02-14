using cSharpBankADM.Employees;
using cSharpBankADM.InternalSystem;
using cSharpBankADM.Partners;
using cSharpBankADM.Utils;

#region
//Employee peter = new Employee("09999888998", 2000);
//peter.Name = "Peter Malboi";

//Console.WriteLine(peter);
//Console.WriteLine(peter.GetBonus());

//Director robert = new Director("99099122100");
//robert.Name = "Robert Admiral";

//Console.WriteLine(robert);
//Console.WriteLine(robert.GetBonus());

//BonusManager bonusManager = new BonusManager();
//bonusManager.RegisterBonus(peter);
//bonusManager.RegisterBonus(robert);

//Console.WriteLine(bonusManager.TotalBonus);
//Console.WriteLine(Employee.TotalEmployees);

//peter.RaiseSalary();
//robert.RaiseSalary();

//Console.WriteLine("Peter new salary : " + peter.Salary);
//Console.WriteLine("Peter new salary : " + robert.Salary);
#endregion

CalculateBonus();
void CalculateBonus()
{
    BonusManager bonusManager = new BonusManager();

    Designer william = new Designer("90909990909");
    william.Name = "William";

    Director paul = new Director("98989088912");
    paul.Name = "Paul";

    Analist igor = new Analist("120120121212");
    igor.Name = "Igor";

    bonusManager.RegisterBonus(william);
    bonusManager.RegisterBonus(paul);
    bonusManager.RegisterBonus(igor);

    Console.WriteLine("Total bonus : " + bonusManager.TotalBonus);
}

UseSytem();
void UseSytem()
{
    InternalSytem system = new InternalSytem();

    Director paul = new Director("98989088912");
    paul.Name = "Paul";
    paul.Password= "123";

    Analist henry = new Analist("9990999092");
    henry.Name = "Henry";

    CommercialPartner arthur = new CommercialPartner();
    arthur.Password = "1223";


    system.Login(paul, "123");
    system.Login(arthur, "1223");
}




