using cSharpBankADM.InternalSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBankADM.Employees
{
    public abstract class AuthenticatableEmployee : Employee, IAuthenticatable
    {
        protected AuthenticatableEmployee(string cpf, double salary) : base(cpf, salary)
        {
        }

        public string Password { get ; set ; }

        public bool Authenticate(string password)
        {
            return this.Password == password;
        }
    }
}
