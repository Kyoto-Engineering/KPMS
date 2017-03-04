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

namespace SalaryCalculationUI.AllReports
{
    public partial class TaxPaySheetGenarator : Form
    {
        public TaxPaySheetGenarator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            conn = new SqlConnection("server=tcp:KyotoServer,49172;database=EmployeeMSDb;UID=sa;password=SystemAdministrator");
            conn.Open();
            string strSQLCommand = "ALTER VIEW [Tax Sheet] AS SELECT EmployeeId,Basic,Tax,TransportAllowance,MedicalAllowance,HouseRent,InterimAllowance,OtherAllowance,Bonus,Convert(date,'01-'+Convert(nvarchar(50),Months)+'-'+Convert(nvarchar(50),Year),103) as Month_Year FROM Salary";
            SqlCommand command = new SqlCommand(strSQLCommand, conn);
            string returnvalue = (string)command.ExecuteScalar();
            conn.Close();
            timer1.Stop();
            label1.ForeColor=Color.Black;
            timer2.Stop();
            button1.BackColor = Color.Gray;
            label1.Visible = false;
            label7.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button1.Visible = false;
            timer3.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tax1 f2 = new Tax1();
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
            Report1Tax cr = new Report1Tax();
            tables = cr.Database.Tables;
            foreach (Table table in tables)
            {
                reportLogonInfo = table.LogOnInfo;
                reportLogonInfo.ConnectionInfo = reportConInfo;
                table.ApplyLogOnInfo(reportLogonInfo);
            }

           
            f2.crystalReportViewer1.ReportSource = cr;
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tax2 f2 = new Tax2();
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
            Report1Tax1 cr = new Report1Tax1();
            tables = cr.Database.Tables;
            foreach (Table table in tables)
            {
                reportLogonInfo = table.LogOnInfo;
                reportLogonInfo.ConnectionInfo = reportConInfo;
                table.ApplyLogOnInfo(reportLogonInfo);
            }


            f2.crystalReportViewer1.ReportSource = cr;
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Visible = !this.label1.Visible;
           
            
        }

        private void TaxPaySheetGenarator_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer2.Interval = 250;
            timer3.Interval = 1000;
            timer1.Start();
            timer2.Start();
            label7.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Gray)
            {
                button1.BackColor = Color.Red;
            }
            else
            {
                button1.BackColor = Color.Gray;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.label7.Visible = !this.label7.Visible;
        }
    }
}
