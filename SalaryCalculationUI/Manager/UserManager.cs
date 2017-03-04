using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryCalculationUI.DAO;
using SalaryCalculationUI.Gateway;

namespace SalaryCalculationUI.Manager
{
   public  class UserManager
   {
       private UserGateway aUserGateway;

       public int SaveUser(Registration aRegistration)
       {
           aUserGateway=new UserGateway();
           return aUserGateway.SaveUser(aRegistration);
       }

   }
}
