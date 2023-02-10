using cSharpBankADM.Employees;
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




