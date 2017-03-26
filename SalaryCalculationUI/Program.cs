using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryCalculationUI.AllReports;
using SalaryCalculationUI.LoginUI;
using SalaryCalculationUI.UI;

namespace SalaryCalculationUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          // Application.Run(new MainUI());
          // Application.Run(new EmployeeInfoForm());
            //Application.Run(new SalaryDetailsEntryForm());
          // Application.Run(new UserLogInForm());
           Application.Run(new Claim());
          // Application.Run(new frmRegistration());
          // Application.Run(new frmHRRegistration());
          // Application.Run(new frmEmployee());
          // Application.Run(new ReporstUI());
        }
    }
}
