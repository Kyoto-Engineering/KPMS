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

namespace SalaryCalculationUI.UI
{
    public partial class GradeChange : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        ConnectionString cs = new ConnectionString();
        private SqlDataReader rdr;
        public EmployeeGateway aEmployeeGateway;
        public Employee employee;
        public GradeChange()
        {
            InitializeComponent();
        }

        private void cmbEmployeeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            aEmployeeGateway = new EmployeeGateway();
            decimal employeeId = Convert.ToDecimal(cmbEmployeeId.Text);
            employee = aEmployeeGateway.EditEmployeeByEmployeeId(employeeId);

            employeeNameTextBox.Text = employee.EmployeeName;
            cmbGrade.Text = employee.GradeId;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {


                con = new SqlConnection(cs.DBConn);
                con.Open();
                //string cb = "Update Employee Set EmployeeName='" + employeeNameTextBox.Text + "',NickName='" + nickNameTextBox.Text + "',Gender='" + cmbGender.Text + "',CorporateMail='" + corportEmailTextBox.Text + "',EmailId='" + personalEmailTextBox.Text + "',DateOfBirth='" + barthDate + "',NationalId='" + nationalIdNumberTextBox.Text + "',AreaOrCountryCode1='" + cmbAreaCode1.Text + "',Contact1='" + contact1TextBox.Text + "',AreaOrCountryCode2='" + cmbAreaCode2.Text + "',Contact2='" + contact2NoTextBox.Text + "',Designation='" + designationTextBox.Text + "',AccountNumber='" + accountNoTextBox.Text + "',GradeId='" + cmbGrade.Text + "',EducationL1='" + educationHistry1TextBox.Text + "',EducationL2='" + educationHistry2TextBox.Text + "',EducationL3='" + educationHistory3TextBox.Text + "',EducationL4='" + educationHistory4TextBox.Text + "',JobLocation='" + cmbJobLocation.Text + "',PresentAddress='" + presentAddressTextBox.Text + "',PresentDistrict='" + presentDistrictComboBox.Text + "',PermanantAddress='" + permanantAddressTextBox.Text + "',PermanantDistrict='" + permanantDistrictComboBox.Text + "',LocalGardianName='" + localGardianNameTextBox.Text + "',ReferenceDetail='" + reference1TextBox.Text + "',ReferenceD2='" + reference2TextBox.Text + "',WorkHistry='" + workHistory1TextBox.Text + "',WorkHistry2='" + workHistory2TextBox.Text + "',WorkHistry3='" + workHistory3TextBox.Text + "',WorkHistry4='" + workHistory4TextBox.Text + "',JoiningDate='" + joinDate + "',ConformationDate='" + ConformDate + "',DehiringDates='" + dehireDate + "',LastAppraisalDates='" + lastAppDate + "',LastApprisalRating='" + lastAppraisalRatingTextBox.Text + "',FatherName='" + fatherNameTextBox.Text + "',MotherName='" + motherNameTextBox.Text + "',MaritalStatus='" + cmbMaritalStatus.Text + "',SpouseName='" + spouseNameTextBox.Text + "',EndofTraineePeriods='" + trainydate + "',EndOfProbationPeriodDate='" + probationdate + "',Department='" + departmentTextBox.Text + "',PassportNo='" + passportNOTextBox.Text + "' Where EmployeeId='" + cmbEmployeeId.Text + "' ";
                string cb =
                    "Update Employee Set GradeId=@gradeId Where EmployeeId='" +
                    cmbEmployeeId.Text + "' ";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;


                cmd.Parameters.AddWithValue("@gradeId", cmbGrade.Text);
              
               

                cmd.ExecuteReader();
                con.Close();

                // newRowID1 = Convert.ToInt32(cmbEmployeeId.Text);
                MessageBox.Show("Successfully Updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                FillCombo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void Reset()
       {
           cmbEmployeeId.SelectedIndexChanged -= cmbEmployeeId_SelectedIndexChanged;
           cmbEmployeeId.SelectedIndex = -1;
           cmbGrade.SelectedIndex = -1;
           employeeNameTextBox.Clear();
           cmbEmployeeId.SelectedIndexChanged += cmbEmployeeId_SelectedIndexChanged;
       }

        private void FillCombo()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select RTRIM(EmployeeId) from Employee order by EmployeeId";
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

        private void GradeChange_Load(object sender, EventArgs e)
        {
            FillCombo();
        }
    }
}
