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
using SalaryCalculationUI.DAO;
using SalaryCalculationUI.DBGateway;
using SalaryCalculationUI.Gateway;
using CrystalDecisions.Shared;
using SalaryCalculationUI.AllReports;
using CrystalDecisions.CrystalReports.Engine;

namespace SalaryCalculationUI.UI
{
    public partial class SalaryUpdateForm : Form
    {
        private double tx = 0.0000, netgross = 0.0000, prds = 0.0000, FC = 0.0000, FCd = 0.0000,
             ddlc = 0.0000, z = 0.0000, tlb = 0.0000, netPayable = 0.0000, s = 0.000;
        private EmployeeGateway employeeGateway;
        private GradeGateway GGateway;
        public Employee employee;
        public Grade grade;
        private SqlConnection con;
        private SqlCommand cmd;
        ConnectionString cs = new ConnectionString();
        private SqlDataReader rdr;
        public int newRowID, confusedRowId;
        public decimal mydecimal;
        private int salId,dp;
        public string accnou;
        public SalaryUpdateForm()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            EditSalary Ed =new EditSalary();
            if (referenceNoTextBox.Text == "")
            {
                MessageBox.Show("Please enter the reference No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                referenceNoTextBox.Focus();
                return;
            }

            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                String cb = "Update Salary set EmployeeId='" + Convert.ToInt64(cmbEmployeeId.Text) + "', EmployeeName='" + employeeNameTextBox.Text + "',Designation='" + designationTextBox.Text + "',AccountNo='" + accountNoTextBox.Text + "',Months='" + monthComboBox.Text + "',Year= '" + yearComboBox.Text + "',ReferenceNo= '" + referenceNoTextBox.Text + "',GradeId= '" + gradeTextBox.Text + "',Basic='" + basicSalaryTextBox.Text + "',TransportAllowance='" + transportAllowanceTextBox.Text + "',MedicalAllowance='" + medicalAllowanceTextBox.Text + "',HouseRent='" + houserentTextBox.Text + "',OtherAllowance='" + otherAllowanceTextBox.Text + "',InterimAllowance='" + interimAllowanceTextBox.Text + "',GrossSalary='" + grossSalaryTextBox.Text + "',Tax='" + taxTextBox.Text + "',NetGrossSalaryAfterTax='" + netGrossSalaryAfterTaxTextBox.Text + "',TotalWorkingDay='" + totalWorkingDayComboBox.Text + "',PerdaySalary='" + perdaySalaryTextBox.Text + "',DayPayable='" + dp + "',UnpaidLeave='" + unPaidLeaveTextBox.Text + "',GivenAnnualLeave='" + leftALFrom14DaysTextBox.Text + "',PHAttendence='" + pHAttendenceTextBox.Text + "',LeaveWithPay='" + leaveWithPayTextBox.Text + "',Fine='" + fineComboBox.Text + "',DeductionFromAnnualLeave='" + deductionForALTotalTextBox.Text + "',AdvancePaid='" + advancedPaidTextBox.Text + "',DeductionForLeave='" + deductionForLeaveTextBox.Text + "',Adjustment='" + adjustmentTextBox.Text + "',TotalDeduction='" + DeductionFromSalarytextBox1.Text + "',Bonus='" + bonusTextBox.Text + "',PreviousDues='" + previousDueTextBox.Text + "',TotalAddition='" + totalAdditionTextBox.Text + "',NetPayable='" + netPayableTextBox.Text + "' where Id= '" + salId + "'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();

                newRowID = salId;
                MessageBox.Show("Successfully Updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
               Report2();
                this.Dispose();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void TotalAdditionCalculate()
        {
            double b, c;
            b = double.Parse(previousDueTextBox.Text);
            c = double.Parse(bonusTextBox.Text);
            tlb = (c + b);
            totalAdditionTextBox.Text = tlb.ToString();

        }
        public void CalculateNetPayables()
        {
            double w, x, y;
            w = double.Parse(netGrossSalaryAfterTaxTextBox.Text);
            x = double.Parse(DeductionFromSalarytextBox1.Text);
            y = double.Parse(totalAdditionTextBox.Text);
            netPayable = ((w + y) - x);
            netPayableTextBox.Text = netPayable.ToString();

        }
        //public void PopEmpId()
        //{
        //    try
        //    {
        //     con = new SqlConnection(cs.DBConn);
        //     con.Open();
        //     string ct = "select RTRIM(EmployeeId) from Salary order by EmployeeId";
        //    cmd = new SqlCommand(ct);
        //    cmd.Connection = con;
        //    rdr = cmd.ExecuteReader();
        //     while (rdr.Read())
        //        {
        //            empIdComboBox.Items.Add(rdr[0]);
        //        }
        //        con.Close();
               
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        // public void FillCombo()
        //{
        //    try
        //    {

        //        con = new SqlConnection(cs.DBConn);
        //        con.Open();
        //        string ct = "select RTRIM(CategoryName) from Category order by CategoryName";
        //        cmd = new SqlCommand(ct);
        //        cmd.Connection = con;
        //        rdr = cmd.ExecuteReader();

        //        while (rdr.Read())
        //        {
        //            cmbCategory.Items.Add(rdr[0]);
        //        }
        //        con.Close();
               
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        public void EmpIdPopulateCom()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select RTRIM(EmployeeId) from Employee Where Status='Active' order by EmployeeId";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbEmployeeId.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SalaryUpdateForm_Load(object sender, EventArgs e)
        {
            //PopEmpId();
            EmpIdPopulateCom();
            salId = EditSalary.x;
            timer1.Interval = 500;
            timer1.Start();
            referenceNoTextBox.Focus();
        }

        private void employeeIdTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void FineCalCulate()
        {
            double a, d;
            a = double.Parse(fineComboBox.Text);
            d = double.Parse(allowFineTextBox.Text);
            FC = (a * d);
            totalFineTextBox.Text = FC.ToString();
        }
        private void allowFineTextBox_TextChanged(object sender, EventArgs e)
        {
            FineCalCulate();
        }
        private void DeductionForALCalCulate()
        {
            double k, G;
            k = double.Parse(deductionForALComboBox.Text);
            G = double.Parse(perdaySalaryTextBox.Text);
            FCd = (k * G);
            deductionForALTotalTextBox.Text = FCd.ToString();
        }
        private void deductionForALComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeductionForALCalCulate();
            advancedPaidTextBox.Focus();
        }
        public void CalculateNetPayable()
        {
            double y, t, m, n, w;

            m = double.Parse(totalFineTextBox.Text);
            n = double.Parse(deductionForALTotalTextBox.Text);

            y = double.Parse(advancedPaidTextBox.Text);
            t = double.Parse(deductionForLeaveTextBox.Text);
            w = double.Parse(adjustmentTextBox.Text);
            z = (y + m + n + t + w);
            s = (y + m + n + w);

            //totalDeductionTextBox.Text = z.ToString();
            DeductionFromSalarytextBox1.Text = z.ToString();
        }
        private void adjustmentTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateNetPayable();
            timer5.Interval = 1500;
            timer5.Start();
        }
        private void NetGrossAfterTaxCalculate()
        {
            double pgs, txt, tax, grsBfrTx;
            pgs = double.Parse(basicSalaryTextBox.Text);
            txt = double.Parse(taxTextBox.Text);
            grsBfrTx = double.Parse(grossSalaryTextBox.Text);
            tax = pgs * txt / 100;
            netgross = (grsBfrTx - tax);
            TotalTax.Text = tax.ToString();
            netGrossSalaryAfterTaxTextBox.Text = netgross.ToString();
        }

