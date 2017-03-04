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
using Microsoft.Reporting.WinForms;
using SalaryCalculationUI.AllReports;
using SalaryCalculationUI.DAO;
using SalaryCalculationUI.DBGateway;
using SalaryCalculationUI.Gateway;
using SalaryCalculationUI.Manager;
using System.Windows.Controls;

namespace SalaryCalculationUI.UI
{
    public partial class SalaryDetailsEntryForm : Form
    {
        private double tx = 0.0000, netgross = 0.0000, prds = 0.0000, FC = 0.0000, FCd = 0.0000,
            ddlc = 0.0000, z = 0.0000, tlb = 0.0000, netPayable=0.0000, s=0.000;
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
        private string mnth,reff,yrr,twd,accno;
        private int dp;
        public SalaryDetailsEntryForm()
        {
            InitializeComponent();
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
                accno = Convert.ToString(employee.AccountNo);

                if (accno == ""||accno==null)
                {
                    accountNoTextBox.Text = "0";
                }
                else
                {
                    accountNoTextBox.Text = accno;
                }
            }
        }

        public void GradeCalCulate()
        {
            GGateway = new GradeGateway();
            decimal gradeId = Convert.ToDecimal(gradeTextBox.Text);
            grade = GGateway.SearchGrade(gradeId);
            //if (grade.GradeId != Convert.ToDecimal(gradeTextBox.Text))
            //{
            //    MessageBox.Show("Grade Id is not found.Please enter correct Id");

            //}
            //else
            //{
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




            //}
        }

        //private void TaxCalculation()
        //{
        //    double basic;
        //    basic = double.Parse(basicSalaryTextBox.Text);
        //    tx = (basic * 0.1);
        //    taxTextBox.Text = tx.ToString();
        //}
       

        private void NetGrossAfterTaxCalculate()
        {
            double pgs, txt,tax,grsBfrTx;
            pgs = double.Parse(basicSalaryTextBox.Text);
            txt = double.Parse(taxTextBox.Text);
            grsBfrTx = double.Parse(grossSalaryTextBox.Text);
            tax = pgs*txt/100;
            netgross = (grsBfrTx - tax);
            TotalTax.Text = tax.ToString();
            netGrossSalaryAfterTaxTextBox.Text = netgross.ToString();
        }

       // private void PerDaySalaryCalculation()
      //  {
          //  double trw, grsb;
           // trw = double.Parse(totalWorkingDayComboBox.Text);
           // grsb = double.Parse(grossSalaryTextBox.Text);
           // prds = (grsb/trw);
          //  perdaySalaryTextBox.Text = prds.ToString();

        //}
        private void grossSalaryTextBox_TextChanged(object sender, EventArgs e)
        {
            //TaxCalculation();
        }

        //private void taxTextBox_TextChanged(object sender, EventArgs e)
        //{
            
        //    NetGrossAfterTaxCalculate();
        //}

      //  private void totalWorkingDayComboBox_SelectedIndexChanged(object sender, EventArgs e)
      //  {
       //     PerDaySalaryCalculation();
      //  }

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
            
