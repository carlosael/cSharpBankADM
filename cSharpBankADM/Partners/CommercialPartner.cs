using cSharpBankADM.InternalSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBankADM.Partners
{
    public class CommercialPartner :IAuthenticatable
    {
        public string Password { get; set; }

        public bool Authenticate(string password)
        {
            return this.Password == password;
        }
    }
}
