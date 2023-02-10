using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBankADM.Employees
{
    public class Designer : Employee
    {
        public override double GetBonus()
        {
            return this.Salary * 0.17;
        }

        public Designer(string cpf) : base(cpf, 3000)
        {

        }

        public override void RaiseSalary()
        {
            this.Salary *= 1.11;
        }
    }
}
