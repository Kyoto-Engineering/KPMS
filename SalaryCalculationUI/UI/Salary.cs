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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dynamic f2 = new SalaryDelete();
            f2.ShowDialog();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            SalaryDetailsGrid2 aGrid = new SalaryDetailsGrid2();
            this.Visible = false;
            aGrid.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =
                MessageBox.Show(
                    "All Your Employee Information is  Needed To be Up To Date ( Specially Account Number, Designation, Employee Stage , Employee Status And Grade ). Is All Employee information Up To Date? ", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
            dynamic aform = new SalaryIn();
            this.Visible = false;
            aform.ShowDialog();
            this.Visible = true;
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditSalary f2=new EditSalary();
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;
        }
    }
}
