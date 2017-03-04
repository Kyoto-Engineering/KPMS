namespace SalaryCalculationUI.LoginUI
{
    partial class EmployeeProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeProfileForm));
            this.txtTime = new System.Windows.Forms.TextBox();
            this.dataGridView1Profile = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeWellCome = new System.Windows.Forms.TextBox();
            this.logOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(587, 178);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(151, 20);
            this.txtTime.TabIndex = 0;
            // 
            // dataGridView1Profile
            // 
            this.dataGridView1Profile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Profile.Location = new System.Drawing.Point(5, 204);
            this.dataGridView1Profile.Name = "dataGridView1Profile";
            this.dataGridView1Profile.Size = new System.Drawing.Size(733, 258);
            this.dataGridView1Profile.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(587, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 166);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "WellCome To";
            // 
            // txtEmployeeWellCome
            // 
            this.txtEmployeeWellCome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeWellCome.Location = new System.Drawing.Point(337, 6);
            this.txtEmployeeWellCome.Name = "txtEmployeeWellCome";
            this.txtEmployeeWellCome.ReadOnly = true;
            this.txtEmployeeWellCome.Size = new System.Drawing.Size(126, 13);
            this.txtEmployeeWellCome.TabIndex = 4;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(494, 6);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 23);
            this.logOutButton.TabIndex = 5;
            this.logOutButton.Text = "LogOut";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // EmployeeProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 561);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.txtEmployeeWellCome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1Profile);
            this.Controls.Add(this.txtTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeProfileForm";
            this.Load += new System.EventHandler(this.EmployeeProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.DataGridView dataGridView1Profile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployeeWellCome;
        private System.Windows.Forms.Button logOutButton;
    }
}