using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBankADM.Employees
{
    public class Employee
    {
        public string Name { get; set; }
        public string Cpf { get; private set; }
        public double Salary { get; protected set; }

        public static int TotalEmployees { get; private set; }

        public virtual double GetBonus()
        { 
            return this.Salary * 0.10; 
        }

        public Employee(string cpf, double salary)
        {
            this.Cpf = cpf;
            this.Salary = salary;
            TotalEmployees++;
        }

        public virtual void RaiseSalary()
        {
            this.Salary *= 1.10;
        }
    }
}
