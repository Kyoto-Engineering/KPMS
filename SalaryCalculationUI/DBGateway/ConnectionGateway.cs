using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculationUI.DBGateway
{
  public   class ConnectionGateway
    {
       protected SqlConnection connection;

        public ConnectionGateway()
        {
           //string connectionString;
            // string connectionString = @"server=KYOTO-PC1\SQLSERVER2014; Integrated Security = SSPI; database =EmployeeMSDb";
           // string connectionString = @"KYOTOPC-7\SQLSERVER1416;database =EmployeeMSDb;Integrated Security = true;";
           // string connectionString = @"server=DESKTOP-TQ74LPH\SQLSERVER2018; Integrated Security = SSPI; database =EmployeeMSDb;Connect Timeout=30";
         
          string connectionString = @"Data Source=tcp:KyotoServer,49172;Initial Catalog=EmployeeMSDb;User=sa;Password=SystemAdministrator;Persist Security Info=True;";
           // string connectionString = @"data source=KYOTOPC-7;initial catalog=EmployeeMSDb;integrated security=True;";
            //string connectionString = @"Server=KYOTOPC-7;database=EmployeeMSDb;integrated security=SSPI;";
            connection = new SqlConnection(connectionString);
        }

     
    }
}
