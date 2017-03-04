using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculationUI.DBGateway
{
   public  class ConnectionString
    {

      // public string DBConn = @"Data Source=DESKTOP-TQ74LPH\SQLSERVER2018;Integrated Security=True;database=EmployeeMSDb;Connect Timeout=30";
     

   public string DBConn = @"Data Source=tcp:KyotoServer,49172;Initial Catalog=EmployeeMSDb;User=sa;Password=SystemAdministrator;Persist Security Info=True";

    }
}
