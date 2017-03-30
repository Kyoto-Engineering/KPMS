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
using SalaryCalculationUI.AllReports;
using SalaryCalculationUI.DBGateway;
using SalaryCalculationUI.LoginUI;
using SalaryCalculationUI.NReports;

namespace SalaryCalculationUI.UI
{
    public partial class MainUI : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        private SqlDataAdapter sda;
        public int sLinyear,yr;
        public string user_id, referenceNo;
        public Nullable<decimal> aNull;
        public static int sid;
        public MainUI()
        {
            InitializeComponent();
        }

        private void salaryButton_Click(object sender, EventArgs e)
        {
            Salary f2 = new Salary();
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;

        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            dynamic aform = new EmployeeUI();
            this.Visible = false;

            aform.ShowDialog();
            this.Visible = true;
        }

        private void gradeButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dynamic aform = new GradeCalculationEntryForm();
            aform.ShowDialog();
            this.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            dynamic aform = new SalaryDetailsGrid2();
            aform.ShowDialog();
            this.Visible = true;


        }

        private void regButton_Click(object sender, EventArgs e)
        {



            frmRegistration fem = new frmRegistration();
            this.Visible = false;
            fem.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin knw = new frmLogin();
            knw.Show();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLogin afrm = new frmLogin();
            afrm.Show();
        }

        private void Report1Button_Click(object sender, EventArgs e)
        {
            TestReportRecord aRecord = new TestReportRecord();
            aRecord.Show();
            //SalarySheetRecord ssrdRecord=new SalarySheetRecord();
            //ssrdRecord.Show();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dynamic aform = new ReporstUI();
            aform.ShowDialog();
            this.Visible = true;

        }

        private void frmAboutButton_Click(object sender, EventArgs e)
        {
            frmAbout ag = new frmAbout();
            ag.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label2.Visible = !this.label2.Visible;
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            user_id = frmLogin.uId.ToString();
            timer1.Interval = 250;
            timer1.Start();
            timer2.Interval = 450;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.label4.Visible = !this.label4.Visible;
        }


        private void GetSId()
        {
            con = new SqlConnection(cs.DBConn);
            con.Open();
            string cty4 = "SELECT (Settlement.S_Id) FROM Settlement";
            cmd = new SqlCommand(cty4);
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                sid = (rdr.GetInt32(0));

            }
            con.Close();

        }



        private void NewSettlementbutton_Click(object sender, EventArgs e)
        {
            SaveInfo();
            this.Dispose();
            Claim cm = new Claim();
            cm.Show();

        }

        private void SaveInfo()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qr1 = "SELECT (Settlement.Year) FROM Settlement where Year='" + DateTime.Now.Year + "'";
                cmd = new SqlCommand(qr1, con);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    yr = (rdr.GetInt32(0)); 
                }

                if (yr == DateTime.Now.Year)
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string qr2 = "SELECT MAX(Settlement.SLinYear) FROM Settlement where Year='" + DateTime.Now.Year +
                                 "'";
                    cmd = new SqlCommand(qr2, con);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        sLinyear = (rdr.GetInt32(0));
                        sLinyear = sLinyear + 1;
                        referenceNo = "HR-" + user_id + "/BA-PCS/" + DateTime.Now.Year % 100 + "-" + sLinyear + "";
                    }
                }
                else
                {
                    sLinyear = 1;
                    referenceNo = "HR-" + user_id + "/BA-PCS/" + DateTime.Now.Year % 100 + "-" + sLinyear + "";
                }

                if (DateTime.Now.Year==yr)
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string query = "insert into Settlement(UserId,SDate,Year,SLinYear,RefNo,TotalTaka) values(@d1,@d2,@d3,@d4,@d5,@d6)" + "SELECT CONVERT(int, SCOPE_IDENTITY())";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@d1", user_id);
                    cmd.Parameters.AddWithValue("@d2", DateTime.Now);
                    cmd.Parameters.AddWithValue("@d3", yr);
                    cmd.Parameters.AddWithValue("@d4", sLinyear);
                    cmd.Parameters.AddWithValue("@d5", referenceNo);
                    //cmd.Parameters.AddWithValue("@d6", (object)aNull ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@d6", "0");
                    sid = (int)cmd.ExecuteScalar();
                    con.Close();
                }
                else
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string query = "insert into Settlement(UserId,SDate,Year,SLinYear,RefNo,TotalTaka) values(@d1,@d2,@d3,@d4,@d5,@d6)" + "SELECT CONVERT(int, SCOPE_IDENTITY())";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@d1", user_id);
                    cmd.Parameters.AddWithValue("@d2", DateTime.Now);
                    cmd.Parameters.AddWithValue("@d3", DateTime.Now.Year);
                    cmd.Parameters.AddWithValue("@d4", sLinyear);
                    cmd.Parameters.AddWithValue("@d5", referenceNo);
                    //cmd.Parameters.AddWithValue("@d6", (object)aNull ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@d6", "0");
                    sid = (int)cmd.ExecuteScalar();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
