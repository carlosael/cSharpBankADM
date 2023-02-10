﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBankADM.Employees
{
    public class Director:Employee
    {
        public override double GetBonus()
        {
            return this.Salary + base.GetBonus();
        }

        public Director(string cpf):base(cpf, 5000)
        {

        }

        public override void RaiseSalary()
        {
            this.Salary *= 1.15;
        }
    }
}
