namespace SalaryCalculationUI.UI
{
    partial class Claim
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
            this.Addbutton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FundRequisitionNotextBox = new System.Windows.Forms.TextBox();
            this.AmounttextBox = new System.Windows.Forms.TextBox();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.PurposecomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DescriptionrichTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Removebutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Submitbutton = new System.Windows.Forms.Button();
            this.comboBoxWithGrid_WinformsHost1 = new SalaryCalculationUI.ComboBoxWithGrid_WinformsHost();
            this.SuspendLayout();
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(312, 228);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 2;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Location = new System.Drawing.Point(31, 271);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(449, 97);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PurposeId";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Purpose";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fund Requisition No";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FundRequisitionNotextBox
            // 
            this.FundRequisitionNotextBox.Location = new System.Drawing.Point(206, 146);
            this.FundRequisitionNotextBox.Name = "FundRequisitionNotextBox";
            this.FundRequisitionNotextBox.Size = new System.Drawing.Size(100, 20);
            this.FundRequisitionNotextBox.TabIndex = 4;
            // 
            // AmounttextBox
            // 
            this.AmounttextBox.Location = new System.Drawing.Point(206, 228);
            this.AmounttextBox.Name = "AmounttextBox";
            this.AmounttextBox.Size = new System.Drawing.Size(100, 20);
            this.AmounttextBox.TabIndex = 6;
            this.AmounttextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmounttextBox_KeyPress);
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(380, 374);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(100, 20);
            this.TotaltextBox.TabIndex = 7;
            // 
            // PurposecomboBox
            // 
            this.PurposecomboBox.FormattingEnabled = true;
            this.PurposecomboBox.Location = new System.Drawing.Point(206, 109);
            this.PurposecomboBox.Name = "PurposecomboBox";
            this.PurposecomboBox.Size = new System.Drawing.Size(121, 21);
            this.PurposecomboBox.TabIndex = 8;
            this.PurposecomboBox.SelectedIndexChanged += new System.EventHandler(this.PurposecomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Emlpoyee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Purpouse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Claims";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fund Requisition No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Description";
            // 
            // DescriptionrichTextBox
            // 
            this.DescriptionrichTextBox.Location = new System.Drawing.Point(206, 172);
            this.DescriptionrichTextBox.Name = "DescriptionrichTextBox";
            this.DescriptionrichTextBox.Size = new System.Drawing.Size(172, 50);
            this.DescriptionrichTextBox.TabIndex = 14;
            this.DescriptionrichTextBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Amount";
            // 
            // Removebutton
            // 
            this.Removebutton.Location = new System.Drawing.Point(393, 228);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(75, 23);
            this.Removebutton.TabIndex = 16;
            this.Removebutton.Text = "Remove";
            this.Removebutton.UseVisualStyleBackColor = true;
            this.Removebutton.Click += new System.EventHandler(this.Removebutton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total";
            // 
            // Submitbutton
            // 
            this.Submitbutton.Location = new System.Drawing.Point(541, 375);
            this.Submitbutton.Name = "Submitbutton";
            this.Submitbutton.Size = new System.Drawing.Size(75, 23);
            this.Submitbutton.TabIndex = 18;
            this.Submitbutton.Text = "Submit";
            this.Submitbutton.UseVisualStyleBackColor = true;
            this.Submitbutton.Click += new System.EventHandler(this.Submitbutton_Click);
            // 
            // comboBoxWithGrid_WinformsHost1
            // 
            this.comboBoxWithGrid_WinformsHost1.Employee2s = null;
            this.comboBoxWithGrid_WinformsHost1.Location = new System.Drawing.Point(195, 48);
            this.comboBoxWithGrid_WinformsHost1.Name = "comboBoxWithGrid_WinformsHost1";
            this.comboBoxWithGrid_WinformsHost1.SelectedIndex = -1;
            this.comboBoxWithGrid_WinformsHost1.SelectedItem = null;
            this.comboBoxWithGrid_WinformsHost1.Size = new System.Drawing.Size(398, 40);
            this.comboBoxWithGrid_WinformsHost1.TabIndex = 1;
            this.comboBoxWithGrid_WinformsHost1.Text = "comboBoxWithGrid_WinformsHost1";
            this.comboBoxWithGrid_WinformsHost1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.comboBoxWithGrid_WinformsHost1_ChildChanged);
            // 
            // Claim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 469);
            this.Controls.Add(this.Submitbutton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Removebutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DescriptionrichTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PurposecomboBox);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.AmounttextBox);
            this.Controls.Add(this.FundRequisitionNotextBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.comboBoxWithGrid_WinformsHost1);
            this.Name = "Claim";
            this.Text = "Personal Claim & Settlement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Claim_FormClosed);
            this.Load += new System.EventHandler(this.Claim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBoxWithGrid_WinformsHost comboBoxWithGrid_WinformsHost1;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox FundRequisitionNotextBox;
        private System.Windows.Forms.TextBox AmounttextBox;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.ComboBox PurposecomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox DescriptionrichTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Removebutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Submitbutton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;

    }
}