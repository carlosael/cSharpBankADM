using cSharpBankADM.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBankADM.Utils
{
    public class BonusManager
    {
        public double TotalBonus { get; private set; }

        public void RegisterBonus (Employee employee) 
        {
            this.TotalBonus += employee.GetBonus();
        }
    }
}
