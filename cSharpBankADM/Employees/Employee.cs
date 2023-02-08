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
        public string Cpf { get; set; }
        public double Salary { get; set; }

        public static int TotalEmployees { get; private set; }

        public virtual double GetBonus()
        { 
            return this.Salary * 0.10; 
        }

        public Employee()
        {
            TotalEmployees++;
        }
    }
}
