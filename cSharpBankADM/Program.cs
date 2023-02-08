using cSharpBankADM.Employees;

Employee peter = new Employee();
peter.Name = "Peter Malboi";
peter.Cpf = "09999888998";
peter.Salary = 2000;

Console.WriteLine(peter);
Console.WriteLine(peter.GetBonus());
