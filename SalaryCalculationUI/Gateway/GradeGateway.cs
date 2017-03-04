using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryCalculationUI.DAO;
using SalaryCalculationUI.DBGateway;

namespace SalaryCalculationUI.Gateway
{
   public  class GradeGateway:ConnectionGateway
    {

        public  int  SaveGrade(Grade aGrade)
        {
            connection.Open();
            //if (aGrade.GradeId!=null)
            //{
                string insertQuery = "insert into Grade values('" + aGrade.GradeId + "','" + aGrade.Basic + "','" + aGrade.TransportAllowance + "','" + aGrade.MedicalAllowance + "'," +
                                  "'" + aGrade.HouseRent + "','" + aGrade.OtherAllowance + "','" + aGrade.GrossGSalary + "')";

                SqlCommand cmd = new SqlCommand(insertQuery, connection);
                int affectedRows = cmd.ExecuteNonQuery();
                connection.Close();
                return affectedRows;
            
            
            //} else
            //{
            //    string upDateQuery = "Update Grade  set Basics='" + aGrade.Basic + "',TransportAllowance=" + aGrade.TransportAllowance + ",MedicalAllowance=" + aGrade.MedicalAllowance + ",HouseRent=" + aGrade.HouseRent + ",OtherAllowance=" + aGrade.OtherAllowance + ",GrossSalary=" + aGrade.GrossGSalary + " Where GradeId='" + aGrade.GradeId + "'";
            //    SqlCommand cmd = new SqlCommand(upDateQuery, connection);
            //    // cmd.ExecuteReader();
            //    cmd.ExecuteReader();

            //    //int  reader = cmd.ExecuteNonQuery();
            //    connection.Close();
            //    MessageBox.Show("Grade Updated Successfully");
                
            //}
            
           

        }

       public void UpdateGrade(Grade aGrade)
       {
           connection.Open();
          
           string upDateQuery = "Update Grade  set Basics='" + aGrade.Basic + "',TransportAllowance=" + aGrade.TransportAllowance + ",MedicalAllowance=" + aGrade.MedicalAllowance + ",HouseRent=" + aGrade.HouseRent + ",OtherAllowance=" + aGrade.OtherAllowance + ",GrossSalary=" + aGrade.GrossGSalary + " Where GradeId='" + aGrade.GradeId + "'";
           SqlCommand cmd=new SqlCommand(upDateQuery,connection);
           cmd.ExecuteReader();
           connection.Close();
           MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
       }

        public  Grade SearchGrade(decimal gradeId)
        {
            connection.Open();
            string selectt = string.Format("Select * from Grade where GradeId='{0}'", gradeId);
            SqlCommand command = new SqlCommand(selectt, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            Grade agrade=new Grade();
            while (dataReader.Read())
            {
                agrade.GradeId = Convert.ToInt64(dataReader[0].ToString());
                agrade.Basic = Convert.ToDecimal(dataReader[1].ToString());
                agrade.TransportAllowance = Convert.ToDecimal(dataReader[2].ToString());
                agrade.MedicalAllowance = Convert.ToDecimal(dataReader[3].ToString());
                agrade.HouseRent = Convert.ToDecimal(dataReader[4].ToString());
                agrade.OtherAllowance = Convert.ToDecimal(dataReader[5].ToString());
                agrade.GrossGSalary = Convert.ToDecimal(dataReader[6].ToString());
            }
            dataReader.Close();
            connection.Close();
            return agrade;
        }

      public  Grade PopulatGradeById(decimal gradeId)
        {
           connection.Open();
          string retrive = string.Format("Select * from Grade where GradeId='{0}'", gradeId);
          SqlCommand comnd=new SqlCommand( retrive,connection);
          SqlDataReader dataReader = comnd.ExecuteReader();
          Grade bgrade = new Grade();
          while (dataReader.Read())
          {
              bgrade.GradeId = Convert.ToInt64(dataReader[0].ToString());
              bgrade.Basic = Convert.ToDecimal(dataReader[1].ToString());
              bgrade.TransportAllowance = Convert.ToDecimal(dataReader[2].ToString());
              bgrade.MedicalAllowance = Convert.ToDecimal(dataReader[3].ToString());
              bgrade.HouseRent = Convert.ToDecimal(dataReader[4].ToString());
              bgrade.OtherAllowance = Convert.ToDecimal(dataReader[5].ToString());
              bgrade.GrossGSalary = Convert.ToDecimal(dataReader[6].ToString());
          }
          dataReader.Close();
          connection.Close();
          return bgrade;
        }
    }
}
