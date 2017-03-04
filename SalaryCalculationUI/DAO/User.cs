using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculationUI.DAO
{
   public  class User
   {
       private int userId;
       private string userName;
       private string userType;
       private string password;
       private string name;
       private string contactNo;
       private string email;
       private string joiningDate;


       public int UserId
       {
           get { return userId; }
           set { userId = value; }
       }

       public string UserName
       {
           get { return userName; }
           set { userName = value; }
       }

       public string UserType
       {
           get { return userType; }
           set { userType = value; }
       }
       public string Password
       {
           get { return password; }
           set { password = value; }
       }

       public string Name
       {
           get { return name; }
           set { name = value; }
       }

       public  string ContactNo
       {
           get { return contactNo; }
           set { contactNo = value; }
       }

       public  string Email
       {
           get { return email; }
           set { email = value; }
       }

       public string JoiningDate
       {
           get { return joiningDate; }
           set { joiningDate = value; }
       }

   }
}
