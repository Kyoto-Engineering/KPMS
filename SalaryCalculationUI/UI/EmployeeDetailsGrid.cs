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
    public partial class EmployeeDetailsGrid : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        ConnectionString cs=new ConnectionString();
        public EmployeeDetailsGrid()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            con = new SqlConnection(cs.DBConn);
            con.Open();
            string selectQuery = "Select EmployeeId,EmployeeName,FatherName,MotherName,NickName,Gender,CorporateMail,EmailId,DateOfBirth,NationalId,AreaOrCountryCode1,Contact1,AreaOrCountryCode2,Contact2,Department,Designation,AccountNumber,GradeId,EducationHistry,LocalGardianName,JoiningDate,ConformationDate,EndofTraineePeriods,EndofTraineePeriod from Employee;";
            SqlDataAdapter myadapter = new SqlDataAdapter(selectQuery, con);
            DataTable dt = new DataTable();
            myadapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void EmployeeDetailsGrid_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dynamic aForm22 = new BasicEmployeeInfoGrid();
            aForm22.ShowDialog();
            this.Visible = true;
        }
    }
}
