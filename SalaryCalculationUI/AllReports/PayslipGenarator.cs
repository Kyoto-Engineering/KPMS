using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace SalaryCalculationUI.AllReports
{
    public partial class PayslipGenarator : Form
    {
        public PayslipGenarator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dynamic a = new PayslipAll();
            TableLogOnInfos reportLogonInfos = new TableLogOnInfos();
            TableLogOnInfo reportLogonInfo = new TableLogOnInfo();
            ConnectionInfo reportConInfo = new ConnectionInfo();
            Tables tables = default(Tables);
            //	Table table = default(Table);
            var with1 = reportConInfo;
            with1.ServerName = "tcp:KyotoServer,49172";
            with1.DatabaseName = "EmployeeMSDb";
            with1.UserID = "sa";
            with1.Password = "SystemAdministrator";
            ReportPayslip1 report = new ReportPayslip1();
            tables = report.Database.Tables;
            foreach (Table table in tables)
            {
                reportLogonInfo = table.LogOnInfo;
                reportLogonInfo.ConnectionInfo = reportConInfo;
                table.ApplyLogOnInfo(reportLogonInfo);
            }
            a.crystalReportViewer1.ReportSource = report;
            this.Visible = false;

            a.ShowDialog();
            this.Visible = true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dynamic b = new PayslipIndividualUI();
            this.Visible = false;

            b.ShowDialog();
            this.Visible = true; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.label2.ForeColor == Color.Black)
            {
                this.label2.ForeColor = Color.Red;
            }
            else
            {
                this.label2.ForeColor =Color.Black;
            }
        }

        private void PayslipGenarator_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();
        }
    }
}
