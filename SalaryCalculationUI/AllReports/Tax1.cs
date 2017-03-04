using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculationUI.AllReports
{
    public partial class Tax1 : Form
    {
        public Tax1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label7.Visible = !this.label7.Visible;
        }
    }
}
