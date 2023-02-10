using cSharpBankADM.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBankADM.InternalSystem
{
    public class InternalSytem
    {
        public bool Login(Director director, string password)
        {
            bool authenticatedUser = director.Authenticate(password);
            if (authenticatedUser)
            {
                Console.WriteLine("Welcome to our system.");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid password.");
                return false;
            }
        }
    }
}
