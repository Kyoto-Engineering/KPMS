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
    public partial class SalaryConfirmationLetterUI1 : Form
    {
        public SalaryConfirmationLetterUI1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SalaryConfirmationLetterV1 f2 = new SalaryConfirmationLetterV1();
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
            ReportSalaryConfirmationLetterV1 cr = new ReportSalaryConfirmationLetterV1();
            tables = cr.Database.Tables;
            foreach (Table table in tables)
            {
                reportLogonInfo = table.LogOnInfo;
                reportLogonInfo.ConnectionInfo = reportConInfo;
                table.ApplyLogOnInfo(reportLogonInfo);
            }
            TextObject text1 = (TextObject)cr.ReportDefinition.Sections["DetailSection1"].ReportObjects["Text1"];
            text1.Text = textBox1.Text;
            TextObject text2 = (TextObject)cr.ReportDefinition.Sections["DetailSection1"].ReportObjects["Text2"];
            text2.Text = textBox2.Text;
            TextObject text3 = (TextObject)cr.ReportDefinition.Sections["DetailSection1"].ReportObjects["Text3"];
            if (textBox3.Text == "")
            {
                string x = "House No." + textBox4.Text + ',' + "Road No." + textBox5.Text;
                text3.Text = x;
            }
            else
            {
                string x = "Level No." + textBox3.Text + ',' + "House No." + textBox4.Text + ',' + "Road No." +
                           textBox5.Text;
                text3.Text = x;
            }




            TextObject text4 = (TextObject)cr.ReportDefinition.Sections["DetailSection1"].ReportObjects["Text4"];
            if (textBox6.Text == "")
            {
                string strIp1 = textBox7.Text + ',' + textBox8.Text;
                text4.Text = strIp1;
            }
            else
            {
                string strIp1 = textBox6.Text + ',' + textBox7.Text + ',' + textBox8.Text;
                text4.Text = strIp1;
            }

            TextObject text5 = (TextObject)cr.ReportDefinition.Sections["DetailSection1"].ReportObjects["Text5"];
            text5.Text = textBox9.Text;
            TextObject text6 = (TextObject)cr.ReportDefinition.Sections["DetailSection1"].ReportObjects["Text6"];
            text6.Text = textBox10.Text;


            f2.crystalReportViewer1.ReportSource = cr;
            f2.Show();
        }
    }
}
