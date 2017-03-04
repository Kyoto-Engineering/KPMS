using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryCalculationUI.DAO;
using SalaryCalculationUI.Gateway;
using SalaryCalculationUI.Manager;

namespace SalaryCalculationUI.UI
{
    public partial class GradeCalculationEntryForm : Form
    {
        private double hsg = 0.0000,grossSG=0.0000;
        private Grade grade;
        private GradeGateway gGradeGateway;
        private List<Grade> grades;
        
        public GradeCalculationEntryForm()
        {
            InitializeComponent();
        }

        private void HouseRentCalculationG()
        {
            double bsic, houseRentG,ta=1000,m=1000;
            bsic = double.Parse(basicSalaryGTextBox.Text);
            hsg = (bsic*0.5);
            houseRentGTextBox.Text = hsg.ToString();
            transportAllowanceGTextBox.Text = ta.ToString();
            medicalAllowanceGTextBox.Text = m.ToString();

        }
        private void basicSalaryGTextBox_TextChanged(object sender, EventArgs e)
        {
            HouseRentCalculationG();
        }

        private void GrossSalaryGCalculation()
        {
            double bs, tr, md, hs, other;
            bs = double.Parse(basicSalaryGTextBox.Text);
            tr = double.Parse(transportAllowanceGTextBox.Text);
            md = double.Parse(medicalAllowanceGTextBox.Text);
            hs = double.Parse(houseRentGTextBox.Text);
            other = double.Parse(otherAllowanceGTextBox.Text);
            grossSG = (bs + tr + md + hs + other);
            grossSalaryGTextBox.Text = grossSG.ToString();

        }
        private void otherAllowanceGTextBox_TextChanged(object sender, EventArgs e)
        {
            GrossSalaryGCalculation();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            int g = 0;
            GradeManager  aGradeManager=new GradeManager();

            try
            {
                Grade aGrade = new Grade
                {
                    GradeId = Convert.ToDecimal(gradeIdComboBox.Text),
                    Basic = Convert.ToDecimal(basicSalaryGTextBox.Text),
                    TransportAllowance = Convert.ToDecimal(medicalAllowanceGTextBox.Text),
                    MedicalAllowance = Convert.ToDecimal(medicalAllowanceGTextBox.Text),
                    HouseRent = Convert.ToDecimal(houseRentGTextBox.Text),
                    OtherAllowance = Convert.ToDecimal(otherAllowanceGTextBox.Text),
                    GrossGSalary = Convert.ToDecimal(grossSalaryGTextBox.Text)
 
                };
                g = aGradeManager.SaveGrade(aGrade);
                MessageBox.Show("Successfully saved", "Message from Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            catch (FormatException formatException)
            {
                MessageBox.Show("Please Enter Input In Corret Format", formatException.Message);
            }

            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        //private void ClearAll()
        //{
        //    gradeIdComboBox.Text = " ";
        //    basicSalaryGTextBox.Text = string.Empty;

        //}
        //private void NewGradeForm()
        //{
        //    GradeCalculationEntryForm nForm = new GradeCalculationEntryForm();
        //    nForm.Show();
        //}
        private void newButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GradeCalculationEntryForm kgForm=new GradeCalculationEntryForm();
            kgForm.Show();
            UpdateButton.Enabled = false;

        }

        
        private void gotoSalaryButton_Click(object sender, EventArgs e)
        {
           
            
           
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            gGradeGateway=new GradeGateway();
            decimal gradeId = Convert.ToDecimal(gradeIdComboBox.Text);
            grade = gGradeGateway.PopulatGradeById(gradeId);
            
            //saveButton.Enabled = false;

            if (grade.GradeId != Convert.ToDecimal(gradeIdComboBox.Text))
            {
                MessageBox.Show("Grade Id is not found.Please enter correct Id");

            }
            else
            {
                basicSalaryGTextBox.Text = Convert.ToString(grade.Basic);
                transportAllowanceGTextBox.Text = Convert.ToString(grade.TransportAllowance);
                medicalAllowanceGTextBox.Text = Convert.ToString(grade.MedicalAllowance);
                houseRentGTextBox.Text = Convert.ToString(grade.HouseRent);
                otherAllowanceGTextBox.Text = Convert.ToString(grade.OtherAllowance);
                grossSalaryGTextBox.Text = Convert.ToString(grade.GrossGSalary);



            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainUI  aMainUi=new MainUI();
                aMainUi.Show();
        }

        private void goToSalaryButton_Click_1(object sender, EventArgs e)
        {
                   this.Hide();
            SalaryDetailsEntryForm  asForm=new SalaryDetailsEntryForm();
                     asForm.Show();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            
            GradeGateway aGradeGateway=new GradeGateway();
            try
            {
                Grade aGrade = new Grade
                {
                    GradeId = Convert.ToDecimal(gradeIdComboBox.Text),
                    Basic = Convert.ToDecimal(basicSalaryGTextBox.Text),
                    TransportAllowance = Convert.ToDecimal(medicalAllowanceGTextBox.Text),
                    MedicalAllowance = Convert.ToDecimal(medicalAllowanceGTextBox.Text),
                    HouseRent = Convert.ToDecimal(houseRentGTextBox.Text),
                    OtherAllowance = Convert.ToDecimal(otherAllowanceGTextBox.Text),
                    GrossGSalary = Convert.ToDecimal(grossSalaryGTextBox.Text)
 
                };

                aGradeGateway.UpdateGrade(aGrade);
                //MessageBox.Show("Successfully Updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
              
            }
            catch (FormatException formatException)
            {
                MessageBox.Show("Please Enter Input In Corret Format", formatException.Message);
            }

            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
          
        }

        private void Reset()
        {
            gradeIdComboBox.SelectedIndex = -1;
            basicSalaryGTextBox.TextChanged -= basicSalaryGTextBox_TextChanged;
            basicSalaryGTextBox.Clear();
            medicalAllowanceGTextBox.Clear();
            houseRentGTextBox.Clear();
            transportAllowanceGTextBox.Clear();
            otherAllowanceGTextBox.TextChanged -= otherAllowanceGTextBox_TextChanged;
            otherAllowanceGTextBox.Clear();
            grossSalaryGTextBox.Clear();
            basicSalaryGTextBox.TextChanged+=basicSalaryGTextBox_TextChanged;
            otherAllowanceGTextBox.TextChanged += otherAllowanceGTextBox_TextChanged;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label9.Visible = !this.label9.Visible;
            //label9.Location = new Point(label9.Location.X + 5, label9.Location.Y);

            //if (label9.Location.X > this.Width)
            //{
            //    label9.Location = new Point(0 - label9.Width, label9.Location.Y);
            //}
        }

        private void GradeCalculationEntryForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();
            timer2.Interval = 50;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label9.Location = new Point(label9.Location.X - 5, label9.Location.Y);

            if (label9.Location.X <( 0 - label9.Width))
            {
                label9.Location = new Point(0 + label9.Width, label9.Location.Y);
            }
        }
    }
}
