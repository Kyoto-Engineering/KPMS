using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using SalaryCalculationUI.DBGateway;
using SalaryCalculationUI.Reports;

namespace SalaryCalculationUI.NReports
{
    public partial class SalarySheetRecord : Form
    {
        ConnectionString cs=new ConnectionString();
        private SqlConnection con;
        public SalarySheetRecord()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cs.DBConn);
            con.Open();
            string query = @"Select EmployeeId,AccountNo,GrossSalary,NetPayable from Salary";

            SqlCommand cmd = new SqlCommand(query,con );
            cmd.CommandText=query;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable datatable = new DataTable();
            da.Fill(datatable); // getting value according to imageID and fill dataset

            ReportDocument crystalReport = new ReportDocument(); // creating object of crystal report
            //crystalReport.Load(Microsoft.SqlServer.Server.MapPath("~/CrystalPersonInfo.rpt")); // path of report 
            //crystalReport.Load(Path.Combine("~/Reports/CrystalReportForSalarySheetSammary1.rpt"));
            crystalReport.SetDataSource(datatable); // binding datatable
            crystalReportViewer1.ReportSource = crystalReport;
            crystalReportViewer1.Refresh();




            //ReportDocument cryRpt = new ReportDocument();
            //cryRpt.Load("~/Reports/CrystalReportForSalarySheetSammary1.rpt");
            //crystalReportViewer1.ReportSource = cryRpt;
            //crystalReportViewer1.Refresh();


            //try
            //{
            //    ExportOptions CrExportOptions;

            //    DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();
            //    ExcelFormatOptions CrFormatTypeOptions = new ExcelFormatOptions();
            //    CrDiskFileDestinationOptions.DiskFileName = "c:\\csharp.net-informations.xls";
            //    CrExportOptions = cryRpt.ExportOptions;
            //    CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
            //    CrExportOptions.ExportFormatType = ExportFormatType.Excel;
            //    CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;
            //    CrExportOptions.FormatOptions = CrFormatTypeOptions;
            //    cryRpt.Export();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }
    }
}
