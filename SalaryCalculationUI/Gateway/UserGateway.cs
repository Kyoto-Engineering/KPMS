using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryCalculationUI.DAO;
using SalaryCalculationUI.DBGateway;

namespace SalaryCalculationUI.Gateway
{
    public class UserGateway : ConnectionGateway
    {



       public  int SaveUser(Registration  aRegistration)
        {

            string uInsertQuery = "insert into Registration(userName,UserType,Password,ContactNo,Email) values('" + aRegistration.UserName + "','HR','" + aRegistration.Password + "','" + aRegistration.Name + "','" + aRegistration.ContactNo + "','" + aRegistration.Email + "')";
            SqlCommand command = new SqlCommand(uInsertQuery, connection);
            int effectedRors = command.ExecuteNonQuery();
            connection.Close();
            return effectedRors;
      }


        //public User SearchUser(string userName)
        //{
        //    connection.Open();

        //    string selec = string.Format(@"Select * from Registration where Username='{0}'", userName);

        //    SqlCommand command = new SqlCommand(selec, connection);
        //    SqlDataReader dataReader = command.ExecuteReader();
        //    User aUser = new User();
        //    while (dataReader.Read())
        //    {
        //        aUser.UserName = dataReader[1].ToString();
        //        aUser.UserType = dataReader[2].ToString();
        //        aUser.Password = dataReader[3].ToString();
        //        aUser.ContactNo = dataReader[4].ToString();
        //        aUser.Email = dataReader[5].ToString();
        //        aUser.Name = dataReader[6].ToString();
        //        //aUser.JoiningDate = dataReader[7].ToString();

        //    }
        //    dataReader.Close();

        //    connection.Close();

        //    return aUser;


        //}

    }
}