        private void taxTextBox_TextChanged(object sender, EventArgs e)
        {
            timer10.Interval = 1500;
            timer10.Start();
            NetGrossAfterTaxCalculate();
        }

        private void previousDueTextBox_TextChanged(object sender, EventArgs e)
        {
            double bonus;
            if (bonusCheckBox1.Checked == true)
            {
                bonus = .5 * Convert.ToDouble(grade.Basic) * Convert.ToDouble(dp) / double.Parse(totalWorkingDayComboBox.Text);
            }
            else
            {
                bonus = 0;
            }
            bonusTextBox.Text = Convert.ToString(bonus);
            TotalAdditionCalculate();
            CalculateNetPayables();
            timer7.Interval = 1500;
            timer7.Start();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //employeeGateway = new EmployeeGateway();
            //decimal employeeId = Convert.ToDecimal(employeeIdTextBox.Text);
            //employee = employeeGateway.SearchEmployee(employeeId);
            //if (employee.EmployeeId != Convert.ToDecimal(employeeIdTextBox.Text))
            //{
            //    MessageBox.Show("Employee Id is not found.Please enter correct Id");

            //}
            //else
            //{
            //    employeeNameTextBox.Text = employee.EmployeeName;
            //    designationTextBox.Text = employee.Designation;
            //    accountNoTextBox.Text = Convert.ToString(employee.AccountNo);


            //}
        }

