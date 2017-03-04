namespace SalaryCalculationUI.UI
{
    partial class MainUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.salaryButton = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.gradeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.frmAboutButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.regButton = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUser2 = new System.Windows.Forms.TextBox();
            this.logOutButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kyoto Engineering And Automation Ltd.";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(509, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "WellCome To";
            // 
            // salaryButton
            // 
            this.salaryButton.BackColor = System.Drawing.Color.SeaShell;
            this.salaryButton.Location = new System.Drawing.Point(20, 92);
            this.salaryButton.Margin = new System.Windows.Forms.Padding(4);
            this.salaryButton.Name = "salaryButton";
            this.salaryButton.Size = new System.Drawing.Size(94, 58);
            this.salaryButton.TabIndex = 0;
            this.salaryButton.Text = "Salary";
            this.salaryButton.UseVisualStyleBackColor = false;
            this.salaryButton.Click += new System.EventHandler(this.salaryButton_Click);
            // 
            // employeeButton
            // 
            this.employeeButton.BackColor = System.Drawing.Color.Linen;
            this.employeeButton.Location = new System.Drawing.Point(20, 24);
            this.employeeButton.Margin = new System.Windows.Forms.Padding(4);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(94, 50);
            this.employeeButton.TabIndex = 1;
            this.employeeButton.Text = "Employee";
            this.employeeButton.UseVisualStyleBackColor = false;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // gradeButton
            // 
            this.gradeButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.gradeButton.Location = new System.Drawing.Point(20, 167);
            this.gradeButton.Name = "gradeButton";
            this.gradeButton.Size = new System.Drawing.Size(94, 59);
            this.gradeButton.TabIndex = 5;
            this.gradeButton.Text = "Grade";
            this.gradeButton.UseVisualStyleBackColor = false;
            this.gradeButton.Click += new System.EventHandler(this.gradeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.frmAboutButton);
            this.groupBox1.Controls.Add(this.reportButton);
            this.groupBox1.Controls.Add(this.regButton);
            this.groupBox1.Controls.Add(this.salaryButton);
            this.groupBox1.Controls.Add(this.employeeButton);
            this.groupBox1.Controls.Add(this.gradeButton);
            this.groupBox1.Location = new System.Drawing.Point(25, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 590);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // frmAboutButton
            // 
            this.frmAboutButton.Location = new System.Drawing.Point(6, 489);
            this.frmAboutButton.Name = "frmAboutButton";
            this.frmAboutButton.Size = new System.Drawing.Size(117, 57);
            this.frmAboutButton.TabIndex = 10;
            this.frmAboutButton.Text = "About";
            this.frmAboutButton.UseVisualStyleBackColor = true;
            this.frmAboutButton.Click += new System.EventHandler(this.frmAboutButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.reportButton.Location = new System.Drawing.Point(14, 309);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(100, 62);
            this.reportButton.TabIndex = 9;
            this.reportButton.Text = "Reports";
            this.reportButton.UseVisualStyleBackColor = false;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // regButton
            // 
            this.regButton.BackColor = System.Drawing.Color.Teal;
            this.regButton.ForeColor = System.Drawing.SystemColors.Control;
            this.regButton.Location = new System.Drawing.Point(14, 232);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(100, 52);
            this.regButton.TabIndex = 8;
            this.regButton.Text = "Registration";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.HideSelection = false;
            this.lblUser.Location = new System.Drawing.Point(243, 720);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 17);
            this.lblUser.TabIndex = 7;
            this.lblUser.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 713);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Logged In As:";
            // 
            // lblUser2
            // 
            this.lblUser2.Location = new System.Drawing.Point(102, 713);
            this.lblUser2.Name = "lblUser2";
            this.lblUser2.Size = new System.Drawing.Size(100, 24);
            this.lblUser2.TabIndex = 10;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(1066, 0);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 23);
            this.logOutButton.TabIndex = 11;
            this.logOutButton.Text = "LogOut";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(347, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(412, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "People Management System";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1153, 741);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUser2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainUI";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button salaryButton;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Button gradeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lblUser;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lblUser2;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button frmAboutButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer2;
    }
}