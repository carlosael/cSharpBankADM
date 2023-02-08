using cSharpBankADM.Employees;
using cSharpBankADM.Utils;

Employee peter = new Employee();
peter.Name = "Peter Malboi";
peter.Cpf = "09999888998";
peter.Salary = 2000;

Console.WriteLine(peter);
Console.WriteLine(peter.GetBonus());

Director robert = new Director();
robert.Name = "Robert Admiral";
robert.Cpf = "99099122100";
robert.Salary = 5000;

Console.WriteLine(robert);
Console.WriteLine(robert.GetBonus());

BonusManager bonusManager = new BonusManager();
bonusManager.RegisterBonus(peter);
bonusManager.RegisterBonus(robert);

Console.WriteLine(bonusManager.TotalBonus);
Console.WriteLine(Employee.TotalEmployees);



