using cSharpBankADM.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBankADM.InternalSystem
{
    public abstract class Authenticatable : Employee
    {
        public string Password { get; set; }

        public abstract bool Authenticate(string password);

        public Authenticatable(string cpf, double salary) : base(cpf, salary)
        {
        }
    }
}
