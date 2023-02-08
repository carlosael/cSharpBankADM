using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBankADM.Employees
{
    public class Director:Employee
    {
        public double GetBonus()
        {
            return this.Salary;
        }
    }
}
