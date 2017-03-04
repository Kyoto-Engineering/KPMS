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
    public partial class SalaryCertificateWithCurrencyConversion : Form
    {
        public SalaryCertificateWithCurrencyConversion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalaryCertificateWithCurrencyConversionViewer f2 = new SalaryCertificateWithCurrencyConversionViewer();
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
            ReportSalaryCertificateWithCurrencyConversion cr = new ReportSalaryCertificateWithCurrencyConversion();
            tables = cr.Database.Tables;
            foreach (Table table in tables)
            {
                reportLogonInfo = table.LogOnInfo;
                reportLogonInfo.ConnectionInfo = reportConInfo;
                table.ApplyLogOnInfo(reportLogonInfo);
            }

            TextObject text1 = (TextObject)cr.ReportDefinition.Sections["DetailSection1"].ReportObjects["Text1"];
            text1.Text = textBox1.Text;
            TextObject text2 = (TextObject)cr.ReportDefinition.Sections["DetailSection1"].ReportObjects["Text9"];
            text2.Text = "Equivalent Value in " + textBox2.Text;
            TextObject text3 = (TextObject)cr.ReportDefinition.Sections["DetailSection1"].ReportObjects["Text5"];
            text3.Text = textBox3.Text;
            TextObject text4 = (TextObject)cr.ReportDefinition.Sections["DetailSection1"].ReportObjects["Text6"];
            text4.Text = textBox4.Text;
            TextObject text5 = (TextObject)cr.ReportDefinition.Sections["DetailSection1"].ReportObjects["Text26"];
            text5.Text = textBox5.Text;
            TextObject text6 = (TextObject)cr.ReportDefinition.Sections["DetailSection1"].ReportObjects["Text27"];
            text6.Text = textBox6.Text;
            f2.crystalReportViewer1.ReportSource = cr;
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;
        }

       // private void SalaryCertificateWithCurrencyConversion_Load(object sender, EventArgs e)
        //{
            
       // }
    }
}
