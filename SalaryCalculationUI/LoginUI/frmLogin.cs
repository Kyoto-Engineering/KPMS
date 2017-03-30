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
using SalaryCalculationUI.DBGateway;
using SalaryCalculationUI.UI;

namespace SalaryCalculationUI.LoginUI
{
    public partial class frmLogin : Form
    {
        ProgressBar ProgressBar1=new ProgressBar();
        ConnectionString cs = new ConnectionString();
        SqlDataReader rdr = null;
        SqlConnection con = null;
        SqlCommand cmd = null;
        public static int uId;
        DataTable dt = new DataTable();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                          //this.Hide();
            frmHRRegistration afRegistration=new frmHRRegistration();
            this.Visible = false;
            afRegistration.ShowDialog();
            this.Visible = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void oKButton_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs.DBConn);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("SELECT Username,password FROM Registration WHERE Username = @username AND password = @UserPassword", myConnection);
                SqlParameter uName = new SqlParameter("@username", SqlDbType.VarChar);
                SqlParameter uPassword = new SqlParameter("@UserPassword", SqlDbType.VarChar);
                uName.Value = txtUserName.Text;
                uPassword.Value = txtPassword.Text;
                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);

                myCommand.Connection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.Read() == true)
                {
                    int i;
                    ProgressBar1.Visible = true;
                    ProgressBar1.Maximum = 5000;
                    //ProgressBar1.Maximum = 5;
                    ProgressBar1.Minimum = 0;
                    ProgressBar1.Value = 4;
                    ProgressBar1.Step = 1;

                    for (i = 0; i <= 5000; i++)
                    {
                        ProgressBar1.PerformStep();
                    }
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ct = "select usertype,UserId from Registration where Username='" + txtUserName.Text + "' and Password='" + txtPassword.Text + "'";
                    cmd = new SqlCommand(ct);
                    cmd.Connection = con;
                    rdr = cmd.ExecuteReader();
                   if (rdr.Read())
                   {
                       txtUserType.Text = (rdr.GetString(0));
                       uId = (rdr.GetInt32(1));
                    }
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }

                    if (txtUserType.Text.Trim() == "HRAdmin")
                    {
                       //this.Hide();
                       MainUI frm = new MainUI();
                        this.Visible = false;
                        frm.ShowDialog();
                        this.Visible =false;
                        txtUserName.Clear();
                        txtPassword.Clear();
                        txtUserName.Focus();
                        // frm.lblUser.Text = txtUserName.Text;
                    }
                   if (txtUserType.Text.Trim() == "HR")
                   {
                       //this.Hide();
                       OnlyUIForHR frm = new OnlyUIForHR();
                       this.Visible = false;
                       frm.ShowDialog();
                       this.Visible = true;
                       txtUserName.Clear();
                       txtPassword.Clear();
                       txtUserName.Focus();
                       // frm.lblUser2.Text = txtUserName.Text;
                   }
                   if (txtUserType.Text.Trim() == "Employee")
                    {
                       // this.Hide();
                        SaveInTime();

                       EmployeeProfileForm   pfomForm=new EmployeeProfileForm();
                       this.Visible = false;
                        pfomForm.ShowDialog();
                        this.Visible = true;
                        txtUserName.Clear();
                        txtPassword.Clear();
                        txtUserName.Focus();


                    }
                }


                else
                {
                    MessageBox.Show("Login is Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();

                }
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ChangePassword cnp=new ChangePassword();
            this.Visible = false;
            cnp.ShowDialog();
            this.Visible = true;
        }

        private void SaveInTime()
        {
            con = new SqlConnection(cs.DBConn);
            con.Open();

            string cb = "insert into Attendence(InTime,CurrentDate) VALUES ('" + System.DateTime.Now+ "','" + System.DateTime.Now + "')";

            cmd = new SqlCommand(cb);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
           // MessageBox.Show("Successfully Registered", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Recoverypassword  rcv=new Recoverypassword();
            this.Visible = false;
            rcv.ShowDialog();
            this.Visible = true;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                oKButton_Click(this, new EventArgs());
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
