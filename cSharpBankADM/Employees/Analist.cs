using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBankADM.Employees
{
    public class Analist : Employee
    {
        public override double GetBonus()
        {
            return this.Salary *0.2;
        }

        public Analist(string cpf) : base(cpf, 2000)
        {

        }

        public override void RaiseSalary()
        {
            this.Salary *= 1.1;
        }
    }
}
