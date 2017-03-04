using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculationUI.UI
{
    public partial class EmployeeUI : Form
    {
        public EmployeeUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dynamic aform = new EmployeeInfoForm();
            aform.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            EmployeeEditForm aForm = new EmployeeEditForm();
            aForm.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditEducation f2 = new EditEducation();
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmployeeDetailsGrid f2=new EmployeeDetailsGrid();
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GradeChange x=new GradeChange();
            this.Visible = false;
            x.ShowDialog();
            this.Visible = true;
        }
    }
}
