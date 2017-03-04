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
    public partial class EmployeeProfileForm : Form
    {
        ConnectionString cs = new ConnectionString();
        SqlDataReader rdr = null;
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();

        public EmployeeProfileForm()
        {
            InitializeComponent();
        }

        private void EmployeeProfileForm_Load(object sender, EventArgs e)
        {
 
            this.txtTime.Text = DateTime.Now.ToString();
            con = new SqlConnection(cs.DBConn);
            con.Open();
            string selectToGrid = "Select * from Attendence";
            SqlDataAdapter mydataadp = new SqlDataAdapter(selectToGrid,con);
            DataTable  dt=new DataTable();
            mydataadp.Fill(dt);
            dataGridView1Profile.DataSource = dt;


        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            SaveOutTime();
            frmLogin af =new frmLogin();
            af.Show();
        }



        private void SaveOutTime()
        {

            con = new SqlConnection(cs.DBConn);
            con.Open();

            string cb = "update Attendence set OutTime='" + System.DateTime.Now + "' where CurrentDate='" + System.DateTime.Now + "'";
            cmd = new SqlCommand(cb);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();

            //con = new SqlConnection(cs.DBConn);
            //con.Open();

            //string cb = "Update Attendence Set OutTime =" + System.DateTime.Now + "Where CurrentDate="+System.DateTime.Now+")";

            //cmd = new SqlCommand(cb);
            //cmd.Connection = con;
            //cmd.ExecuteReader();
            //con.Close();
            
        }










    }
}
