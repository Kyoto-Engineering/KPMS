﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using SalaryCalculationUI.AllReports;
using SalaryCalculationUI.DBGateway;

namespace SalaryCalculationUI.UI
{
    public partial class Claim : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        public decimal amount = 0, takeRemovePric = 0, subAmount = 0, Total = 0, grandTotal=0;
        public int purposeid, employeeid, esId;
        public string sId;

        public Claim()
        {
            InitializeComponent();
            List<Employee2> employees = new List<Employee2>();
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = new SqlCommand(" SELECT        EmployeeName, Designation, Department FROM            Employee where Status ='Active'", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (rdr.Read() == true)
                {
                    employees.Add(new Employee2() { Name = rdr[0].ToString(), Designation = rdr[1].ToString(), Department = rdr[2].ToString() });
                    //dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //for (int i = 0; i < 10; i++)
            //{
            //    employees.Add(new Employee2() { Name = "Name" + i, Designation = "Address" + i, Department = "TelephoneNumber" + i });

            //}

            this.comboBoxWithGrid_WinformsHost1.Employee2s = employees;

            //this.comboBoxWithGrid_WinformsHost1.SelectedIndex = 6;
        }

        public void FillPurpose()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select RTRIM(Purpose) from [dbo].[Purposes]  order by PId";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    PurposecomboBox.Items.Add(rdr[0]);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Claim_Load(object sender, EventArgs e)
        {
            
            sId = MainUI.sid.ToString();
            FillPurpose();
        }

        private void CalculateTotalAmount()
        {
            try
            {
                decimal val1 = 0;
                decimal val2 = 0;
                decimal.TryParse(AmounttextBox.Text, out val1);
                decimal.TryParse(TotaltextBox.Text, out val2);
                decimal V = (val1 + val2);
                TotaltextBox.Text = V.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
           
            comboBoxWithGrid_WinformsHost1.Enabled=false;
            
            if (string.IsNullOrWhiteSpace(PurposecomboBox.Text))
            {
                MessageBox.Show("Please Select Purpose!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(FundRequisitionNotextBox.Text))
            {
                MessageBox.Show("Please enter Fund Requisition Number!", "error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                FundRequisitionNotextBox.Focus();
            }
            else if (string.IsNullOrWhiteSpace(AmounttextBox.Text))
            {
                MessageBox.Show("Please enter Amount!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AmounttextBox.Focus();
            }
            else
            {
                try
                {
                    if (listView1.Items.Count == 0)
                    {
                        ListViewItem lst = new ListViewItem();
                        lst.Text = purposeid.ToString();
                        lst.SubItems.Add(PurposecomboBox.Text);
                        lst.SubItems.Add(FundRequisitionNotextBox.Text);
                        lst.SubItems.Add(DescriptionrichTextBox.Text);
                        lst.SubItems.Add(AmounttextBox.Text);
                        listView1.Items.Add(lst);

                        CalculateTotalAmount();
                        Reset();
                    }
                    else
                    {
                        ListViewItem lst1 = new ListViewItem();
                        lst1.Text = purposeid.ToString();
                        lst1.SubItems.Add(PurposecomboBox.Text);
                        lst1.SubItems.Add(FundRequisitionNotextBox.Text);
                        lst1.SubItems.Add(DescriptionrichTextBox.Text);
                        lst1.SubItems.Add(AmounttextBox.Text);
                        listView1.Items.Add(lst1);

                        CalculateTotalAmount();
                        Reset();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Reset()
        {
            PurposecomboBox.SelectedIndex = -1;
            FundRequisitionNotextBox.Clear();
            DescriptionrichTextBox.Clear();
            AmounttextBox.Clear();
        }

        private void AmounttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(AmounttextBox.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void Removebutton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select List Item First!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
            else
            {
                takeRemovePric = Convert.ToDecimal(listView1.SelectedItems[0].SubItems[4].Text);
                Total = Convert.ToDecimal(TotaltextBox.Text);
                subAmount = Total - takeRemovePric;
                TotaltextBox.Text = subAmount.ToString();


                for (int i = listView1.Items.Count - 1; i >= 0; i--)
                {
                    if (listView1.Items[i].Selected)
                    {
                        listView1.Items[i].Remove();
                    }
                }
            }
        }

        private void Getemployeeid()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT EmployeeId FROM Employee where EmployeeName='" + comboBoxWithGrid_WinformsHost1.SelectedItem.Name + "' and Designation='" + comboBoxWithGrid_WinformsHost1.SelectedItem.Designation + "' and Department='" + comboBoxWithGrid_WinformsHost1.SelectedItem.Department + "'";

                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    employeeid = rdr.GetInt32(0);
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getesId()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string query1 = "insert into EmpSettlement(EmployeeId,S_Id,TotalTakaEmployee) values(@d1,@d2,@d3)" + "SELECT CONVERT(int, SCOPE_IDENTITY())";
                cmd = new SqlCommand(query1, con);
                cmd.Parameters.AddWithValue("@d1", employeeid);
                cmd.Parameters.AddWithValue("@d2", sId);
                cmd.Parameters.AddWithValue("@d3", TotaltextBox.Text);
                esId = (int)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Insertclaim()
        {        
            try
            {
                for (int i = 0; i <= listView1.Items.Count - 1; i++)
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string query1 =
                        "insert into Claims(E_S_Id,P_Id,Description,FundrecoNo,Amount) values(@d1,@d2,@d3,@d4,@d5)" +
                        "SELECT CONVERT(int, SCOPE_IDENTITY())";
                    cmd = new SqlCommand(query1, con);
                    cmd.Parameters.AddWithValue("@d1", esId);
                    cmd.Parameters.AddWithValue("@d2", listView1.Items[i].SubItems[0].Text);
                    cmd.Parameters.AddWithValue("@d3", listView1.Items[i].SubItems[2].Text);
                    cmd.Parameters.AddWithValue("@d4", listView1.Items[i].SubItems[1].Text);
                    cmd.Parameters.AddWithValue("@d5", listView1.Items[i].SubItems[4].Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {
           if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Please Added to List First!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else
           {
               Getemployeeid();
               getesId();
               Insertclaim();
               MessageBox.Show("Submitted Successfully", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
               
               listView1.Items.Clear();
               TotaltextBox.Clear();
               TotaltextBox.Text = 0.ToString();
               comboBoxWithGrid_WinformsHost1.Enabled = true;
           }
            

        }

        private void comboBoxWithGrid_WinformsHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

            
        }

        private void PurposecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT PId from Purposes WHERE Purpose= '" + PurposecomboBox.Text + "'";

                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    purposeid = rdr.GetInt32(0);
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetgrandTotal()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cd = "SELECT TotalTakaEmployee FROM EmpSettlement where S_Id='" + sId + "'";
                cmd = new SqlCommand(cd);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Total = (rdr.GetDecimal(0));

                    grandTotal += Total;
                }
                con.Close();
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cb = "Update Settlement set TotalTaka=@d2 where S_Id='" + sId + "'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d2", grandTotal);
                rdr = cmd.ExecuteReader();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
            
        }

        private void Report()
        {
            ParameterField paramField1 = new ParameterField();


            //creating an object of ParameterFields class
            ParameterFields paramFields1 = new ParameterFields();

            //creating an object of ParameterDiscreteValue class
            ParameterDiscreteValue paramDiscreteValue1 = new ParameterDiscreteValue();

            //set the parameter field name
            paramField1.Name = "id";

            //set the parameter value
            paramDiscreteValue1.Value = sId;

            //add the parameter value in the ParameterField object
            paramField1.CurrentValues.Add(paramDiscreteValue1);

            //add the parameter in the ParameterFields object
            paramFields1.Add(paramField1);
            ReportViewer1 f2 = new ReportViewer1();
            TableLogOnInfos reportLogonInfos = new TableLogOnInfos();
            TableLogOnInfo reportLogonInfo = new TableLogOnInfo();
            ConnectionInfo reportConInfo = new ConnectionInfo();
            Tables tables = default(Tables);
            //	Table table = default(Table);
            var with1 = reportConInfo;
            with1.ServerName = "tcp:KyotoServer,49172";
            with1.DatabaseName = "EmployeeMSDb";
            with1.UserID = "sa";
            with1.Password = "SystemAdministrator";
            ClaimSettelmentReport cr =new ClaimSettelmentReport();
            tables = cr.Database.Tables;
            foreach (Table table in tables)
            {
                reportLogonInfo = table.LogOnInfo;
                reportLogonInfo.ConnectionInfo = reportConInfo;
                table.ApplyLogOnInfo(reportLogonInfo);
            }
            f2.crystalReportViewer1.ParameterFieldInfo = paramFields1;
            f2.crystalReportViewer1.ReportSource = cr;
            this.Visible = false;

            f2.ShowDialog();
            this.Visible = true;   
        }
        private void Claim_FormClosed(object sender, FormClosedEventArgs e)
        {

            GetgrandTotal();
            Report();
            this.Dispose();
            MainUI frrmm = new MainUI();
            frrmm.Show();

        }
    }
}
