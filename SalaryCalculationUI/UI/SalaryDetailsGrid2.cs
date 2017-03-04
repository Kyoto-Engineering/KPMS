using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryCalculationUI.DBGateway;

namespace SalaryCalculationUI.UI
{
    public partial class SalaryDetailsGrid2 : Form
    {
        private SqlConnection con;
        ConnectionString cs=new ConnectionString();
        public SalaryDetailsGrid2()
        {
            InitializeComponent();
        }

        private void backToHomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalaryDetailsEntryForm aForm=new SalaryDetailsEntryForm();
            aForm.Show();
        }

        private void SalaryDetailsGrid2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cs.DBConn);
            con.Open();
            string selectQuery = "Select * from Salary";
            //string selectQuery = "Select  Months, Year,EmployeeId, EmployeeName,Designation,TotalworkingDay,DayPayable,LeaveWithPay,UnpaidLeave,Basic, TransportAllowance,MedicalAllowance,HouseRent,OtherAllowance,GrossSalary,Tax,DeductionForLeave,Fine,DeductionFromAnnualLeave,Adjustment,AdvancePaid,TotalDeduction,PreviousDues,TotalAddition,NetPayable from Salary";
            SqlDataAdapter myadapter = new SqlDataAdapter(selectQuery, con);
            DataTable dt = new DataTable();
            myadapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
