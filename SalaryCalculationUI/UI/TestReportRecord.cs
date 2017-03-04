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
using CrystalDecisions.CrystalReports.Engine;
using SalaryCalculationUI.DBGateway;
using SalaryCalculationUI.Reports;

namespace SalaryCalculationUI.UI
{
    public partial class TestReportRecord : Form
    {
        ConnectionString cs = new ConnectionString();
        SqlDataReader rdr = null;

        SqlConnection con = null;
        SqlCommand cmd = null;
        public TestReportRecord()
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
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                //timer1.Enabled = true;
                CrystalReportForTest rpt = new CrystalReportForTest();
                //The report you created.
                TestReportRecord frm = new TestReportRecord();
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();
                SalaryDataSet myDS = new SalaryDataSet();
                //The DataSet you created.
                myConnection = new SqlConnection(cs.DBConn);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select Id, EmployeeId, EmployeeName,Designation from Salary;";
                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "Customer");
                rpt.SetDataSource(myDS);
                frm.crystalReportViewer1.ReportSource = rpt;
               // frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //string selectquery = "select EmployeeName, AccountNo, Designation,NetPayable from Salary;";
            //string selectquery = "select * from Salary";
            //DataSet dt = new DataSet();
            //con = new SqlConnection(cs.DBConn);
            //cmd = new SqlCommand(selectquery, con);
            //cmd.CommandType = CommandType.Text;
            //SqlDataAdapter testda = new SqlDataAdapter(cmd);
            //testda.Fill(dt);
            //con.Open();
            //ReportDocument myReportDocument;
            //myReportDocument = new ReportDocument(); 
            //myReportDocument.Load(@"G:\Project 28-04-2016\SalaryCalculationUI27-04-2016\SalaryCalculationUI\Reports\CrystalReportForTest.rpt");
            //myReportDocument.SetDataSource(dt);
            //myReportDocument.SetDatabaseLogon("sa", "SystemAdministrator");
            //crystalReportViewer1.ReportSource = myReportDocument;
           // crystalReportViewer1.DisplayToolbar = true;
        }
    }
}