        private void interimAllowanceTextBox_TextChanged(object sender, EventArgs e)
        {
            grossSalaryTextBox.Text = Convert.ToString(double.Parse(basicSalaryTextBox.Text) + double.Parse(transportAllowanceTextBox.Text) + double.Parse(medicalAllowanceTextBox.Text) + double.Parse(houserentTextBox.Text) + double.Parse(otherAllowanceTextBox.Text) + double.Parse(interimAllowanceTextBox.Text));
            double trw, grsb;
            trw = double.Parse(totalWorkingDayComboBox.Text);
            grsb = double.Parse(grossSalaryTextBox.Text);
            prds = (grsb / trw);
            perdaySalaryTextBox.Text = prds.ToString();
        }
        private void DeductionForLeaveCalCulat()
        {
            double v, b;
            v = double.Parse(unPaidLeaveTextBox.Text);
            b = double.Parse(perdaySalaryTextBox.Text);
            ddlc = (v * b);
            deductionForLeaveTextBox.Text = ddlc.ToString();
        }
        private void deductionForLeaveComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeductionForLeaveCalCulat();
            adjustmentTextBox.Focus();
        }

        private void empIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            employeeGateway = new EmployeeGateway();
            decimal employeeId = Convert.ToDecimal(cmbEmployeeId.Text);
            employee = employeeGateway.SearchEmployee(employeeId);
            if (employee.EmployeeId != Convert.ToDecimal(cmbEmployeeId.Text))
            {
                MessageBox.Show("Employee Id is not found.Please enter correct Id");

            }
            else
            {
                employeeNameTextBox.Text = employee.EmployeeName;
                designationTextBox.Text = employee.Designation;
                accountNoTextBox.Text = Convert.ToString(employee.AccountNo);


            }
        }
        private void Report2()
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
            paramDiscreteValue.Value = newRowID;

            //add the parameter value in the ParameterField object
            paramField.CurrentValues.Add(paramDiscreteValue);

            //add the parameter in the ParameterFields object
            paramFields.Add(paramField);

            //set the parameterfield information in the crystal report



            ReportViewer1 f2 = new ReportViewer1();
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
            SalaryInput cr = new SalaryInput();
            tables = cr.Database.Tables;
            foreach (Table table in tables)
            {
                reportLogonInfo = table.LogOnInfo;
                reportLogonInfo.ConnectionInfo = reportConInfo;
                table.ApplyLogOnInfo(reportLogonInfo);
            }
            f2.crystalReportViewer1.ParameterFieldInfo = paramFields;  //set the parameterfield information in the crystal report
            f2.crystalReportViewer1.ReportSource = cr;
            //ClientRegistrationForm.Visible = false;
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;
        }
        private void PopulateEmployee()
        {
            employeeGateway = new EmployeeGateway();
            decimal employeeId = Convert.ToDecimal(cmbEmployeeId.Text);
            employee = employeeGateway.SearchEmployee(employeeId);
            if (employee.EmployeeId != Convert.ToDecimal(cmbEmployeeId.Text))
            {
                MessageBox.Show("Employee Id is not found.Please enter correct Id");

            }
            else
            {
                employeeNameTextBox.Text = employee.EmployeeName;
                designationTextBox.Text = employee.Designation;
                gradeTextBox.Text = employee.GradeId;
                accnou = Convert.ToString(employee.AccountNo);
                if (accnou == "" || accnou == null)
                {
                    accountNoTextBox.Text = "0";
                }
                else
                {
                    accountNoTextBox.Text = accnou;
                }

            }
        }
        private void cmbEmployeeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateEmployee();
        }

        public void GradeCalCulate()
        {
            GGateway = new GradeGateway();
            decimal gradeId = Convert.ToDecimal(gradeTextBox.Text);
            grade = GGateway.SearchGrade(gradeId);
            if (grade.GradeId != Convert.ToDecimal(gradeTextBox.Text))
            {
                MessageBox.Show("Grade Id is not found.Please enter correct Id");

            }
            else
            {
                double basic = Convert.ToDouble(grade.Basic);
                double transportAllowance = Convert.ToDouble(grade.TransportAllowance);
                double medicalAllowance = Convert.ToDouble(grade.MedicalAllowance);
                double houserent = Convert.ToDouble(grade.HouseRent);
                double otherAllowance = Convert.ToDouble(grade.OtherAllowance);
                //double houserent = Convert.ToDouble(grade.HouseRent) * double.Parse(dayPayableTextBox.Text) / double.Parse(totalWorkingDayComboBox.Text);

                basicSalaryTextBox.Text = Convert.ToString(basic);
                transportAllowanceTextBox.Text = Convert.ToString(transportAllowance);
                medicalAllowanceTextBox.Text = Convert.ToString(medicalAllowance);
                houserentTextBox.Text = Convert.ToString(houserent);
                otherAllowanceTextBox.Text = Convert.ToString(otherAllowance);




            }
        }
        private void dayPayableTextBox_TextChanged(object sender, EventArgs e)
        {
            //if (double.Parse(dayPayableTextBox.Text) <= double.Parse(totalWorkingDayComboBox.Text))
            //{
            //    GradeCalCulate();
            //}
            //else
            //{
            //    MessageBox.Show("Day Payble can not be larger than total working day");
            //    dayPayableTextBox.TextChanged -= dayPayableTextBox_TextChanged;
            //    dayPayableTextBox.Clear();
            //    dayPayableTextBox.TextChanged += dayPayableTextBox_TextChanged;
            //    dayPayableTextBox.Focus();

            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (this.label36.ForeColor == Color.Red)
            {
                this.label36.ForeColor = Color.Black;
            }
            else
            {
                this.label36.ForeColor = Color.Red;
            }
        

        }
        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.label37.ForeColor == Color.Red)
            {
                this.label37.ForeColor = Color.Black;
            }
            else
            {
                this.label37.ForeColor = Color.Red;
            }
        }

        private void leaveWithPayTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            timer4.Stop();
            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer3.Interval = 500;
            timer9.Stop();
            timer4.Stop();
            this.label1.ForeColor = Color.Red;
            timer3.Start();
            groupBox5.Enabled = true;
            groupBox7.Enabled = false;
            fineComboBox.Focus();
        }

        private void leaveWithPayTextBox_TextChanged(object sender, EventArgs e)
        {
            timer4.Interval = 1500;
            timer4.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (this.label38.ForeColor == Color.Red)
            {
                this.label38.ForeColor = Color.Black;
            }
            else
            {
                this.label38.ForeColor = Color.Red;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            timer6.Interval = 500;
            timer3.Stop();
            timer5.Stop();
            this.label38.ForeColor = Color.Red;
            timer6.Start();
            groupBox6.Enabled = true;
            groupBox5.Enabled = false;
            previousDueTextBox.Focus();
        }

        private void adjustmentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            timer5.Stop();
            timer5.Start();
        }

        private void previousDueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            timer7.Stop();
            timer7.Start();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (this.label39.ForeColor == Color.Red)
            {
                this.label39.ForeColor = Color.Black;
            }
            else
            {
                this.label39.ForeColor = Color.Red;
            }

        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            timer8.Interval = 500;
            timer6.Stop();
            timer7.Stop();
            this.label39.ForeColor = Color.Red;
            timer8.Start();
            groupBox4.Enabled = true;
            groupBox6.Enabled = false;
            updateButton.Focus();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (this.label43.ForeColor == Color.Red)
            {
                this.label43.ForeColor = Color.Black;
            }
            else
            {
                this.label43.ForeColor = Color.Red;
            }
        }

        private void fineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            allowFineTextBox.Focus();
        }

        private void totalWorkingDayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer2.Interval = 500;
            GradeCalCulate();
            timer1.Stop();
            this.label36.ForeColor = Color.Red;
            timer2.Start();
            groupBox3.Enabled = true;
            groupBox2.Enabled = false;
            interimAllowanceTextBox.Focus();
        }

        private void interimAllowanceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                taxTextBox.Focus();
                e.Handled = true;
            }

        }

        private void taxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            timer10.Stop();
            timer10.Start();
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            //NetGrossAfterTaxCalculate();
            timer9.Interval = 500;
            timer2.Stop();
            timer10.Stop();
            this.label37.ForeColor = Color.Red;
            timer9.Start();
            groupBox7.Enabled = true;
            groupBox3.Enabled = false;
            unPaidLeaveTextBox.Focus();
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            if (this.label1.ForeColor == Color.Red)
            {
                this.label1.ForeColor = Color.Ivory;
            }
            else
            {
                this.label1.ForeColor = Color.Red;
            }
        }

        private void unPaidLeaveTextBox_TextChanged(object sender, EventArgs e)
        {
            dp = int.Parse(totalWorkingDayComboBox.Text) - int.Parse(unPaidLeaveTextBox.Text);
            DeductionForLeaveCalCulat();
        }

        private void unPaidLeaveTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                leftALFrom14DaysTextBox.Focus();
                e.Handled = true;
            }
        }

        private void leftALFrom14DaysTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pHAttendenceTextBox.Focus();
                e.Handled = true;
            }
        }

        private void pHAttendenceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                leaveWithPayTextBox.Focus();
                e.Handled = true;
            }
        }

        private void advancedPaidTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                adjustmentTextBox.Focus();
                e.Handled = true;
            }
        }

       
        
    }


}
