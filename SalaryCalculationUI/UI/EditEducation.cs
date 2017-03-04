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
    public partial class EditEducation : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        ConnectionString cs = new ConnectionString();
        private SqlDataReader rdr;
        public EmployeeGateway aEmployeeGateway;
        public Employee employee;
        private string s, h, hn, m;

        public EditEducation()
        {
            InitializeComponent();
        }

        public void FillCombo()
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

        private void EditEducation_Load(object sender, EventArgs e)
        {
            FillCombo();
        }

        private void cmbEmployeeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            aEmployeeGateway = new EmployeeGateway();
            decimal employeeId = Convert.ToDecimal(cmbEmployeeId.Text);
            employee = aEmployeeGateway.EditEmployeeByEmployeeId(employeeId);

            employeeNameTextBox.Text = employee.EmployeeName;


            educationHistry1TextBox.Text = employee.EducationH1;
            educationHistry2TextBox.Text = employee.EducationH2;
            educationHistory3TextBox.Text = employee.EducationH3;
            educationHistory4TextBox.Text = employee.EducationH4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                s = "Exam Name: " + sscExamName.Text + " Board: " + sscBoardName.Text + " Subject: " +
                sscSubject.Text + " Result: " + sscResult.Text + " Passing Year: " +
                sscYear.Text;
            }
            else
            {
                s = null;
            }
            if (checkBox9.Checked == true)
            {
                h = "Exam Name: " + hscExamName.Text + " Board: " + hscBoardName.Text + " Subject: " +
                    hscSubject.Text + " Result: " + hscResult.Text + " Passing Year: " +
                    hscYear.Text;
            }
            else
            {
                h = null;
            }
            if (checkBox6.Checked == true)
            {
                hn = "Exam Name: " + honsExamName.Text + " Institute: " + honsInstituteName.Text +
                     " Subject: " +
                     honsSubject.Text + " Result: " + honsResult.Text + " Passing Year: " +
                     honsYear.Text;
            }
            else
            {
                hn = null;
            }
            if (checkBox7.Checked == true)
            {
                m = "Exam Name: " + msExamName.Text + " Institute: " + msInstituteName.Text +
                    " Subject: " +
                    msSubject.Text + " Result: " + msResult.Text + " Passing Year: " +
                    msYear.Text;
            }
            else
            {
                m = null;
            }
            try
            {


                con = new SqlConnection(cs.DBConn);
                con.Open();
                //string cb = "Update Employee Set EmployeeName='" + employeeNameTextBox.Text + "',NickName='" + nickNameTextBox.Text + "',Gender='" + cmbGender.Text + "',CorporateMail='" + corportEmailTextBox.Text + "',EmailId='" + personalEmailTextBox.Text + "',DateOfBirth='" + barthDate + "',NationalId='" + nationalIdNumberTextBox.Text + "',AreaOrCountryCode1='" + cmbAreaCode1.Text + "',Contact1='" + contact1TextBox.Text + "',AreaOrCountryCode2='" + cmbAreaCode2.Text + "',Contact2='" + contact2NoTextBox.Text + "',Designation='" + designationTextBox.Text + "',AccountNumber='" + accountNoTextBox.Text + "',GradeId='" + cmbGrade.Text + "',EducationL1='" + educationHistry1TextBox.Text + "',EducationL2='" + educationHistry2TextBox.Text + "',EducationL3='" + educationHistory3TextBox.Text + "',EducationL4='" + educationHistory4TextBox.Text + "',JobLocation='" + cmbJobLocation.Text + "',PresentAddress='" + presentAddressTextBox.Text + "',PresentDistrict='" + presentDistrictComboBox.Text + "',PermanantAddress='" + permanantAddressTextBox.Text + "',PermanantDistrict='" + permanantDistrictComboBox.Text + "',LocalGardianName='" + localGardianNameTextBox.Text + "',ReferenceDetail='" + reference1TextBox.Text + "',ReferenceD2='" + reference2TextBox.Text + "',WorkHistry='" + workHistory1TextBox.Text + "',WorkHistry2='" + workHistory2TextBox.Text + "',WorkHistry3='" + workHistory3TextBox.Text + "',WorkHistry4='" + workHistory4TextBox.Text + "',JoiningDate='" + joinDate + "',ConformationDate='" + ConformDate + "',DehiringDates='" + dehireDate + "',LastAppraisalDates='" + lastAppDate + "',LastApprisalRating='" + lastAppraisalRatingTextBox.Text + "',FatherName='" + fatherNameTextBox.Text + "',MotherName='" + motherNameTextBox.Text + "',MaritalStatus='" + cmbMaritalStatus.Text + "',SpouseName='" + spouseNameTextBox.Text + "',EndofTraineePeriods='" + trainydate + "',EndOfProbationPeriodDate='" + probationdate + "',Department='" + departmentTextBox.Text + "',PassportNo='" + passportNOTextBox.Text + "' Where EmployeeId='" + cmbEmployeeId.Text + "' ";
                string cb =
                    "Update Employee Set EducationL1=@edu1,EducationL2=@edu2,EducationL3=@edu3,EducationL4=@edu4 Where EmployeeId='" +
                    cmbEmployeeId.Text + "' ";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;


                //cmd.Parameters.AddWithValue("@edu1", educationHistry1TextBox.Text);
                //cmd.Parameters.AddWithValue("@edu2", educationHistry2TextBox.Text);
                //cmd.Parameters.AddWithValue("@edu3", educationHistory3TextBox.Text);
                //cmd.Parameters.AddWithValue("@edu4", educationHistory4TextBox.Text);
                cmd.Parameters.AddWithValue("@edu1", (object)s ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@edu2", (object)h ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@edu3", (object)hn ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@edu4", (object)m ?? DBNull.Value);


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

        public void Reset()
        {
            employeeNameTextBox.Text = "";
            educationHistry1TextBox.Text = "";
            educationHistry2TextBox.Text = "";
            educationHistory3TextBox.Text = "";
            educationHistory4TextBox.Text = "";
            sscExamName.Text = "";
            sscBoardName.Text = "";
            sscResult.Text = "";
            sscSubject.Text = "";
            sscYear.Text = "";
            hscExamName.Text = "";
            hscBoardName.Text = "";
            hscResult.Text = "";
            hscSubject.Text = "";
            hscYear.Text = "";
            honsExamName.Text = "";
            honsInstituteName.Text = "";
            honsResult.Text = "";
            honsSubject.Text = "";
            honsYear.Text = "";
            msExamName.Text = "";
            msInstituteName.Text = "";
            msResult.Text = "";
            msSubject.Text = "";
            msYear.Text = "";
            cmbEmployeeId.SelectedIndexChanged -= cmbEmployeeId_SelectedIndexChanged;
            cmbEmployeeId.Items.Clear();
            cmbEmployeeId.SelectedIndexChanged += cmbEmployeeId_SelectedIndexChanged;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;

        }

        private void sscYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            // Check if the pressed character was a backspace or numeric.
            if (e.KeyChar != (char) 8 && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void hscYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            // Check if the pressed character was a backspace or numeric.
            if (e.KeyChar != (char) 8 && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void honsYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            // Check if the pressed character was a backspace or numeric.
            if (e.KeyChar != (char) 8 && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void msYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            // Check if the pressed character was a backspace or numeric.
            if (e.KeyChar != (char) 8 && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }






    }
}