using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryCalculationUI.DBGateway;

namespace SalaryCalculationUI.LoginUI
{
    public partial class Recoverypassword : Form
    {
        ConnectionString cs=new ConnectionString();
        public Recoverypassword()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Enter your email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            try
            {
                Cursor = Cursors.WaitCursor;
               // timer1.Enabled = true;
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(cs.DBConn);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Password FROM Registration Where Email = '" + txtEmail.Text + "'", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MailMessage Msg = new MailMessage();
                    // Sender e-mail address.
                    Msg.From = new MailAddress("siddiqueiciu@gmail.com");
                    // Recipient e-mail address.
                    Msg.To.Add(txtEmail.Text);
                    Msg.Subject = "Your Password Details";
                    Msg.Body = "Your Password: " + Convert.ToString(ds.Tables[0].Rows[0]["Password"]) + "";
                    Msg.IsBodyHtml = true;
                    // your remote SMTP server IP.
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    //smtp.Port = 3856;
                    //smtp.Port = 465;
                    smtp.Credentials = new System.Net.NetworkCredential("siddiqueiciu@gmail.com", "abcd");
                    smtp.EnableSsl = true;
                    smtp.Send(Msg);
                    MessageBox.Show(("Password Successfully sent " + ("\r\n" + "Please check your mail")), "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    //this.Hide();
                    frmLogin LoginForm1 = new frmLogin();
                    this.Visible = false;
                    LoginForm1.ShowDialog();
                    this.Visible = true;
                    //LoginForm1.txtUserName.Text = "";
                    //LoginForm1.txtPassword.Text = "";
                    //LoginForm1.ProgressBar1.Visible = false;
                    //LoginForm1.txtUserName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Recoverypassword_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }
    }
}
