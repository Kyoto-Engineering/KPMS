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

namespace SalaryCalculationUI.LoginUI
{
    public partial class UserDetailGridData : Form
    {
        ConnectionString cs = new ConnectionString();
        SqlDataReader rdr = null;
        
        SqlConnection con = null;
        SqlCommand cmd = null;
        
        public UserDetailGridData()
        {
            InitializeComponent();
        }

        private SqlConnection Connection
        {
            get
            {
                SqlConnection ConnectionToFetch = new SqlConnection(cs.DBConn);
                ConnectionToFetch.Open();
                return ConnectionToFetch;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UserDetailGridData_Load(object sender, EventArgs e)
        {
            con=new SqlConnection(cs.DBConn);
            con.Open();
            string selectk = "Select UserId, Username, Name,Password,ContactNo,Email,JoiningDate from Registration";
            SqlDataAdapter  myadp=new SqlDataAdapter(selectk,con);
            DataTable dt =new DataTable();
            myadp.Fill(dt);
            dataGridView111.DataSource = dt;


        }

        public DataView GetData()
        {
            dynamic SelectQry = "SELECT RTRIM(Username) as [User Name],RTRIM(Password) as [Password],RTRIM(Name) as [Name],RTRIM(ContactNo) as [Contact No.],RTRIM(Email) as [Email ID],RTRIM(joiningdate) as [Date Of Joining] FROM registration";
            DataSet SampleSource = new DataSet();
            DataView TableView = null;
            try
            {
                SqlCommand SampleCommand = new SqlCommand();
                dynamic SampleDataAdapter = new SqlDataAdapter();
                SampleCommand.CommandText = SelectQry;
                SampleCommand.Connection = Connection;
                SampleDataAdapter.SelectCommand = SampleCommand;
                SampleDataAdapter.Fill(SampleSource);
                TableView = SampleSource.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return TableView;
        }
    }
}
