using cSharpBankADM.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBankADM.InternalSystem
{
    public interface IAuthenticatable
    {
        public string Password { get; set; }

        public bool Authenticate(string password);
    }
}
