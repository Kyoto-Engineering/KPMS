using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryCalculationUI.DAO;
using SalaryCalculationUI.Gateway;

namespace SalaryCalculationUI.Manager
{
   public  class SalaryManager
    {
        private SalaryGateway agateway;
        public int SaveSalary(Salary aSalary)
        {
            if (aSalary.AccountNo ==null)
            {
                throw new Exception("Please Type the Account Number");
            }
            agateway = new SalaryGateway();
            return agateway.SaveSalary(aSalary);
        }
    }
}
