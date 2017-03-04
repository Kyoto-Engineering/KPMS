using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.CSharp.CSharpCodeProvider;
//using  CrystalDecisions.Shared.ExcelFormatOptions;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using SalaryCalculationUI.DBGateway;

namespace SalaryCalculationUI.UI
{
    public partial class SalaryDetailsGrid : Form
    {
        ConnectionString cs = new ConnectionString();
        SqlDataReader rdr = null;

        SqlConnection con = null;
        SqlCommand cmd = null;
        public SalaryDetailsGrid()
        {
            InitializeComponent();
        }
        private SqlConnection Connection
        {
            get
            {
                SqlConnection ConnectionToFetch = new SqlConnection(cs.DBConn);
                ConnectionToFetch.Open();
                return ConnectionToFetch;
            }
        }
        private void SalaryDetailsGrid_Load(object sender, EventArgs e)
        {
            con=new SqlConnection(cs.DBConn);
            con.Open();
            string selectQuery = "Select * from Salary";
            //string selectQuery = "Select  Months, Year,EmployeeId, EmployeeName,Designation,TotalworkingDay,DayPayable,LeaveWithPay,UnpaidLeave,Basic, TransportAllowance,MedicalAllowance,HouseRent,OtherAllowance,GrossSalary,Tax,DeductionForLeave,Fine,DeductionFromAnnualLeave,Adjustment,AdvancePaid,TotalDeduction,PreviousDues,TotalAddition,NetPayable from Salary";
            SqlDataAdapter myadapter = new SqlDataAdapter(selectQuery,con);
            DataTable dt=new DataTable();
            myadapter.Fill(dt);
            dataGridView11.DataSource = dt;
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainUI  asMainUi=new MainUI();
            asMainUi.Show();
        }

        private void SalaryDetailsGrid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
               // cmd = new SqlCommand("SELECT RTRIM(CustomerID)as [Customer ID],RTRIM(Customername) as [Customer Name],RTRIM(address) as [Address],RTRIM(city) as [City],RTRIM(ContactNo) as [Contact No.],RTRIM(ContactNo1) as [Contact No. 1],(email) as [Email],(notes) as [Notes] from Customer where CustomerName like '" + txtCustomers.Text + "%' order by CustomerName", con);
                SqlDataAdapter myDA = new SqlDataAdapter(cmd);
                DataSet myDataSet = new DataSet();
                myDA.Fill(myDataSet, "Customer");
                dataGridView11.DataSource = myDataSet.Tables["Customer"].DefaultView;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exportToExcelButton_Click(object sender, EventArgs e)
        {
            //int rowsTotal = 0;
            //int colsTotal = 0;
            //int I = 0;
            //int j = 0;
            //int iC = 0;
            //System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            //Excel.Application xlApp = new Excel.Application();
            

            //try
            //{
            //    Excel.Workbook excelBook = xlApp.Workbooks.Add();
            //    Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelBook.Worksheets[1];
            //    xlApp.Visible = true;

            //    rowsTotal = dataGridView1.RowCount - 1;
            //    colsTotal = dataGridView1.Columns.Count - 1;
            //    var _with1 = excelWorksheet;
            //    _with1.Cells.Select();
            //    _with1.Cells.Delete();
            //    for (iC = 0; iC <= colsTotal; iC++)
            //    {
            //        _with1.Cells[1, iC + 1].Value = dataGridView1.Columns[iC].HeaderText;
            //    }
            //    for (I = 0; I <= rowsTotal - 1; I++)
            //    {
            //        for (j = 0; j <= colsTotal; j++)
            //        {
            //            _with1.Cells[I + 2, j + 1].value = dataGridView1.Rows[I].Cells[j].Value;
            //        }
            //    }
            //    _with1.Rows["1:1"].Font.FontStyle = "Bold";
            //    _with1.Rows["1:1"].Font.Size = 12;

            //    _with1.Cells.Columns.AutoFit();
            //    _with1.Cells.Select();
            //    _with1.Cells.EntireColumn.AutoFit();
            //    _with1.Cells[1, 1].Select();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    //RELEASE ALLOACTED RESOURCES
            //    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            //    xlApp = null;
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
              cmd=new SqlCommand("Select * from Salary order by EmployeeId",con);
                // cmd = new SqlCommand("SELECT RTRIM(Months) as Month,RTRIM(Year) as Year,RTRIM(EmployeeId) as EmployeeId,RTRIM(EmployeeName) as EmployeeName,RTRIM(Designation) as Designation,RTRIM(TotalworkingDay) as TotalworkingDay,RTRIM(DayPayable) as DayPayable,RTRIM(LeaveWithPay)as LeaveWithPay,RTRIM(UnpaidLeave) as UnPaidLeave,RTRIM(Basic) as Basics,RTRIM(TransportAllowance) as TransportAllowance,RTRIM(MedicalAllowance) as MedicalAllowance,RTRIM(HouseRent) as Houserent,RTRIM(OtherAllowance) as OtherAllowance,RTRIM(GrossSalary) as GrossSalary,RTRIM(Tax) asTax,RTRIM(DeductionForLeave) as DeductionForLeave,RTRIM(Fine) as Fine,RTRIM(DeductionFromAnnualLeave) as DeductionForAlLeave,RTRIM(Adjustment) as Adjustment,RTRIM(AdvancePaid) as AdvancePaid,RTRIM(TotalDeduction) asTotalDeduction,RTRIM(PreviousDues) as PreviousDues,RTRIM(TotalAddition) as TotalAddition,RTRIM(NetPayable) as NetPayable from Salary where EmployeeId='" + textBox1.Text + "'order by EmployeeName", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView11.Rows.Clear();
                while (rdr.Read() == true)
                {
                   // dataGridView1.Rows.Add(rdr[5], rdr[6], rdr[1], rdr[2], rdr[3], rdr[17], rdr[19], rdr[23], rdr[20], rdr[9], rdr[10], rdr[11], rdr[12], rdr[13], rdr[14], rdr[15], rdr[16], rdr[28], rdr[25], rdr[26], rdr[28], rdr[30], rdr[31], rdr[32]);
                    dataGridView11.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11], rdr[12], rdr[13], rdr[14], rdr[15], rdr[16], rdr[17], rdr[18], rdr[19], rdr[20], rdr[21], rdr[22], rdr[23], rdr[24], rdr[25], rdr[26], rdr[27], rdr[28], rdr[29], rdr[30], rdr[31], rdr[32]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
