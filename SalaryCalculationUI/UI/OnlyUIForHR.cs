using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryCalculationUI.AllReports;
using SalaryCalculationUI.LoginUI;

namespace SalaryCalculationUI.UI
{
    public partial class OnlyUIForHR : Form
    {
        public OnlyUIForHR()
        {
            InitializeComponent();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeInfoForm  emp=new EmployeeInfoForm();
            emp.Show();
        }

        private void salaryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalaryDetailsEntryForm salaryDetailsEntry=new SalaryDetailsEntryForm();
            salaryDetailsEntry.Show();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHRRegistration fm = new frmHRRegistration();
            fm.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin  frlm=new frmLogin();
            frlm.Show();
        }

        private void reportButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReporstUI anReporstUi=new ReporstUI();
            anReporstUi.Show();
        }
    }
}
