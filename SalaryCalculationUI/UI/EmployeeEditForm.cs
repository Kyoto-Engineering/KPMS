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
    public partial class EmployeeEditForm : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        ConnectionString cs=new ConnectionString();
        private SqlDataReader rdr;
       public EmployeeGateway aEmployeeGateway;
        public Employee employee;
        public int newRowID1;
        private Nullable<DateTime> d1, d2,d3,d4,d5; 

        public EmployeeEditForm()
        {
            InitializeComponent();
        }

        public void Reset()
        {
          cmbEmployeeId.SelectedIndexChanged -= cmbEmployeeId_SelectedIndexChanged;
            cmbEmployeeId.SelectedIndex = -1;
            cmbEmployeeId.SelectedIndexChanged += cmbEmployeeId_SelectedIndexChanged;
            employeeNameTextBox.Text = "";
            nickNameTextBox.Text = "";
            fatherNameTextBox.Text = "";
            motherNameTextBox.Text = "";
            cmbMaritalStatus.SelectedIndex = -1;
            spouseNameTextBox.Text = "";
            cmbGender.SelectedIndex = -1;
            corportEmailTextBox.Text = "";
            personalEmailTextBox.Text = "";
            nationalIdNumberTextBox.Text = "";
            passportNOTextBox.Text = "";

            cmbAreaCode1.SelectedIndex = -1;
            cmbAreaCode2.SelectedIndex = -1;
            contact1TextBox.Text = "";
            contact2NoTextBox.Text = "";
            departmentTextBox.Text = "";
            designationTextBox.Text = "";
            cmbGrade.Text = "";
            educationHistry1TextBox.Text = "";
            educationHistry2TextBox.Text = "";
            educationHistory3TextBox.Text = "";
            educationHistory4TextBox.Text = "";

            cmbJobLocation.SelectedIndex = -1;
            presentAddressTextBox.Text = "";
            presentDistrictComboBox.SelectedIndex = -1;
            permanantAddressTextBox.Text = "";
            permanantDistrictComboBox.SelectedIndex = -1;
            localGardianNameTextBox.Text = "";
            reference1TextBox.Text = "";
            reference2TextBox.Text = "";
            workHistory1TextBox.Text = "";
            workHistory2TextBox.Text = "";
            workHistory3TextBox.Text = "";
            workHistory4TextBox.Text = "";
            accountNoTextBox.Text = "";
            cmbEmploymentStage.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            checkBox3.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;

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
        private void EmployeeEditForm_Load(object sender, EventArgs e)
        {
           
            FillCombo();
            timer1.Interval = 500;
            timer1.Start();
            //timer2.Interval = 100;
            //timer2.Start();
        }

        private void cmbEmployeeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            aEmployeeGateway = new EmployeeGateway();
            decimal employeeId = Convert.ToDecimal(cmbEmployeeId.Text);
            employee = aEmployeeGateway.EditEmployeeByEmployeeId(employeeId);
  
                employeeNameTextBox.Text = employee.EmployeeName;
                nickNameTextBox.Text = employee.NickName;
                cmbGender.Text = employee.Gender;
                corportEmailTextBox.Text = employee.CorporateMail;
                personalEmailTextBox.Text = employee.Email;
                dateOfBithDateTimePicker.Value = employee.DateOfBirth;

                nationalIdNumberTextBox.Text = Convert.ToString(employee.NationalIdNumber);
                cmbAreaCode1.Text = Convert.ToString(employee.AreaCode1);
                contact1TextBox.Text = Convert.ToString(employee.Contact1);
                cmbAreaCode2.Text = Convert.ToString(employee.AreaCode2);
                contact2NoTextBox.Text = Convert.ToString(employee.Contact2);
                designationTextBox.Text = employee.Designation;
                 accountNoTextBox.Text = employee.AccountNo;
                cmbGrade.Text = employee.GradeId;
 
                educationHistry1TextBox.Text = employee.EducationH1;
                educationHistry2TextBox.Text = employee.EducationH2;
                educationHistory3TextBox.Text = employee.EducationH3;
                educationHistory4TextBox.Text = employee.EducationH4;

                cmbJobLocation.Text = employee.JobLocation;

                presentAddressTextBox.Text = employee.PresentAddress;
                presentDistrictComboBox.Text = employee.PresentDistrict;
                permanantAddressTextBox.Text = employee.PermanantAddress;
                permanantDistrictComboBox.Text = employee.PermanantDistrict;
                localGardianNameTextBox.Text = employee.LocalGardianName;
                reference1TextBox.Text = employee.Reference1;
                reference2TextBox.Text = employee.Reference2;
                workHistory1TextBox.Text = employee.WorkHistry;
                workHistory2TextBox.Text = employee.WorkHistry2;
                workHistory3TextBox.Text = employee.WorkHistry3;
                workHistory4TextBox.Text = employee.WorkHistry4;


                joiningDate.Text = Convert.ToString(employee.JoiningDate);
               
                conformationDatePicker.Text = Convert.ToString(employee.ConformationDate);

                fatherNameTextBox.Text = employee.FatherName;
                motherNameTextBox.Text = employee.MotherName;
                cmbMaritalStatus.Text = employee.MaritalStatus;
                spouseNameTextBox.Text = employee.SpouseName;
                
                //nForm.employeePictureBox.Image = Image.FromStream(ms);
                //nForm.nationalImagePictureBox.Image = Image.FromStream(ms1);

                endOfTraineeDate.Text = Convert.ToString(employee.EndOfTraineePeriod);
                endOfProbationPeriodDate.Text = Convert.ToString(employee.EndOfProbationPeriod);
                
                dehiringDateDateTimePicker.Text = Convert.ToString(employee.DehiriningDate);
                lastappraisalDate.Text= Convert.ToString(employee.LastApprisaldate);
                lastAppraisalRatingTextBox.Text = Convert.ToString(employee.LastApprisalRating);
                departmentTextBox.Text = employee.Department;
                passportNOTextBox.Text = employee.PassportNo;
                cmbStatus.Text = employee.Status;
                cmbEmploymentStage.Text = employee.EmploymentStage;


        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =
                MessageBox.Show(
                    "Are you Surely want To Update this " + cmbEmployeeId.Text + " Employee ID?"+" Did You checked All Appropriate Checkboxes?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (checkBox1.Checked == true)
                {
                    d1 = Convert.ToDateTime(dehiringDateDateTimePicker.Value,
                        System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat);
                }
                else
                {
                    d1 = null;
                }
                if (checkBox2.Checked == true)
                {
                    d2 = Convert.ToDateTime(lastappraisalDate.Value,
                        System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat);
                }

                else
                {
                    d2 = null;
                }
                if (checkBox3.Checked == true)
                {
                    d3 = Convert.ToDateTime(conformationDatePicker.Value,
                        System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat);
                }
                else
                {
                    d3 = null;
                }
                if (checkBox4.Checked == true)
                {
                    d4 = Convert.ToDateTime(endOfProbationPeriodDate.Value,
                        System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat);
                }
                else
                {
                    d4 = null;
                }
                if (checkBox5.Checked == true)
                {
                    d5 = Convert.ToDateTime(endOfTraineeDate.Value,
                        System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat);
                }
                else
                {
                    d5 = null;
                }
                try
                {

                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    //string cb = "Update Employee Set EmployeeName='" + employeeNameTextBox.Text + "',NickName='" + nickNameTextBox.Text + "',Gender='" + cmbGender.Text + "',CorporateMail='" + corportEmailTextBox.Text + "',EmailId='" + personalEmailTextBox.Text + "',DateOfBirth='" + barthDate + "',NationalId='" + nationalIdNumberTextBox.Text + "',AreaOrCountryCode1='" + cmbAreaCode1.Text + "',Contact1='" + contact1TextBox.Text + "',AreaOrCountryCode2='" + cmbAreaCode2.Text + "',Contact2='" + contact2NoTextBox.Text + "',Designation='" + designationTextBox.Text + "',AccountNumber='" + accountNoTextBox.Text + "',GradeId='" + cmbGrade.Text + "',EducationL1='" + educationHistry1TextBox.Text + "',EducationL2='" + educationHistry2TextBox.Text + "',EducationL3='" + educationHistory3TextBox.Text + "',EducationL4='" + educationHistory4TextBox.Text + "',JobLocation='" + cmbJobLocation.Text + "',PresentAddress='" + presentAddressTextBox.Text + "',PresentDistrict='" + presentDistrictComboBox.Text + "',PermanantAddress='" + permanantAddressTextBox.Text + "',PermanantDistrict='" + permanantDistrictComboBox.Text + "',LocalGardianName='" + localGardianNameTextBox.Text + "',ReferenceDetail='" + reference1TextBox.Text + "',ReferenceD2='" + reference2TextBox.Text + "',WorkHistry='" + workHistory1TextBox.Text + "',WorkHistry2='" + workHistory2TextBox.Text + "',WorkHistry3='" + workHistory3TextBox.Text + "',WorkHistry4='" + workHistory4TextBox.Text + "',JoiningDate='" + joinDate + "',ConformationDate='" + ConformDate + "',DehiringDates='" + dehireDate + "',LastAppraisalDates='" + lastAppDate + "',LastApprisalRating='" + lastAppraisalRatingTextBox.Text + "',FatherName='" + fatherNameTextBox.Text + "',MotherName='" + motherNameTextBox.Text + "',MaritalStatus='" + cmbMaritalStatus.Text + "',SpouseName='" + spouseNameTextBox.Text + "',EndofTraineePeriods='" + trainydate + "',EndOfProbationPeriodDate='" + probationdate + "',Department='" + departmentTextBox.Text + "',PassportNo='" + passportNOTextBox.Text + "' Where EmployeeId='" + cmbEmployeeId.Text + "' ";
                    string cb =
                        "Update Employee Set EmployeeName=@empName,NickName=@nickName,Gender=@gender,CorporateMail=@corptMail,EmailId=@personalMail,DateOfBirth=@dateOfBirth,NationalId=@NID,AreaOrCountryCode1=@aCCode1,Contact1=@contact1,AreaOrCountryCode2=@aCCode2,Contact2=@contact2,Designation=@desig,AccountNumber=@accountNo,GradeId=@gradeId,EducationL1=@edu1,EducationL2=@edu2,EducationL3=@edu3,EducationL4=@edu4,JobLocation=@jobLoc,PresentAddress=@preAdd,PresentDistrict=@presentDist,PermanantAddress=@perAdd,PermanantDistrict=@perDist,LocalGardianName=@LGardian,ReferenceDetail=@ref1,ReferenceD2=@ref2,WorkHistry=@wHistry1,WorkHistry2=@wHistry2,WorkHistry3=@wHistry3,WorkHistry4=@wHistry4,JoiningDate=@joinDate,ConformationDate=@confDate,DehiringDates=@dehireDate,LastAppraisalDates=@lastAppDate,LastApprisalRating=@lastappRat,FatherName=@fName,MotherName=@mName,MaritalStatus=@maritalStatus,SpouseName=@spaoseName,EndofTraineePeriods=@endOfTrainPeriod,EndOfProbationPeriodDate=@endOfProbation,Department=@dept,PassportNo=@passPortNo,Status=@status,EmploymentStage=@empStage Where EmployeeId='" +
                        cmbEmployeeId.Text + "' ";
                    cmd = new SqlCommand(cb);
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@empName", employeeNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@nickName", nickNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@corptMail", corportEmailTextBox.Text);
                    cmd.Parameters.AddWithValue("@personalMail", personalEmailTextBox.Text);
                    cmd.Parameters.AddWithValue("@dateOfBirth",
                        Convert.ToDateTime(dateOfBithDateTimePicker.Value,
                            System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat));
                    cmd.Parameters.AddWithValue("@NID", nationalIdNumberTextBox.Text);
                    cmd.Parameters.AddWithValue("@aCCode1", cmbAreaCode1.Text);
                    cmd.Parameters.AddWithValue("@contact1", contact1TextBox.Text);
                    cmd.Parameters.AddWithValue("@aCCode2", cmbAreaCode2.Text);
                    cmd.Parameters.AddWithValue("@contact2", contact2NoTextBox.Text);
                    cmd.Parameters.AddWithValue("@desig", designationTextBox.Text);
                    cmd.Parameters.AddWithValue("@accountNo", accountNoTextBox.Text);
                    cmd.Parameters.AddWithValue("@gradeId", cmbGrade.Text);
                    cmd.Parameters.AddWithValue("@edu1", educationHistry1TextBox.Text);
                    cmd.Parameters.AddWithValue("@edu2", educationHistry2TextBox.Text);
                    cmd.Parameters.AddWithValue("@edu3", educationHistory3TextBox.Text);
                    cmd.Parameters.AddWithValue("@edu4", educationHistory4TextBox.Text);
                    cmd.Parameters.AddWithValue("@jobLoc", cmbJobLocation.Text);
                    cmd.Parameters.AddWithValue("@preAdd", presentAddressTextBox.Text);
                    cmd.Parameters.AddWithValue("@presentDist", presentDistrictComboBox.Text);
                    cmd.Parameters.AddWithValue("@perAdd", permanantAddressTextBox.Text);
                    cmd.Parameters.AddWithValue("@perDist", permanantDistrictComboBox.Text);
                    cmd.Parameters.AddWithValue("@LGardian", localGardianNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@ref1", reference1TextBox.Text);
                    cmd.Parameters.AddWithValue("@ref2", reference2TextBox.Text);
                    cmd.Parameters.AddWithValue("@wHistry1", workHistory1TextBox.Text);
                    cmd.Parameters.AddWithValue("@wHistry2", workHistory2TextBox.Text);
                    cmd.Parameters.AddWithValue("@wHistry3", workHistory3TextBox.Text);
                    cmd.Parameters.AddWithValue("@wHistry4", workHistory4TextBox.Text);
                    cmd.Parameters.AddWithValue("@joinDate",
                        Convert.ToDateTime(joiningDate.Value,
                            System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat));
                    cmd.Parameters.AddWithValue("@confDate", (object) d3 ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@dehireDate", (object) d1 ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@lastAppDate", (object) d2 ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@lastappRat", lastAppraisalRatingTextBox.Text);
                    cmd.Parameters.AddWithValue("@fName", fatherNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@mName", motherNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@spaoseName", spouseNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@maritalStatus", cmbMaritalStatus.Text);

                    cmd.Parameters.AddWithValue("@endOfTrainPeriod", (object) d5 ?? DBNull.Value);

                    cmd.Parameters.AddWithValue("@endOfProbation", (object) d4 ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@dept", departmentTextBox.Text);
                    cmd.Parameters.AddWithValue("@passPortNo", passportNOTextBox.Text);
                    cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@empStage", cmbEmploymentStage.Text);

                    cmd.ExecuteReader();
                    con.Close();

                    // newRowID1 = Convert.ToInt32(cmbEmployeeId.Text);
                    MessageBox.Show("Successfully Updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dynamic aForm22 = new EmployeeDetailsGrid();
            aForm22.ShowDialog();
            this.Visible = true;
        }

        private void spouseNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMaritalStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbMaritalStatus.Text == "Married")
            {
                spouseNameTextBox.ReadOnly = false;
            }
            else
            {
                spouseNameTextBox.ReadOnly = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.label26.ForeColor == Color.Black)
            {
                this.label26.ForeColor= Color.Aqua;
                
            }
            else
            {
                this.label26.ForeColor = Color.Black;
            }
        }

        private void EmployeeInfoEntryForm_Enter(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label26.Location = new Point(label26.Location.X - 5, label26.Location.Y);

            if (label26.Location.X < (0 - label26.Width))
            {
                label26.Location = new Point(0 + label26.Width, label26.Location.Y);
            }
        }
    }
}
