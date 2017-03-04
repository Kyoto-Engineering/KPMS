using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryCalculationUI.DAO;
using SalaryCalculationUI.DBGateway;
using SalaryCalculationUI.Gateway;
using SalaryCalculationUI.Manager;

namespace SalaryCalculationUI.UI
{
    public partial class EmployeeInfoForm : Form
    {
        private double kr = 0.00, nkrId = 0.00;
        public Employee employee;
        public EmployeeManager aEmpManager;
        private EmployeeGateway aEmployeeGateway;
        private List<Employee> aEmployees;
        // private OpenFileDialog openFileDialog1;
        private SqlConnection con;
        ConnectionString cs = new ConnectionString();
        private SqlCommand cmd;
        private SqlDataReader rdr;
        public int affectedRows1;
        private Nullable<DateTime> d1, d2, d3, d4, d5;
        private string s, h, hn, m;
        private int counter = 0;

        public EmployeeInfoForm()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void employeeImageUploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openf = new OpenFileDialog();
            openf.InitialDirectory = "C:\\";
            openf.Filter = "Image Files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            openf.FilterIndex = 1;
            if (openf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openf.CheckFileExists)
                {
                    SqlConnection conn =
                        new SqlConnection(
                            @"server=KYOTO-PC06\SQLSERVER2014;Initial Catalog=EmployeeMSDb;Integrated Security=true");
                    conn.Open();




                    // string CorrectFileName = System.IO.Path.GetFileName(openf.FileName);
                    // SqlCommand comnd = new SqlCommand(@"Insert Into Images1(Id,Paths) values('" + employeeIdImagerelatedTextBox.Text + "','\\Images\\" + CorrectFileName + "')", conn);
                    //comnd.ExecuteNonQuery();
                    //SqlDataReader rdr = comnd.ExecuteReader();

                    //if (rdr.Read())
                    //{
                    //    //string paths = Application.StartupPath;
                    //    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 12));
                    //    System.IO.File.Copy(openf.FileName, path + "\\Images\\" + CorrectFileName);
                    //    MessageBox.Show("Successfully Uploaded");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Image Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //}

                    //conn.Close();






                }
            }

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn =
                new SqlConnection(
                    @"server=KYOTO-PC06\SQLSERVER2014;Initial Catalog=EmployeeMSDb;Integrated Security=true");
            conn.Open();
            //SqlDataAdapter adp = new SqlDataAdapter(@"Select * from Images1 where Id='"+employeeIdImagerelatedTextBox.Text+"'",conn);
            //DataTable dt=new DataTable();
            //adp.Fill(dt);
            //string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 12));
            //employeePictureBox.Image = Image.FromFile(path + dt.Rows[0]["Paths"].ToString());

        }

        //private void FillEmployeeIdImageTextBox()
        //{
        //    double b;
        //    b = double.Parse(employeeIdTextBox.Text);
        //    kr = b;
        //    employeeIdImagerelatedTextBox.Text = kr.ToString();
        //}
        private void employeeIdTextBox_TextChanged(object sender, EventArgs e)
        {
            // FillEmployeeIdImageTextBox();
        }

        private void nationalIdImageUploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openf = new OpenFileDialog();
            openf.InitialDirectory = "C:\\";
            openf.Filter = "Image Files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            openf.FilterIndex = 1;
            if (openf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openf.CheckFileExists)
                {
                    SqlConnection conn =
                        new SqlConnection(
                            @"server=DESKTOP-DNVVVO3\SQLSERVER2014;Initial Catalog=EmployeeMSDb;Integrated Security=true");
                    conn.Open();
                    string CorrectFileName = System.IO.Path.GetFileName(openf.FileName);
                    //SqlCommand comnd = new SqlCommand(@"Insert Into Images2(Id,Paths) values('" + nationalIdImageuploadTextBox.Text + "','\\Images2\\" + CorrectFileName + "')", conn);
                    //comnd.ExecuteNonQuery();
                    //conn.Close();
                    ////string paths = Application.StartupPath;
                    //string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 12));
                    //System.IO.File.Copy(openf.FileName, path + "\\Images2\\" + CorrectFileName);
                    //MessageBox.Show("Successfully Uploaded");
                }
            }
        }

        //private void showButton2_Click(object sender, EventArgs e)
        //{
        //    SqlConnection conn =
        //        new SqlConnection(
        //            @"server=DESKTOP-DNVVVO3\SQLSERVER2014;Initial Catalog=EmployeeMSDb;Integrated Security=true");
        //    conn.Open();
        //    SqlDataAdapter adp =
        //        new SqlDataAdapter(@"Select * from Images2 where Id='" + nationalIdNumberTextBox.Text + "'", conn);
        //    DataTable dt = new DataTable();
        //    adp.Fill(dt);
        //    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 12));
        //    nationalImagePictureBox.Image = Image.FromFile(path + dt.Rows[0]["Paths"].ToString());
        //}

        //private void FillNationalIdNumberImageTextBox()
        //{
        //    double nb;
        //   nb = double.Parse(nationalIdNumberTextBox.Text);
        //   nkrId = nb;
        //   nationalIdImageuploadTextBox.Text = nkrId.ToString();
        //}
        private void nationalIdNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            // FillNationalIdNumberImageTextBox();
        }

        public void Reset()
        {
            employeeNameTextBox.Text = "";
            nickNameTextBox.Text = "";
            fatherNameTextBox.Text = "";
            motherNameTextBox.Text = "";
            cmbMaritalStatus.Text = "";
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
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;



        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =
                MessageBox.Show(
                    " Did You checked All Appropriate Checkboxes?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (employeeNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter Employee name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                employeeNameTextBox.Focus();
                return;
            }

            if (joiningDate.Text == "")
            {
                MessageBox.Show("Please select Joining Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                joiningDate.Focus();
                return;
            }
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
                string ct = "select EmployeeName from Employee where EmployeeName='" + employeeNameTextBox.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("This Employee  Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    employeeNameTextBox.Text = "";
                    employeeNameTextBox.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }



                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb =
                    "insert into Employee(EmployeeName,NickName,Gender,CorporateMail,EmailId,DateOfBirth,NationalId,AreaOrCountryCode1,Contact1,AreaOrCountryCode2,Contact2,Designation,GradeId,EducationL1,EducationL2,EducationL3,EducationL4,JobLocation,PresentAddress,PresentDistrict,PermanantAddress,PermanantDistrict,LocalGardianName,ReferenceDetail,ReferenceD2,WorkHistry,WorkHistry2,WorkHistry3,WorkHistry4,JoiningDate,ConformationDate,FatherName,MotherName,MaritalStatus,SpouseName,EndofTraineePeriods,EndOfProbationPeriodDate,Department,PassportNo)VALUES (@empName,@nickName,@gender,@corptMail,@personalMail,@dateOfBirth,@NID,@aCCode1,@contact1,@aCCode2,@contact2,@desig,@gradeId,@edu1,@edu2,@edu3,@edu4,@jobLoc,@preAdd,@perDist,@perAdd,@presentDist,@LGardian,@ref1,@ref2,@wHistry1,@wHistry2,@wHistry3,@wHistry4,@joinDate,@confDate,@fName,@mName,@maritalStatus,@spaoseName,@endOfTrainPeriod,@endOfProbation,@dept,@passPortNo)" +
                    "SELECT CONVERT(int, SCOPE_IDENTITY())";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@empName", employeeNameTextBox.Text);
                cmd.Parameters.AddWithValue("@nickName", nickNameTextBox.Text);
                cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("@corptMail", corportEmailTextBox.Text);
                cmd.Parameters.AddWithValue("@personalMail", personalEmailTextBox.Text);
                //cmd.Parameters.AddWithValue("@dateOfBirth", date3);
                cmd.Parameters.AddWithValue("@dateOfBirth",
                    Convert.ToDateTime(dateOfBithDateTimePicker.Value,
                        System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat));
                cmd.Parameters.AddWithValue("@NID", nationalIdNumberTextBox.Text);
                cmd.Parameters.AddWithValue("@aCCode1", cmbAreaCode1.Text);
                cmd.Parameters.AddWithValue("@contact1", contact1TextBox.Text);
                cmd.Parameters.AddWithValue("@aCCode2", cmbAreaCode2.Text);
                cmd.Parameters.AddWithValue("@contact2", contact2NoTextBox.Text);
                cmd.Parameters.AddWithValue("@desig", designationTextBox.Text);
                //cmd.Parameters.AddWithValue("@accountNo", accountNoTextBox.Text);
                cmd.Parameters.AddWithValue("@gradeId", cmbGrade.Text);
                cmd.Parameters.AddWithValue("@edu1", (object) s ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@edu2", (object) h ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@edu3", (object) hn ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@edu4", (object) m ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@jobLoc", cmbJobLocation.Text);
                cmd.Parameters.AddWithValue("@preAdd", presentAddressTextBox.Text);
                cmd.Parameters.AddWithValue("@presentDist", presentDistrictComboBox.Text);
                cmd.Parameters.AddWithValue("@perAdd", permanantAddressTextBox.Text);
                cmd.Parameters.AddWithValue("@perDist", permanantDistrictComboBox.Text);
                cmd.Parameters.AddWithValue("@LGardian", localGardianNameTextBox.Text);
                cmd.Parameters.AddWithValue("@ref1", reference1TextBox.Text);
                cmd.Parameters.AddWithValue("@ref2", reference2TextBox.Text);
                cmd.Parameters.AddWithValue("@wHistry1", workHistory1TextBox.Text);
                cmd.Parameters.AddWithValue("@whistry2", workHistory2TextBox.Text);
                cmd.Parameters.AddWithValue("@wHistry3", workHistory3TextBox.Text);
                cmd.Parameters.AddWithValue("@wHistry4", workHistory4TextBox.Text);
                cmd.Parameters.AddWithValue("@joinDate",
                    Convert.ToDateTime(joiningDate.Value,
                        System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat));
                cmd.Parameters.AddWithValue("@confDate", (object) d3 ?? DBNull.Value);
                //cmd.Parameters.AddWithValue("@dehireDate",Convert.ToDateTime(dehiringDateDateTimePicker.Value,System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat));                
                // cmd.Parameters.AddWithValue("@lastAppDate",Convert.ToDateTime(lastappraisalDate.Value,System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat));
                //cmd.Parameters.AddWithValue("@lastappRat", lastAppraisalRatingTextBox.Text);
                cmd.Parameters.AddWithValue("@fName", fatherNameTextBox.Text);
                cmd.Parameters.AddWithValue("@mName", motherNameTextBox.Text);
                cmd.Parameters.AddWithValue("@spaoseName", spouseNameTextBox.Text);
                cmd.Parameters.AddWithValue("@maritalStatus", cmbMaritalStatus.Text);
                cmd.Parameters.AddWithValue("@endOfTrainPeriod", (object) d5 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@endOfProbation", (object) d4 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@dept", departmentTextBox.Text);
                cmd.Parameters.AddWithValue("@passPortNo", passportNOTextBox.Text);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                affectedRows1 = (int) cmd.ExecuteScalar();
                con.Close();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                saveButton.Enabled = false;
                saveButton.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //int i = 0;

            //EmployeeManager aEmpManager=new EmployeeManager();
            //try
            //{
            //    Employee aEmployee = new Employee
            //    {

            //        EmployeeName = employeeNameTextBox.Text,
            //        //EmployeeImage = employeePictureBox.Text,
            //        NickName = nickNameTextBox.Text,

            //        Email = emailTextBox.Text,
            //        DateOfBirth = Convert.ToDateTime(dateOfBithDateTimePicker.Text),
            //        NationalIdNumber = Convert.ToDecimal(nationalIdNumberTextBox.Text),
            //        NamtionalIdImage = nationalImagePictureBox.Text,
            //        ContactNumber = contactNoTextBox.Text,
            //        Designation = designationTextBox.Text,
            //        AccountNo = accountNoTextBox.Text,
            //        Grade = cmbGrade.Text,
            //        EducationHistry = educationHistry1TextBox.Text,
            //        JobLocation = cmbJobLocation.Text,
            //        PresentAddress = presentAddressTextBox.Text,
            //        PresentDistrict = presentDistrictComboBox.Text,
            //        PermanantAddress = permanantAddressTextBox.Text,
            //        PermanantDistrict = permanantDistrictComboBox.Text,
            //        LocalGardianName = localGardianNameTextBox.Text,
            //        ReferenceDetail = reference1TextBox.Text,
            //        WorkHistry = workHistory1TextBox.Text,
            //        JoiningDate = Convert.ToString(joiningDateTimePicker5.Value),
            //        ConformationDate = Convert.ToString(conformationDatePicker.Value),
            //        DehiriningDate = Convert.ToString(dehiringDateDateTimePicker.Value),
            //        LastApprisaldate = Convert.ToDateTime(lastappraisalDate.Value),
            //        LastApprisalRating = Convert.ToDecimal(lastAppraisalRatingTextBox.Text),
            //        FatherName = fatherNameTextBox.Text,
            //        MotherName = motherNameTextBox.Text,
            //        EndOfTraineePeriod = Convert.ToString(endOfTraineeDate.Value),
            //        EndOfProbationPeriod = Convert.ToString(endOfProbationPeriodDate.Value),
            //        Department = departmentTextBox.Text,
            //        PassportNo = passportNOTextBox.Text



            //EmployeeId = Convert.ToDecimal(employeeIdTextBox.Text),
            //EmployeeName = employeeNameTextBox.Text,
            //Designation = designationTextBox.Text,
            //Grade = gradTextBox.Text,
            //AccountNo = accountNoTextBox.Text,

            //NickName = nickNameTextBox.Text,
            //Email = emailTextBox.Text,
            //ContactNumber = contactNoTextBox.Text,
            //DateOfBirth = Convert.ToDateTime(dateOfBithDateTimePicker.Text),
            //PresentAddress = presentAddressTextBox.Text,
            //PresentDistrict = presentDistrictComboBox.Text,
            //PermanantAddress = permanantAddressTextBox.Text,
            //PermanantDistrict = permanantDistrictComboBox.Text,

            //NationalIdNumber = Convert.ToDecimal(nationalIdNumberTextBox.Text),
            //FatherName = fatherNameTextBox.Text,
            //MotherName = motherNameTextBox.Text,
            //EducationHistry = educationHistryTextBox.Text,
            //Department = departmentTextBox.Text,
            //ReferenceDetail = referenceDetailTextBox.Text,
            //EmployeeImage = employeePictureBox.Text,
            //NamtionalIdImage = nationalImagePictureBox.Text,

            //LocalGardianName = localGardianNameTextBox.Text,
            //JobLocation = jobLocationComboBox.Text,
            //WorkHistry = workHistoryTextBox.Text,
            //EndOfTraineePeriod = Convert.ToString(endOfTraineeDateTimePicker.Value),
            //EndOfProbationPeriod = Convert.ToString(endOfProbationPeriodDateTimePicker.Value),
            //JoiningDate = Convert.ToString(joiningDateDateTimePicker5.Value),
            //ConformationDate = Convert.ToString(conformationDateDateTimePicker.Value),
            //DehiriningDate = Convert.ToString(dehiringDateDateTimePicker.Value),
            //LastApprisaldate = Convert.ToDateTime(lastappraisalDatDateTimePicker.Value),
            //LastApprisalRating = Convert.ToDecimal(lastAppraisalRatingTextBox.Text),
            //PassportNo = passportNOTextBox.Text
            //    };

            //    i = aEmpManager.SaveEmployee(aEmployee);
            //    MessageBox.Show("Successfully Saved");
            //}
            //catch (FormatException formatException)
            //{
            //    MessageBox.Show("Please Enter Input In Corret Format", formatException.Message);
            //}

            //catch (Exception exception)
            //{

            //    MessageBox.Show(exception.Message);
            //}

             }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

//        private void editButton_Click(object sender, EventArgs e)
//        {
//            this.Visible = false;
//            EmployeeEditForm aForm = new EmployeeEditForm();
//            aForm.ShowDialog();
//            this.Visible = true;
//            aEmployeeGateway = new EmployeeGateway();
//            decimal employeeId = Convert.ToDecimal(employeeIdTextBox.Text);
//            employee = aEmployeeGateway.EditEmployeeByEmployeeId(employeeId);
//            if (employee.EmployeeId != Convert.ToDecimal(employeeIdTextBox.Text))
//            {
//                MessageBox.Show("Employee Id is not found.Please enter correct Id");

//            }
//            else
//            {
//                //EmployeeInfoForm nForm=new EmployeeInfoForm();
//                //MemoryStream ms = new MemoryStream(Convert.ToByte(employee.EmployeeImage));
//                // // MemoryStream ms = new MemoryStream(employee.EmployeeImage);
//                // MemoryStream ms1 = new MemoryStream(Convert.ToByte(employee.NamtionalIdImage));

//                employeeNameTextBox.Text = employee.EmployeeName;
//                designationTextBox.Text = employee.Designation;
//                cmbGrade.Text = employee.GradeId;
//               // accountNoTextBox.Text = Convert.ToString(employee.AccountNo);
//                nickNameTextBox.Text = employee.NickName;
//                corportEmailTextBox.Text = employee.Email;
//                contact2NoTextBox.Text = Convert.ToString(employee.Contact1);
//                dateOfBithDateTimePicker.Value = employee.DateOfBirth;
//                presentAddressTextBox.Text = employee.PresentAddress;
//                presentDistrictComboBox.Text = employee.PresentDistrict;
//                permanantAddressTextBox.Text = employee.PermanantAddress;
//                permanantDistrictComboBox.Text = employee.PermanantDistrict;
//                nationalIdNumberTextBox.Text = Convert.ToString(employee.NationalIdNumber);
//                fatherNameTextBox.Text = employee.FatherName;
//                motherNameTextBox.Text = employee.MotherName;
//                educationHistry1TextBox.Text = employee.EducationH1;
//                departmentTextBox.Text = employee.Department;
//                reference1TextBox.Text = employee.Reference1;





//                //nForm.employeePictureBox.Image = Image.FromStream(ms);

//                //nForm.nationalImagePictureBox.Image = Image.FromStream(ms1);



//                localGardianNameTextBox.Text = employee.LocalGardianName;

//                cmbJobLocation.Text = employee.JobLocation;
//                workHistory1TextBox.Text = employee.WorkHistry;
//                endOfTraineeDate.Value = Convert.ToDateTime(employee.EndOfTraineePeriod);
//                endOfProbationPeriodDate.Value = Convert.ToDateTime(employee.EndOfProbationPeriod);
//                joiningDate.Value = Convert.ToDateTime(employee.JoiningDate);
//                conformationDatePicker.Value = Convert.ToDateTime(employee.ConformationDate);
//                //dehiringDateDateTimePicker.Value = Convert.ToDateTime(employee.DehiriningDate);
//               // lastappraisalDate.Value = Convert.ToDateTime(employee.LastApprisaldate);
//               // lastAppraisalRatingTextBox.Text = Convert.ToString(employee.LastApprisalRating);
//                passportNOTextBox.Text = employee.PassportNo;






//    }
//}

//private void closeButton_Click(object sender, EventArgs e)
//        {
//            this.Hide();
//            MainUI aMainUi=new MainUI();
//            aMainUi.Show();

//        }

        private void brouseButton_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog1=new OpenFileDialog();
            //try
            //{
            //openFileDialog1.InitialDirectory = "C:\\";
            //    var _with1 = openFileDialog1;

            //    _with1.Filter = ("Image Files |*.png; *.bmp; *.jpg;*.jpeg; *.gif;");
            //    _with1.FilterIndex = 4;
            //    //Reset the file name
            //    openFileDialog1.FileName = "";

            //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        employeePictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void brouseButton2_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //try
            //{
            //    openFileDialog1.InitialDirectory = "C:\\";
            //    var _with1 = openFileDialog1;

            //    _with1.Filter = ("Image Files |*.png; *.bmp; *.jpg;*.jpeg; *.gif;");
            //    _with1.FilterIndex = 4;
            //    //Reset the file name
            //    openFileDialog1.FileName = "";

            //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        nationalImagePictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //int emp = 0;
            //EmployeeGateway aEmployeeGateway=new EmployeeGateway();
            //try
            //{
            //    Employee aEmployee = new Employee
            //    {

            //        EmployeeId = Convert.ToDecimal(employeeIdTextBox.Text),
            //        EmployeeName = employeeNameTextBox.Text,
            //        Designation = designationTextBox.Text,
            //        GradeId = cmbGrade.Text,
            //       // AccountNo = accountNoTextBox.Text,

            //        NickName = nickNameTextBox.Text,
            //        Email = corportEmailTextBox.Text,
            //        Contact1 = contact2NoTextBox.Text,
            //        DateOfBirth = Convert.ToDateTime(dateOfBithDateTimePicker.Text),
            //        PresentAddress = presentAddressTextBox.Text,
            //        PresentDistrict = presentDistrictComboBox.Text,
            //        PermanantAddress = permanantAddressTextBox.Text,
            //        PermanantDistrict = permanantDistrictComboBox.Text,

            //        NationalIdNumber = Convert.ToDecimal(nationalIdNumberTextBox.Text),
            //        FatherName = fatherNameTextBox.Text,
            //        MotherName = motherNameTextBox.Text,
            //        EducationHistry = educationHistry1TextBox.Text,
            //        Department = departmentTextBox.Text,
            //        ReferenceDetail = reference1TextBox.Text,
            //        EmployeeImage = employeePictureBox.Text,
            //        NamtionalIdImage = nationalImagePictureBox.Text,

            //        LocalGardianName = localGardianNameTextBox.Text,
            //        JobLocation = cmbJobLocation.Text,
            //        WorkHistry = workHistory1TextBox.Text,
            //        EndOfTraineePeriod = Convert.ToString(endOfTraineeDate.Value),
            //        EndOfProbationPeriod = Convert.ToString(endOfProbationPeriodDate.Value),
            //        JoiningDate = Convert.ToString(joiningDate.Value),
            //        ConformationDate = Convert.ToString(conformationDatePicker.Value),
            //       // DehiriningDate = Convert.ToString(dehiringDateDateTimePicker.Value),
            //        //LastApprisaldate = Convert.ToDateTime(lastappraisalDate.Value),
            //       // LastApprisalRating = Convert.ToDecimal(lastAppraisalRatingTextBox.Text),

            //        PassportNo = passportNOTextBox.Text

            //    };

            //   // emp = aEmployeeGateway.UpdateEmployee(aEmployee);
            //    MessageBox.Show("SuccessFully Updated");
            //}
            //catch (FormatException formatException)
            //{
            //    MessageBox.Show("Please Enter Input In Corret Format", formatException.Message);
            //}

            //catch (Exception exception)
            //{

            //    MessageBox.Show(exception.Message);
            //}

        }

        private void newButton_Click(object sender, EventArgs e)
        {

            EmployeeInfoForm aeForm = new EmployeeInfoForm();
            this.Visible = false;
            aeForm.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dynamic aform = new EmployeeDetailsGrid();
            aform.ShowDialog();
            this.Visible = true;
        }

        private void contactNoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void editButton2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            EmployeeEditForm aForm = new EmployeeEditForm();
            aForm.ShowDialog();
            this.Visible = true;
        }

        private void EmployeeInfoForm_Load(object sender, EventArgs e)
        {
            counter = 0;
            timer1.Interval = 500;
            timer2.Interval = 500;
            timer3.Interval = 500;
            timer4.Interval = 500;
            timer5.Interval = 500;
            timer6.Interval = 500;
            timer7.Interval = 500;
            timer8.Interval = 500;
            timer9.Interval = 500;
            timer10.Interval = 500;
            timer11.Interval = 500;
            timer12.Interval = 500;
            timer13.Interval = 500;
            timer14.Interval = 500;
            timer1.Start();
            this.label27.Visible = false;
            this.label29.Visible = false;
            this.label30.Visible = false;
            this.label31.Visible = false;
            this.label34.Visible = false;
            this.label37.Visible = false;

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

        private void sscYear_TextChanged(object sender, EventArgs e)
        {

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

        private void msYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            // Check if the pressed character was a backspace or numeric.
            if (e.KeyChar != (char) 8 && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (this.label16.ForeColor == Color.Black)
            {
                this.label16.ForeColor = Color.Red;

            }
            else
            {
                this.label16.ForeColor = Color.Black;
            }

            counter++;
            if (counter == 2) //or whatever your limit is
            {
                timer1.Stop();
                this.label27.Visible = true;
                timer2.Start();
            }

            


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.label27.ForeColor == Color.Black)
            {
                this.label27.ForeColor = Color.Red;

            }
            else
            {
                this.label27.ForeColor = Color.Black;
            }

            counter++;
            if (counter == 5) //or whatever your limit is
            {
                timer2.Stop();
                this.label29.Visible = true;
                timer3.Start();
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (this.label29.ForeColor == Color.Black)
            {
                this.label29.ForeColor = Color.Red;

            }
            else
            {
                this.label29.ForeColor = Color.Black;
            }

            counter++;
            if (counter == 8) //or whatever your limit is
            {
                timer3.Stop();
                this.label30.Visible = true;
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (this.label30.ForeColor == Color.Black)
            {
                this.label30.ForeColor = Color.Red;

            }
            else
            {
                this.label30.ForeColor = Color.Black;
            }

            counter++;
            if (counter == 11) //or whatever your limit is
            {
                timer4.Stop();
                this.label31.Visible = true;
                timer5.Start();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (this.label31.ForeColor == Color.Black)
            {
                this.label31.ForeColor = Color.Red;

            }
            else
            {
                this.label31.ForeColor = Color.Black;
            }

            counter++;
            if (counter == 14) //or whatever your limit is
            {
                timer5.Stop();
                this.label34.Visible = true;
                timer6.Start();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (this.label34.ForeColor == Color.Black)
            {
                this.label34.ForeColor = Color.Red;

            }
            else
            {
                this.label34.ForeColor = Color.Black;
            }

            counter++;
            if (counter == 17) //or whatever your limit is
            {
                timer6.Stop();
                this.label37.Visible = true;
                timer7.Start();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (this.label37.ForeColor == Color.Black)
            {
                this.label37.ForeColor = Color.Red;

            }
            else
            {
                this.label37.ForeColor = Color.Black;
            }

            counter++;
            if (counter == 20) //or whatever your limit is
            {
                timer7.Stop();
                counter = 0;
                timer8.Start();
            }
        }
        private void timer8_Tick(object sender, EventArgs e)
        {

            if (this.label16.ForeColor == Color.Black)
            {
                this.label16.ForeColor = Color.Red;

            }
            else
            {
                this.label16.ForeColor = Color.Black;
            }

            counter++;
            if (counter == 2) //or whatever your limit is
            {

                
                timer9.Start();
            }

            else if (counter == 5) //or whatever your limit is
            {


                timer10.Start();
            }

            else if (counter == 8) //or whatever your limit is
            {


                timer11.Start();
            }
            else if (counter == 11) //or whatever your limit is
            {


                timer12.Start();
            }
            else if (counter == 14) //or whatever your limit is
            {
              
               
                timer13.Start();
            }
            else if (counter == 17) //or whatever your limit is
            {

                timer14.Start();
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            if (this.label27.ForeColor == Color.Black)
            {
                this.label27.ForeColor = Color.Red;

            }
            else
            {
                this.label27.ForeColor = Color.Black;
            }

            

        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            if (this.label29.ForeColor == Color.Black)
            {
                this.label29.ForeColor = Color.Red;

            }
            else
            {
                this.label29.ForeColor = Color.Black;
            }

            
           
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            if (this.label30.ForeColor == Color.Black)
            {
                this.label30.ForeColor = Color.Red;

            }
            else
            {
                this.label30.ForeColor = Color.Black;
            }

           
            
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            if (this.label31.ForeColor == Color.Black)
            {
                this.label31.ForeColor = Color.Red;

            }
            else
            {
                this.label31.ForeColor = Color.Black;
            }

            
            
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            if (this.label34.ForeColor == Color.Black)
            {
                this.label34.ForeColor = Color.Red;

            }
            else
            {
                this.label34.ForeColor = Color.Black;
            }

            
            
        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            if (this.label37.ForeColor == Color.Black)
            {
                this.label37.ForeColor = Color.Red;

            }
            else
            {
                this.label37.ForeColor = Color.Black;
            }

            
            //if (counter == 20) //or whatever your limit is
            //{
                
            //    counter = 0;
                
            //}
        }

        

       
    }
}
