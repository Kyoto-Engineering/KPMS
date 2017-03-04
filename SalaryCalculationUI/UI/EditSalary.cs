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
    public partial class EditSalary : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        ConnectionString cs = new ConnectionString();
        private SqlDataReader rdr;
        public string submittedBy2, fullName2;
        public static int x;

        public EditSalary()
        {
            InitializeComponent();
        }
        private void FillYear()
        {
            try
            {


                yearComboBox1.Items.Clear();
                yearComboBox1.Text = "";
                yearComboBox1.Enabled = true;
                yearComboBox1.Focus();

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select  distinct RTRIM(Salary.Year) from Salary";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    yearComboBox1.Items.Add(rdr[0]);
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditSalary_Load(object sender, EventArgs e)
        {
            FillYear();
        }

        private void yearComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select distinct RTRIM(Salary.EmployeeId) from Salary  Where Salary.Year= '" + yearComboBox1.Text + "'  and salary.Months='"+monthComboBox.Text+"'";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    employeeIdComboBox.Items.Add(rdr[0]);
                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select Salary.Id from Salary  Where Salary.Year= '" + yearComboBox1.Text + "'  and Salary.Months='" + monthComboBox.Text + "'and Salary.EmployeeId='"+employeeIdComboBox.Text+"'";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    x = (rdr.GetInt32(0));
                }


               
                con.Close(); 

                SalaryUpdateForm f2 =new SalaryUpdateForm();
                this.Visible = true;
                f2.ShowDialog();
                this.Visible = false;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
