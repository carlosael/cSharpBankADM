using cSharpBankADM.InternalSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBankADM.Employees
{
    public class Director: AuthenticatableEmployee
    {
        public override double GetBonus()
        {
            return this.Salary * 0.30 ;
        }

        public Director(string cpf):base(cpf, 5000)
        {

        }

        public override void RaiseSalary()
        {
            this.Salary *= 1.15;
        }

        public bool Authenticate(string password)
        {
            return this.Password == password;
        }
    }
}
