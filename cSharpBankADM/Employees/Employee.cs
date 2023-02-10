using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBankADM.Employees
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Cpf { get; private set; }
        public double Salary { get; protected set; }

        public static int TotalEmployees { get; private set; }

        public abstract double GetBonus();

        public abstract void RaiseSalary();
        
        public Employee(string cpf, double salary)
        {
            this.Cpf = cpf;
            this.Salary = salary;
            TotalEmployees++;
        }

        
    }
}
