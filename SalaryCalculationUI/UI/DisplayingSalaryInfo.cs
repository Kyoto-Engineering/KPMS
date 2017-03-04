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
using CrystalDecisions.Shared;
using Microsoft.Reporting.WinForms;
using SalaryCalculationUI.DAO;
using SalaryCalculationUI.Reports;

namespace SalaryCalculationUI.UI
{
    public partial class DisplayingSalaryInfo : Form
    {
        private DataTable DT;
        public DisplayingSalaryInfo()
        {
            InitializeComponent();
        }

        private void DisplayingSalaryInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'EmployeeMSDbDataSet.Salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter.Fill(this.EmployeeMSDbDataSet.Salary);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.salaryTableAdapter.FillBy(this.EmployeeMSDbDataSet.Salary);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void SalaryDetails_Enter(object sender, EventArgs e)
        {

        }

        private DataTable getSalaryData(int id)
        {
            SqlConnection conn=new SqlConnection(SalaryCalculationUI.Properties.Settings.Default.EmployeeMSDbConnectionString);
            //string query = string.Format(@"Select * from ");
            SqlDataAdapter DA = new SqlDataAdapter("getSalaryData",conn);
            DataTable dt=new DataTable();
            DA.SelectCommand.Parameters.AddWithValue("@Id", id);
            DA.SelectCommand.CommandType = CommandType.StoredProcedure;
            conn.Open();
            DA.Fill(dt);
            conn.Close();
            return dt;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ReportDocument rpt=new ReportDocument();
            DataSet ds=new DataSet();
            ds.Tables[0].Merge(DT);
            rpt.Load(@"G:\Project 28-04-2016\SalaryCalculationUI27-04-2016\SalaryCalculationUI\Reports\CrystalReportForSalarySheetSammary.rpt");
            rpt.SetDataSource(ds);
       

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalaryDetailsEntryForm aForm=new SalaryDetailsEntryForm();
            aForm.Show();
        }

        private void getDataButton_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlParameter para = new SqlParameter();

            ReportDocument report = new ReportDocument();
            ConnectionInfo conInfo = new ConnectionInfo();

            con.Open();
            cmd = new SqlCommand("spGetResultdriver", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add(new SqlParameter("@DateFrom", SqlDbType.DATATYPE, LENGTH, "From"));
            //cmd.Parameters.Add(new SqlParameter("@DateTo", SqlDbType.DATATYPE, LENGTH, "To"));
            //cmd.Parameters.Add(new SqlParameter("@CompanyID", SqlDbType.DATATYPE, LENGTH, "Location"));
            //cmd.Parameters.Add(new SqlParameter("@ShowDriversUsing", SqlDbType.DATATYPE, LENGTH, "Location"));
            //cmd.Parameters.Add(new SqlParameter("@SigDate", SqlDbType.DATATYPE, LENGTH, "Location"));

            //cmd.Parameters[0].Value = dtpFrom.Text;
            //cmd.Parameters[1].Value = dtpTo.Text;
            //cmd.Parameters[2].Value = cbCityCode.Text;
            //cmd.Parameters[3].Value = dtpTo.Text;
            //cmd.Parameters[4].Value = cbCityCode.Text;

            conInfo.DatabaseName = "db name";
            conInfo.UserID = "user id";
            conInfo.Password = "password";
            int i = cmd.ExecuteNonQuery();
            con.Close();

            report.Load("report path");
            ReportViewer reportViewer=new ReportViewer();
            reportViewer.RefreshReport();
           // SetDBLogonForReport(conInfo, report);
            //crvReports.ReportSource = report;
            //crvReports.Refresh();


            //SalaryDetailsEntryForm crystalReport = new SalaryDetailsEntryForm();
            //Salary dsCustomers = GetData();
            //crystalReport.SetDataSource(dsCustomers);
        //reportViewer1.ReportSource = crystalReport;
        //   reportViewer1.RefreshReport();
        }

        
     

        

        
    }
}
