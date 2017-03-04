namespace SalaryCalculationUI.LoginUI
{
    partial class frmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            this.UserRegistrationForm = new System.Windows.Forms.GroupBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.designationTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.txtEmail_Address = new System.Windows.Forms.TextBox();
            this.txtContact_no = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.getDataButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.registerInlineButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.UserRegistrationForm.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserRegistrationForm
            // 
            this.UserRegistrationForm.Controls.Add(this.departmentTextBox);
            this.UserRegistrationForm.Controls.Add(this.label8);
            this.UserRegistrationForm.Controls.Add(this.designationTextBox);
            this.UserRegistrationForm.Controls.Add(this.label7);
            this.UserRegistrationForm.Controls.Add(this.button6);
            this.UserRegistrationForm.Controls.Add(this.cmbUserType);
            this.UserRegistrationForm.Controls.Add(this.txtEmail_Address);
            this.UserRegistrationForm.Controls.Add(this.txtContact_no);
            this.UserRegistrationForm.Controls.Add(this.txtName);
            this.UserRegistrationForm.Controls.Add(this.txtPassword);
            this.UserRegistrationForm.Controls.Add(this.txtUsername);
            this.UserRegistrationForm.Controls.Add(this.label6);
            this.UserRegistrationForm.Controls.Add(this.label5);
            this.UserRegistrationForm.Controls.Add(this.label4);
            this.UserRegistrationForm.Controls.Add(this.label3);
            this.UserRegistrationForm.Controls.Add(this.label2);
            this.UserRegistrationForm.Controls.Add(this.label1);
            this.UserRegistrationForm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRegistrationForm.Location = new System.Drawing.Point(12, 7);
            this.UserRegistrationForm.Name = "UserRegistrationForm";
            this.UserRegistrationForm.Size = new System.Drawing.Size(587, 355);
            this.UserRegistrationForm.TabIndex = 0;
            this.UserRegistrationForm.TabStop = false;
            this.UserRegistrationForm.Text = "UserRegistrationForm";
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(119, 231);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(281, 26);
            this.departmentTextBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Department";
            // 
            // designationTextBox
            // 
            this.designationTextBox.Location = new System.Drawing.Point(119, 192);
            this.designationTextBox.Name = "designationTextBox";
            this.designationTextBox.Size = new System.Drawing.Size(281, 26);
            this.designationTextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Designation";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(443, 26);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 26);
            this.button6.TabIndex = 12;
            this.button6.Text = "CheckAvailability";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cmbUserType
            // 
            this.cmbUserType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "HRAdmin",
            "HR",
            "Employee"});
            this.cmbUserType.Location = new System.Drawing.Point(119, 82);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(281, 27);
            this.cmbUserType.TabIndex = 11;
            this.cmbUserType.SelectedIndexChanged += new System.EventHandler(this.cmbUserType_SelectedIndexChanged);
            // 
            // txtEmail_Address
            // 
            this.txtEmail_Address.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail_Address.Location = new System.Drawing.Point(119, 303);
            this.txtEmail_Address.Name = "txtEmail_Address";
            this.txtEmail_Address.Size = new System.Drawing.Size(281, 26);
            this.txtEmail_Address.TabIndex = 10;
            // 
            // txtContact_no
            // 
            this.txtContact_no.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact_no.Location = new System.Drawing.Point(119, 267);
            this.txtContact_no.Name = "txtContact_no";
            this.txtContact_no.Size = new System.Drawing.Size(281, 26);
            this.txtContact_no.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(119, 153);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(281, 26);
            this.txtName.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(119, 117);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(281, 26);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(119, 44);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(281, 26);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "ContactNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserType";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.getDataButton);
            this.groupBox2.Controls.Add(this.updateButton);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.registerInlineButton);
            this.groupBox2.Controls.Add(this.newButton);
            this.groupBox2.Location = new System.Drawing.Point(34, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 63);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // getDataButton
            // 
            this.getDataButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getDataButton.Location = new System.Drawing.Point(403, 18);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(75, 36);
            this.getDataButton.TabIndex = 4;
            this.getDataButton.Text = "GetData";
            this.getDataButton.UseVisualStyleBackColor = true;
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(303, 18);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 36);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(206, 18);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 36);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // registerInlineButton
            // 
            this.registerInlineButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerInlineButton.Location = new System.Drawing.Point(107, 18);
            this.registerInlineButton.Name = "registerInlineButton";
            this.registerInlineButton.Size = new System.Drawing.Size(75, 36);
            this.registerInlineButton.TabIndex = 1;
            this.registerInlineButton.Text = "Register";
            this.registerInlineButton.UseVisualStyleBackColor = true;
            this.registerInlineButton.Click += new System.EventHandler(this.registerInlineButton_Click);
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(14, 19);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(68, 35);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(611, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.UserRegistrationForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistration";
            this.UserRegistrationForm.ResumeLayout(false);
            this.UserRegistrationForm.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserRegistrationForm;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.TextBox txtEmail_Address;
        private System.Windows.Forms.TextBox txtContact_no;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button getDataButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button registerInlineButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox designationTextBox;
        private System.Windows.Forms.Label label7;
    }
}