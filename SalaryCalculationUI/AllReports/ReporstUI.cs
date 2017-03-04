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
using SalaryCalculationUI.LoginUI;
using SalaryCalculationUI.UI;

namespace SalaryCalculationUI.AllReports
{
    public partial class ReporstUI : Form
    {
        public int p;
        public ReporstUI()
        {
            InitializeComponent();
        }

        private void backToHomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OnlyUIForHR anForHr=new OnlyUIForHR();
            anForHr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creating an object of ParameterField class
            ParameterField paramField = new ParameterField();

            //creating an object of ParameterFields class
            ParameterFields paramFields = new ParameterFields();

            //creating an object of ParameterDiscreteValue class
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            //set the parameter field name
            paramField.Name = "id";

            //set the parameter value
            paramDiscreteValue.Value = p;

            //add the parameter value in the ParameterField object
            paramField.CurrentValues.Add(paramDiscreteValue);

            //add the parameter in the ParameterFields object
            paramFields.Add(paramField);
            Birthday a = new Birthday();
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
            ReportBirthday report = new ReportBirthday();
            tables = report.Database.Tables;
            foreach (Table table in tables)
            {
                reportLogonInfo = table.LogOnInfo;
                reportLogonInfo.ConnectionInfo = reportConInfo;
                table.ApplyLogOnInfo(reportLogonInfo);
            }
            a.crystalReportViewer1.ParameterFieldInfo = paramFields; 
            a.crystalReportViewer1.ReportSource = report;
            this.Visible = false;

            a.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //creating an object of ParameterField class
            ParameterField paramField = new ParameterField();

            //creating an object of ParameterFields class
            ParameterFields paramFields = new ParameterFields();

            //creating an object of ParameterDiscreteValue class
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            //set the parameter field name
            paramField.Name = "id";

            //set the parameter value
            paramDiscreteValue.Value = p;

            //add the parameter value in the ParameterField object
            paramField.CurrentValues.Add(paramDiscreteValue);

            //add the parameter in the ParameterFields object
            paramFields.Add(paramField);
            Contact a = new Contact();
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
            ReportContact report = new ReportContact();
            tables = report.Database.Tables;
            foreach (Table table in tables)
            {
                reportLogonInfo = table.LogOnInfo;
                reportLogonInfo.ConnectionInfo = reportConInfo;
                table.ApplyLogOnInfo(reportLogonInfo);
            }
            a.crystalReportViewer1.ParameterFieldInfo = paramFields; 
            a.crystalReportViewer1.ReportSource = report;
            this.Visible = false;

            a.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //creating an object of ParameterField class
            ParameterField paramField = new ParameterField();

            //creating an object of ParameterFields class
            ParameterFields paramFields = new ParameterFields();

            //creating an object of ParameterDiscreteValue class
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            //set the parameter field name
            paramField.Name = "id";

            //set the parameter value
            paramDiscreteValue.Value = p;

            //add the parameter value in the ParameterField object
            paramField.CurrentValues.Add(paramDiscreteValue);

            //add the parameter in the ParameterFields object
            paramFields.Add(paramField);
            dynamic a = new Resume();
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
            ReportResume report = new ReportResume();
            tables = report.Database.Tables;
            foreach (Table table in tables)
            {
                reportLogonInfo = table.LogOnInfo;
                reportLogonInfo.ConnectionInfo = reportConInfo;
                table.ApplyLogOnInfo(reportLogonInfo);
            }
            a.crystalReportViewer1.ParameterFieldInfo = paramFields;
            a.crystalReportViewer1.ReportSource = report;
            this.Visible = false;
            a.ShowDialog();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SalaryConfirmationLetterUI1 x=new SalaryConfirmationLetterUI1();
            this.Visible = false;
            x.ShowDialog();
            this.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            dynamic a = new SalarySummerySheet();
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
            ReportSummerySheet report = new ReportSummerySheet();
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

        private void button6_Click(object sender, EventArgs e)
        {
            dynamic a =new PayslipGenarator();
            this.Visible = false;

            a.ShowDialog();
            this.Visible = true; 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dynamic a = new BankInformLetter();
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
            ReportBankInformLetter report = new ReportBankInformLetter();
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

        private void button8_Click(object sender, EventArgs e)
        {
            SalaryCertificateWithCurrencyConversion z=new SalaryCertificateWithCurrencyConversion();
            this.Visible = false;
            z.ShowDialog();
            this.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TaxPaySheetGenarator x=new TaxPaySheetGenarator();
            this.Visible = false;
            x.ShowDialog();
            this.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //creating an object of ParameterField class
            ParameterField paramField = new ParameterField();

            //creating an object of ParameterFields class
            ParameterFields paramFields = new ParameterFields();

            //creating an object of ParameterDiscreteValue class
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            //set the parameter field name
            paramField.Name = "id";

            //set the parameter value
            paramDiscreteValue.Value = p;

            //add the parameter value in the ParameterField object
            paramField.CurrentValues.Add(paramDiscreteValue);

            //add the parameter in the ParameterFields object
            paramFields.Add(paramField);
            dynamic a = new ReportViewer1();
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
            EmployeeList report = new EmployeeList();
            tables = report.Database.Tables;
            foreach (Table table in tables)
            {
                reportLogonInfo = table.LogOnInfo;
                reportLogonInfo.ConnectionInfo = reportConInfo;
                table.ApplyLogOnInfo(reportLogonInfo);
            }
            a.crystalReportViewer1.ParameterFieldInfo = paramFields; 
            a.crystalReportViewer1.ReportSource = report;
            
            this.Visible = false;

            a.ShowDialog();
            this.Visible = true; 
        }

        private void ReporstUI_Load(object sender, EventArgs e)
        {
            p = frmLogin.uId;
            timer1.Interval = 500;
            timer1.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //creating an object of ParameterField class
            ParameterField paramField = new ParameterField();

            //creating an object of ParameterFields class
            ParameterFields paramFields = new ParameterFields();

            //creating an object of ParameterDiscreteValue class
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            //set the parameter field name
            paramField.Name = "id";

            //set the parameter value
            paramDiscreteValue.Value = p;

            //add the parameter value in the ParameterField object
            paramField.CurrentValues.Add(paramDiscreteValue);

            //add the parameter in the ParameterFields object
            paramFields.Add(paramField);
            dynamic a = new ReportViewer1();
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
            GradeReport report = new GradeReport();
            tables = report.Database.Tables;
            foreach (Table table in tables)
            {
                reportLogonInfo = table.LogOnInfo;
                reportLogonInfo.ConnectionInfo = reportConInfo;
                table.ApplyLogOnInfo(reportLogonInfo);
            }
            a.crystalReportViewer1.ParameterFieldInfo = paramFields;
            a.crystalReportViewer1.ReportSource = report;

            this.Visible = false;

            a.ShowDialog();
            this.Visible = true; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Visible = !this.label1.Visible;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dynamic a = new ReportViewer1();
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
            WithoutAccount report = new WithoutAccount();
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
    }
}
