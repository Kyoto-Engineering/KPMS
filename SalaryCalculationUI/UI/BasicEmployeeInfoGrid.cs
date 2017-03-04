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
    public partial class BasicEmployeeInfoGrid : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        ConnectionString cs=new ConnectionString();
        public BasicEmployeeInfoGrid()
        {
            InitializeComponent();
        }

        private void BasicEmployeeInfoGrid_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cs.DBConn);
            con.Open();
            string selectQuery = "Select EmployeeId,EmployeeName,FatherName,MotherName,NickName,Gender,EmailId as PersonalMail,DateOfBirth,NationalId,Contact2 as PersonalNumber,Department,Designation from Employee";
            SqlDataAdapter myadapter = new SqlDataAdapter(selectQuery, con);
            DataTable dt = new DataTable();
            myadapter.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }
    }
}