            adjustmentTextBox.Focus();
        }

        public void CalculateNetPayable()
        {
            double  y, t, m, n, w;

            m = double.Parse(totalFineTextBox.Text);
            n = double.Parse(deductionForALTotalTextBox.Text);
           
            y = double.Parse(advancedPaidTextBox.Text);
           t = double.Parse(deductionForLeaveTextBox.Text);
            w = double.Parse(adjustmentTextBox.Text);
            z = (y  + m + n +t+ w);
            s =(y  + m + n + w);

           // totalDeductionTextBox.Text = z.ToString();
            DeductionFromSalarytextBox1.Text = z.ToString();
        }
        private void adjustmentTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateNetPayable();
            timer5.Interval = 1500;
            timer5.Start();
        }
        private void TotalAdditionCalculate()
        {
            double b, c ;
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
        private void previousDueTextBox_TextChanged(object sender, EventArgs e)
        {
            double bonus;
            if (bonusCheckBox1.Checked == true)
            {
                bonus =.5* Convert.ToDouble(grade.Basic) * Convert.ToDouble(dp) / double.Parse(twd);
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            

            try
            {
                 con = new SqlConnection(cs.DBConn);
            con.Open();
            String cb = String.Format("insert into Salary (EmployeeId,EmployeeName,Designation,AccountNo,Months,Year,ReferenceNo,GradeId,Basic,TransportAllowance,MedicalAllowance,HouseRent,OtherAllowance,InterimAllowance,GrossSalary,Tax,NetGrossSalaryAfterTax,TotalWorkingDay,PerdaySalary,DayPayable,UnpaidLeave,GivenAnnualLeave,PHAttendence,LeaveWithPay,Fine,DeductionFromAnnualLeave,AdvancePaid,DeductionForLeave,Adjustment,TotalDeduction,Bonus,PreviousDues,TotalAddition,NetPayable)VALUES (@EmployeeId,@EmployeeName,@Designation,@AccountNo,@Month,@Year,@ReferenceNo,@GradeId,@Basic,@TransportAllowance,@MedicalAllowance,@HouseRent,@OtherAllowance,@InterimAllowance,@GrossSalary,@Tax,@NetGrossSalaryAfterTax,@TotalWorkingDay,@PerdaySalary,@DayPayable,@UnpaidLeave,@GivenAnnualLeave,@PHAttendence,@LeaveWithPay,@Fine,@DeductionFromAnnualLeave,@AdvancePaid,@DeductionForLeave,@Adjustment,@TotalDeduction,@Bonus,@PreviousDues,@TotalAddition,@NetPayable)" + "SELECT CONVERT(int, SCOPE_IDENTITY());");
            //string  = String.Format("insert into Transactions(BankName,AccountNo,TransactionType,ChequeFromBank,EFTAccountNo,Particulars,CheckNo,Credit,CurrentBalance,TransactionDates) VALUES (@bankName,@accountNo,@transactionType,@chequeFromBank,@eftAccountNo,@particulars,@chequeNo,@credit,@currentBalance,@d1)" + "SELECT CONVERT(int, SCOPE_IDENTITY());");
            cmd = new SqlCommand(cb);
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@EmployeeId",Convert.ToInt64(cmbEmployeeId.Text));
            cmd.Parameters.AddWithValue("@EmployeeName", employeeNameTextBox.Text);
            cmd.Parameters.AddWithValue("@Designation", designationTextBox.Text);

            cmd.Parameters.AddWithValue("@AccountNo", accountNoTextBox.Text);
            cmd.Parameters.AddWithValue("@Month", mnth);
            cmd.Parameters.AddWithValue("@Year", yrr);
            cmd.Parameters.AddWithValue("@ReferenceNo", reff);
            cmd.Parameters.AddWithValue("@GradeId",Convert.ToInt64(gradeTextBox.Text));
            cmd.Parameters.AddWithValue("@Basic",Convert.ToDecimal(basicSalaryTextBox.Text));
            cmd.Parameters.AddWithValue("@TransportAllowance", Convert.ToDecimal(transportAllowanceTextBox.Text));
            cmd.Parameters.AddWithValue("@MedicalAllowance",Convert.ToDecimal(medicalAllowanceTextBox.Text));
            cmd.Parameters.AddWithValue("@HouseRent",Convert.ToDecimal(houserentTextBox.Text));
            cmd.Parameters.AddWithValue("@OtherAllowance", Convert.ToDecimal(otherAllowanceTextBox.Text));
            cmd.Parameters.AddWithValue("@InterimAllowance",  Convert.ToDecimal(interimAllowanceTextBox.Text));
            cmd.Parameters.AddWithValue("@GrossSalary", Convert.ToDecimal(grossSalaryTextBox.Text));
            cmd.Parameters.AddWithValue("@Tax",Convert.ToDecimal(TotalTax.Text));
            cmd.Parameters.AddWithValue("@NetGrossSalaryAfterTax", Convert.ToDecimal(netGrossSalaryAfterTaxTextBox.Text));
            cmd.Parameters.AddWithValue("@TotalWorkingDay", Convert.ToDecimal(twd));
            cmd.Parameters.AddWithValue("@PerdaySalary", Convert.ToDecimal(perdaySalaryTextBox.Text));
            cmd.Parameters.AddWithValue("@DayPayable",Convert.ToDecimal(dp));
            cmd.Parameters.AddWithValue("@UnpaidLeave", Convert.ToDecimal(unPaidLeaveTextBox.Text));
            cmd.Parameters.AddWithValue("@GivenAnnualLeave", Convert.ToDecimal(leftALFrom14DaysTextBox.Text));
            cmd.Parameters.AddWithValue("@PHAttendence", Convert.ToDecimal(pHAttendenceTextBox.Text));
            cmd.Parameters.AddWithValue("@LeaveWithPay", Convert.ToDecimal(leaveWithPayTextBox.Text));
            cmd.Parameters.AddWithValue("@Fine", Convert.ToDecimal(totalFineTextBox.Text));
            cmd.Parameters.AddWithValue("@DeductionFromAnnualLeave", Convert.ToDecimal(deductionForALTotalTextBox.Text));
            cmd.Parameters.AddWithValue("@AdvancePaid", Convert.ToDecimal(advancedPaidTextBox.Text));
            cmd.Parameters.AddWithValue("@DeductionForLeave", Convert.ToDecimal(deductionForLeaveTextBox.Text));
            cmd.Parameters.AddWithValue("@Adjustment", Convert.ToDecimal(adjustmentTextBox.Text));
            cmd.Parameters.AddWithValue("@TotalDeduction",Convert.ToDecimal(DeductionFromSalarytextBox1.Text));
            cmd.Parameters.AddWithValue("@Bonus", Convert.ToDecimal(bonusTextBox.Text));
            cmd.Parameters.AddWithValue("@PreviousDues", Convert.ToDecimal(previousDueTextBox.Text));
            cmd.Parameters.AddWithValue("@TotalAddition", Convert.ToDecimal(totalAdditionTextBox.Text));
            cmd.Parameters.AddWithValue("@NetPayable", Convert.ToDecimal(netPayableTextBox.Text));
            //cmd.ExecuteReader();
            newRowID = (int)cmd.ExecuteScalar();

            con.Close();
            MessageBox.Show("Successfully Deposited,Please Print the Report. Your Current Transaction Id is:" + newRowID, "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            saveButton.Enabled = false;
                Report2();
                timer8.Stop();
                groupBox4.Enabled = false;
               
                saveButton.Enabled = true;
                Clear();
                EmpIdPopulateCom();
                 DialogResult dialogResult =
                MessageBox.Show(
                    "Do you want to give more Salary ", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    timer1.Interval = 500;
                    timer1.Start();

                    return;
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
                
           
            
        }

        private void totalDeductionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        //private void Reset()
        //{
        //    employeeIdTextBox.Text = "";
        //    employeeNameTextBox.Text = "";
        //    designationTextBox.Text = "";
        //    accountNoTextBox.Text = "";
        //    monthComboBox.Text = "";
        //    gradeComboBox.Text = "";
        //    basicSalaryTextBox.Text = "";
        //    transportAllowanceTextBox.Text = "";
        //    medicalAllowanceTextBox.Text = "";
        //    houserentTextBox.Text = "";
        //    otherAllowanceTextBox.Text = "";
        //    dayPayableTextBox.Text = "";
        //    unPaidLeaveTextBox.Text = "";
        //    leftALFrom14DaysTextBox.Text = "";
        //    pHAttendenceTextBox.Text = "";
        //    leaveWithPayTextBox.Text = "";
        //}
        private void NewForm()
        {
            
            SalaryDetailsEntryForm asForm = new SalaryDetailsEntryForm();
            this.Visible = false;
            asForm.ShowDialog();
            this.Visible = true;
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            NewForm();
            //this.Hide();
            //SalaryDetailsEntryForm asForm=new SalaryDetailsEntryForm();
            //asForm.Show();

            //Reset();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainUI   aMainUi=new MainUI();
            aMainUi.Show();
        }

        internal void SetDataSource(Salary dsCustomers)
        {
            throw new NotImplementedException();
        }

        private void getDataButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalaryDetailsGrid2 aGrid = new SalaryDetailsGrid2();
            aGrid.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void basicSalaryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void transportAllowanceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void medicalAllowanceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void houserentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void otherAllowanceTextBox_TextChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
          
            this.Visible = false;
            dynamic f2 = new SalaryDelete();
            f2.ShowDialog();
            this.Visible = true;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dynamic f2 = new SalaryUpdateForm();
            f2.ShowDialog();
            this.Visible = true;
            

        }

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

        private void SalaryDetailsEntryForm_Load(object sender, EventArgs e)
        {
            mnth = SalaryIn.c;
            reff = SalaryIn.a;
            yrr = SalaryIn.b;
            twd = SalaryIn.d;

            timer1.Interval = 500;
            timer1.Start();
            EmpIdPopulateCom();
            cmbEmployeeId.Focus();
        }

        private void employeeIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbEmployeeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateEmployee();
            GradeCalCulate();
            timer2.Interval = 500;
            timer1.Stop();
            this.label36.ForeColor = Color.Red;
            timer2.Start();
            groupBox3.Enabled = true;
            groupBox2.Enabled = false;
            interimAllowanceTextBox.Focus();
        }

        //private void dayPayableTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    if (double.Parse(dayPayableTextBox.Text) <= double.Parse(totalWorkingDayComboBox.Text))
        //    { GradeCalCulate();}
        //    else
        //    {
        //        MessageBox.Show("Day Payble can not be larger than total working day");
        //        dayPayableTextBox.TextChanged -= dayPayableTextBox_TextChanged;
        //        dayPayableTextBox.Clear();
        //        dayPayableTextBox.TextChanged += dayPayableTextBox_TextChanged;
        //        dayPayableTextBox.Focus();

        //    }
        //}

        private void label28_Click(object sender, EventArgs e)
        {

        }
        private void Clear()
        {

            //referenceNoTextBox.Clear();
            //yearComboBox.SelectedIndexChanged -= yearComboBox_SelectedIndexChanged;
            //yearComboBox.SelectedIndex = -1;
            //yearComboBox.SelectedIndexChanged += yearComboBox_SelectedIndexChanged;

            //monthComboBox.SelectedIndex = -1;
            accountNoTextBox.Clear();
            designationTextBox.Clear();
            employeeNameTextBox.Clear();
            
            interimAllowanceTextBox.TextChanged -= interimAllowanceTextBox_TextChanged;
            interimAllowanceTextBox.Clear();
            interimAllowanceTextBox.TextChanged += interimAllowanceTextBox_TextChanged;
            TotalTax.Clear();

            perdaySalaryTextBox.Clear();
            pHAttendenceTextBox.Clear();

            leftALFrom14DaysTextBox.Clear();
            unPaidLeaveTextBox.TextChanged -= unPaidLeaveTextBox_TextChanged;
            unPaidLeaveTextBox.Clear();
            unPaidLeaveTextBox.TextChanged += unPaidLeaveTextBox_TextChanged;
            leaveWithPayTextBox.TextChanged-=leaveWithPayTextBox_TextChanged;
            leaveWithPayTextBox.KeyPress -= leaveWithPayTextBox_KeyPress;
            leaveWithPayTextBox.Clear();
            leaveWithPayTextBox.TextChanged += leaveWithPayTextBox_TextChanged;
            leaveWithPayTextBox.KeyPress += leaveWithPayTextBox_KeyPress;
            otherAllowanceTextBox.Clear();

            netGrossSalaryAfterTaxTextBox.Clear();

            grossSalaryTextBox.Clear();

            houserentTextBox.Clear();

            //totalWorkingDayComboBox.SelectedIndex = -1;
            medicalAllowanceTextBox.Clear();

            transportAllowanceTextBox.Clear();

            basicSalaryTextBox.Clear();
            taxTextBox.TextChanged-=taxTextBox_TextChanged_1;
            taxTextBox.KeyPress -= taxTextBox_KeyPress;
            taxTextBox.Clear();
            taxTextBox.TextChanged += taxTextBox_TextChanged_1;
            taxTextBox.KeyPress += taxTextBox_KeyPress;
            //dayPayableTextBox.TextChanged -= dayPayableTextBox_TextChanged;
            //dayPayableTextBox.Clear();
            //dayPayableTextBox.TextChanged += dayPayableTextBox_TextChanged;
            DeductionFromSalarytextBox1.Clear();
            //deductionForLeaveComboBox.SelectedIndexChanged -= deductionForLeaveComboBox_SelectedIndexChanged;
            //deductionForLeaveComboBox.Items.Remove(deductionForLeaveComboBox.SelectedItem);
            //deductionForLeaveComboBox.Items.Clear();
            
            //for (int i = 0; i <= 31; i++)
            //        {
            //            string[] numbers = { i.ToString() };
            //            deductionForLeaveComboBox.Items.AddRange(numbers);
            //        }
            //deductionForLeaveComboBox.SelectedIndexChanged += deductionForLeaveComboBox_SelectedIndexChanged;
            deductionForALComboBox.SelectedIndexChanged -= deductionForALComboBox_SelectedIndexChanged;
            deductionForALComboBox.SelectedIndex = -1;
            deductionForALComboBox.SelectedIndexChanged += deductionForALComboBox_SelectedIndexChanged;
            deductionForLeaveTextBox.Clear();
            deductionForALTotalTextBox.Clear();
            
            totalFineTextBox.Clear();
            fineComboBox.SelectedIndex = -1;
            allowFineTextBox.TextChanged -= allowFineTextBox_TextChanged;
            allowFineTextBox.Clear();
            allowFineTextBox.TextChanged += allowFineTextBox_TextChanged;
            adjustmentTextBox.TextChanged-=adjustmentTextBox_TextChanged;
            adjustmentTextBox.KeyPress -= adjustmentTextBox_KeyPress;
            adjustmentTextBox.Clear();
            adjustmentTextBox.TextChanged += adjustmentTextBox_TextChanged;
            adjustmentTextBox.KeyPress += adjustmentTextBox_KeyPress;

            //totalDeductionTextBox.Clear();
            
            advancedPaidTextBox.Clear();
            
            netPayableTextBox.Clear();

            totalAdditionTextBox.Clear();
            previousDueTextBox.TextChanged -= previousDueTextBox_TextChanged;
            previousDueTextBox.KeyPress -= previousDueTextBox_KeyPress;
            previousDueTextBox.Clear();
            previousDueTextBox.TextChanged += previousDueTextBox_TextChanged;
            previousDueTextBox.KeyPress += previousDueTextBox_KeyPress;
            bonusTextBox.Clear();


            cmbEmployeeId.SelectedIndexChanged -= cmbEmployeeId_SelectedIndexChanged;
            cmbEmployeeId.Items.Clear();
            cmbEmployeeId.SelectedIndex = -1;
            cmbEmployeeId.SelectedIndexChanged += cmbEmployeeId_SelectedIndexChanged;
            gradeTextBox.Clear();
            groupBox2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.label36.ForeColor == Color.Red)
            {
                this.label36.ForeColor = Color.Ivory;
            }
            else
            {
                this.label36.ForeColor = Color.Red;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.label37.ForeColor == Color.Red)
            {
                this.label37.ForeColor = Color.Ivory;
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
                this.label38.ForeColor = Color.Ivory;
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
                this.label39.ForeColor = Color.Ivory;
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
            saveButton.Focus();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (this.label43.ForeColor == Color.Red)
            {
                this.label43.ForeColor = Color.Ivory;
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

        private void interimAllowanceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                taxTextBox.Focus();
                e.Handled = true;
            }

        }

        private void taxTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
                
            //    fineComboBox.Focus();
            //    e.Handled = true;
            //}
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

        private void allowFineTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                deductionForALComboBox.Focus();
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

        private void unPaidLeaveTextBox_TextChanged(object sender, EventArgs e)
        {
            dp = int.Parse(twd) - int.Parse(unPaidLeaveTextBox.Text);
            DeductionForLeaveCalCulat();
        }

        private void interimAllowanceTextBox_TextChanged(object sender, EventArgs e)
        {
            grossSalaryTextBox.Text = Convert.ToString(double.Parse(basicSalaryTextBox.Text) + double.Parse(transportAllowanceTextBox.Text) + double.Parse(medicalAllowanceTextBox.Text) + double.Parse(houserentTextBox.Text) + double.Parse(otherAllowanceTextBox.Text) + double.Parse(interimAllowanceTextBox.Text));
            double trw, grsb;
            trw = double.Parse(twd);
            grsb = double.Parse(grossSalaryTextBox.Text);
            prds = (grsb / trw);
            perdaySalaryTextBox.Text = prds.ToString();
        }

        private void taxTextBox_TextChanged_1(object sender, EventArgs e)
        {
            timer10.Interval = 1500;
            timer10.Start();
            NetGrossAfterTaxCalculate();
            
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

        private void accountNoTextBox_Validated(object sender, EventArgs e)
        {
           
        }

        private void accountNoTextBox_Validating(object sender, CancelEventArgs e)
        {
           
        }

        //private void timer1_Tick_1(object sender, EventArgs e)
        //{

        //}

        //private void advancedPaidTextBox_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
