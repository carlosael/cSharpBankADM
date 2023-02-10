using cSharpBankADM.Employees;
using cSharpBankADM.Utils;

Employee peter = new Employee("09999888998");
peter.Name = "Peter Malboi";
peter.Salary = 2000;

Console.WriteLine(peter);
Console.WriteLine(peter.GetBonus());

Director robert = new Director("99099122100");
robert.Name = "Robert Admiral";
robert.Salary = 5000;

Console.WriteLine(robert);
Console.WriteLine(robert.GetBonus());

BonusManager bonusManager = new BonusManager();
bonusManager.RegisterBonus(peter);
bonusManager.RegisterBonus(robert);

Console.WriteLine(bonusManager.TotalBonus);
Console.WriteLine(Employee.TotalEmployees);

peter.RaiseSalary();
robert.RaiseSalary();

Console.WriteLine("Peter new salary : " + peter.Salary);
Console.WriteLine("Peter new salary : " + robert.Salary);




