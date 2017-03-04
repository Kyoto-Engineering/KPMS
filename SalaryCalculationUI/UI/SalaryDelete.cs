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
    public partial class SalaryDelete : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        ConnectionString cs = new ConnectionString();
        private SqlDataReader rdr;
        private int x;
        public SalaryDelete()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                salaryIdComboBox.Items.Clear();
                salaryIdComboBox.Text = "";
                salaryIdComboBox.Enabled = true;
                salaryIdComboBox.Focus();

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select distinct RTRIM(Salary.Id) from Salary Where Salary.Months='" + monthComboBox2.Text + "' and Year='" + yearComboBox1.Text + "'"; 
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    salaryIdComboBox.Items.Add(rdr[0]);
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
                string ct = "DELETE FROM Salary WHERE Id='" + salaryIdComboBox.Text + "'"; 
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
