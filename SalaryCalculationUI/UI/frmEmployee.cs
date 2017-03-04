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
    public partial class frmEmployee : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        ConnectionString cs=new ConnectionString();
        private SqlDataReader rdr;
        public frmEmployee()
        {
            InitializeComponent();
        }
        public void PopulateGradeId()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select RTRIM(GradeId) from Grade order by GradeId";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                   cmbGradeId.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            PopulateGradeId();
        }
    }
}
