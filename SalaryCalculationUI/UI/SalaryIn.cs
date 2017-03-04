using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace SalaryCalculationUI.UI
{
    public partial class SalaryIn : Form
    {
        public static string a,b,c, d ;
        public SalaryIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (referenceNoTextBox.Text == "")
            {
                MessageBox.Show("Please enter the reference No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                referenceNoTextBox.Focus();
                return;
            }
            if (yearComboBox.Text == "")
            {
                MessageBox.Show("Please enter the year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                yearComboBox.Focus();
                return;
            }
            if (monthComboBox.Text == "")
            {
                MessageBox.Show("Please Select the Month", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                monthComboBox.Focus();
                return;
            }
            if (totalWorkingDayComboBox.Text == "")
            {
                MessageBox.Show("Please Select the Total Working Day", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                totalWorkingDayComboBox.Focus();
                return;
            }
            a = referenceNoTextBox.Text;
            b = yearComboBox.Text;
            c = monthComboBox.Text;
            d = totalWorkingDayComboBox.Text;
            dynamic aform = new SalaryDetailsEntryForm();
            this.Visible = false;
            aform.ShowDialog();
            this.Visible = true;
        }
    }
}
