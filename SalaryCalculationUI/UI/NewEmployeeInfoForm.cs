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
using SalaryCalculationUI.Manager;

namespace SalaryCalculationUI.UI
{
    public partial class NewEmployeeInfoForm : Form
    {
        ConnectionString cs = new ConnectionString();
        private SqlConnection con;
        private SqlCommand cmd;

        public NewEmployeeInfoForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int i = 0;

            //EmployeeManager aEmpManager = new EmployeeManager();
            //try
            //{
            //    Employee aEmployee = new Employee
            //    {
            //        //EmployeeId = Convert.ToDecimal(employeeIdTextBox.Text),
            //        EmployeeName = employeeNameTextBox.Text,
            //        Designation = designationTextBox.Text,
            //        GradeId = gradTextBox.Text,
            //        AccountNo = accountNoTextBox.Text,

            //        NickName = nickNameTextBox.Text,
            //        Email = emailTextBox.Text,
            //        Contact1= contactNoTextBox.Text,
            //        DateOfBirth = Convert.ToDateTime(dateOfBithDateTimePicker.Text),
            //        PresentAddress = presentAddressTextBox.Text,
            //        PresentDistrict = presentDistrictComboBox.Text,
            //        PermanantAddress = permanantAddressTextBox.Text,
            //        PermanantDistrict = permanantDistrictComboBox.Text,

            //        NationalIdNumber = Convert.ToDecimal(nationalIdNumberTextBox.Text),
            //        FatherName = fatherNameTextBox.Text,
            //        MotherName = motherNameTextBox.Text,
            //        EducationH1 = educationHistryTextBox.Text,
            //        Department = departmentTextBox.Text,
            //        Reference1 = referenceDetailTextBox.Text,
            //        //EmployeeImage = employeePictureBox.Text,
            //        //NamtionalIdImage = nationalImagePictureBox.Text,

            //        LocalGardianName = localGardianNameTextBox.Text,
            //        JobLocation = jobLocationComboBox.Text,
            //        WorkHistry = workHistoryTextBox.Text,
            //        //EndOfTraineePeriod = endOfTraineeDateTimePicker.Value,
            //        //EndOfProbationPeriod = endOfProbationPeriodDateTimePicker.Value,
            //        //JoiningDate = joiningDateDateTimePicker5.Value,
            //        //ConformationDate = conformationDateDateTimePicker.Value,
            //        //DehiriningDate = dehiringDateDateTimePicker.Value,
            //        //LastApprisaldate = lastappraisalDatDateTimePicker.Value,
            //        PassportNo = PassportNOTextBox.Text,
            //        //Status = statuscheckBox.Checked
            //        // LastApprisalRating = Convert.ToDecimal(lastAppraisalRatingTextBox.Text)   
            //    };

            //    i = aEmpManager.SaveEmployee(aEmployee);
            //    MessageBox.Show("Successfully  Saved");
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

        private void NewEmployeeInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void brouseButton_Click(object sender, EventArgs e)
        {

        }

        private void nationalImagePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void employeePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void endOfTraineeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void endOfProbationPeriodDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void joiningDateDateTimePicker5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void conformationDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dehiringDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lastappraisalDatDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void workHistoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void jobLocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void localGardianNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void motherNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fatherNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateOfBithDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nationalIdNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactNoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nickNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void permanantDistrictComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void permanantAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void presentDistrictComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void accountNoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gradTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void presentAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void designationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void educationHistryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void departmentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void brouseButton2_Click(object sender, EventArgs e)
        {

        }

        private void referenceDetailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainUI aMainUi=new MainUI();
            aMainUi.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void statuscheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void PassportNOTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }
    }
}
