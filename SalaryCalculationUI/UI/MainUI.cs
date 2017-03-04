using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryCalculationUI.AllReports;
using SalaryCalculationUI.LoginUI;
using SalaryCalculationUI.NReports;

namespace SalaryCalculationUI.UI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void salaryButton_Click(object sender, EventArgs e)
        {
            Salary f2= new Salary();
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;

        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            dynamic aform =new EmployeeUI();
            this.Visible = false;
            
            aform.ShowDialog();
            this.Visible = true;
        }

        private void gradeButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dynamic aform = new GradeCalculationEntryForm();
            aform.ShowDialog();
            this.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            dynamic aform = new SalaryDetailsGrid2();
            aform.ShowDialog();
            this.Visible = true;
           
            
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            
            
            
            frmRegistration fem=new frmRegistration();
            this.Visible = false;
            fem.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin knw=new frmLogin();
            knw.Show();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLogin  afrm=new frmLogin();
            afrm.Show();
        }

        private void Report1Button_Click(object sender, EventArgs e)
        {
            TestReportRecord aRecord=new TestReportRecord();
            aRecord.Show();
            //SalarySheetRecord ssrdRecord=new SalarySheetRecord();
            //ssrdRecord.Show();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dynamic aform = new ReporstUI();
            aform.ShowDialog();
            this.Visible = true;
            
        }

        private void frmAboutButton_Click(object sender, EventArgs e)
        {
            frmAbout ag=new frmAbout();
            ag.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label2.Visible = !this.label2.Visible;
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            timer1.Interval = 250;
            timer1.Start();
            timer2.Interval = 450;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.label4.Visible = !this.label4.Visible;
        }
    }
}
