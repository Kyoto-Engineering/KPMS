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
    public partial class Claim : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        public Claim()
        {
            InitializeComponent();
            List<Employee2> employees = new List<Employee2>();
              try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = new SqlCommand(" SELECT        EmployeeName, Designation, Department FROM            Employee where Status ='Active'", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            
                while (rdr.Read() == true)
                {
                    employees.Add(new Employee2() { Name =rdr[0].ToString(),  Designation =rdr[1].ToString(),Department = rdr[2].ToString()});
                    //dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            //for (int i = 0; i < 10; i++)
            //{
            //    employees.Add(new Employee2() { Name = "Name" + i, Designation = "Address" + i, Department = "TelephoneNumber" + i });

            //}

            this.comboBoxWithGrid_WinformsHost1.Employee2s = employees;

            //this.comboBoxWithGrid_WinformsHost1.SelectedIndex = 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string name =
            comboBoxWithGrid_WinformsHost1.SelectedItem.Name;
            textBox1.Text = name;
        }

        
    }
}
