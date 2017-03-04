namespace SalaryCalculationUI.UI
{
    partial class DisplayingSalaryInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayingSalaryInfo));
            this.SalaryDetails = new System.Windows.Forms.GroupBox();
            this.getDataButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.salaryDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportAllowanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalAllowanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseRentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherAllowanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netGrossSalaryAfterTaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalWorkingDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perdaySalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayPayableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unpaidLeaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.givenAnnualLeaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHAttendenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveWithPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deductionFromAnnualLeaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advancePaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deductionForLeaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adjustmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDeductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previousDuesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAdditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netPayableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeMSDbDataSet = new SalaryCalculationUI.EmployeeMSDbDataSet();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salaryTableAdapter = new SalaryCalculationUI.EmployeeMSDbDataSetTableAdapters.SalaryTableAdapter();
            this.SalaryDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeMSDbDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalaryDetails
            // 
            this.SalaryDetails.Controls.Add(this.getDataButton);
            this.SalaryDetails.Controls.Add(this.showButton);
            this.SalaryDetails.Location = new System.Drawing.Point(12, 12);
            this.SalaryDetails.Name = "SalaryDetails";
            this.SalaryDetails.Size = new System.Drawing.Size(864, 113);
            this.SalaryDetails.TabIndex = 0;
            this.SalaryDetails.TabStop = false;
            this.SalaryDetails.Text = "groupBox1";
            this.SalaryDetails.Enter += new System.EventHandler(this.SalaryDetails_Enter);
            // 
            // getDataButton
            // 
            this.getDataButton.Location = new System.Drawing.Point(299, 67);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(75, 23);
            this.getDataButton.TabIndex = 2;
            this.getDataButton.Text = "GetData";
            this.getDataButton.UseVisualStyleBackColor = true;
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(116, 67);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(124, 23);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.salaryDetailsDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(878, 398);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // salaryDetailsDataGridView
            // 
            this.salaryDetailsDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salaryDetailsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.salaryDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salaryDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn,
            this.accountNoDataGridViewTextBoxColumn,
            this.monthsDataGridViewTextBoxColumn,
            this.gradeIdDataGridViewTextBoxColumn,
            this.basicDataGridViewTextBoxColumn,
            this.transportAllowanceDataGridViewTextBoxColumn,
            this.medicalAllowanceDataGridViewTextBoxColumn,
            this.houseRentDataGridViewTextBoxColumn,
            this.otherAllowanceDataGridViewTextBoxColumn,
            this.grossSalaryDataGridViewTextBoxColumn,
            this.taxDataGridViewTextBoxColumn,
            this.netGrossSalaryAfterTaxDataGridViewTextBoxColumn,
            this.totalWorkingDayDataGridViewTextBoxColumn,
            this.perdaySalaryDataGridViewTextBoxColumn,
            this.dayPayableDataGridViewTextBoxColumn,
            this.unpaidLeaveDataGridViewTextBoxColumn,
            this.givenAnnualLeaveDataGridViewTextBoxColumn,
            this.pHAttendenceDataGridViewTextBoxColumn,
            this.leaveWithPayDataGridViewTextBoxColumn,
            this.fineDataGridViewTextBoxColumn,
            this.deductionFromAnnualLeaveDataGridViewTextBoxColumn,
            this.advancePaidDataGridViewTextBoxColumn,
            this.deductionForLeaveDataGridViewTextBoxColumn,
            this.adjustmentDataGridViewTextBoxColumn,
            this.totalDeductionDataGridViewTextBoxColumn,
            this.previousDuesDataGridViewTextBoxColumn,
            this.totalAdditionDataGridViewTextBoxColumn,
            this.netPayableDataGridViewTextBoxColumn});
            this.salaryDetailsDataGridView.DataSource = this.salaryBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salaryDetailsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.salaryDetailsDataGridView.Location = new System.Drawing.Point(6, 19);
            this.salaryDetailsDataGridView.Name = "salaryDetailsDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salaryDetailsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.salaryDetailsDataGridView.Size = new System.Drawing.Size(866, 367);
            this.salaryDetailsDataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            // 
            // accountNoDataGridViewTextBoxColumn
            // 
            this.accountNoDataGridViewTextBoxColumn.DataPropertyName = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn.HeaderText = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn.Name = "accountNoDataGridViewTextBoxColumn";
            // 
            // monthsDataGridViewTextBoxColumn
            // 
            this.monthsDataGridViewTextBoxColumn.DataPropertyName = "Months";
            this.monthsDataGridViewTextBoxColumn.HeaderText = "Months";
            this.monthsDataGridViewTextBoxColumn.Name = "monthsDataGridViewTextBoxColumn";
            // 
            // gradeIdDataGridViewTextBoxColumn
            // 
            this.gradeIdDataGridViewTextBoxColumn.DataPropertyName = "GradeId";
            this.gradeIdDataGridViewTextBoxColumn.HeaderText = "GradeId";
            this.gradeIdDataGridViewTextBoxColumn.Name = "gradeIdDataGridViewTextBoxColumn";
            // 
            // basicDataGridViewTextBoxColumn
            // 
            this.basicDataGridViewTextBoxColumn.DataPropertyName = "Basic";
            this.basicDataGridViewTextBoxColumn.HeaderText = "Basic";
            this.basicDataGridViewTextBoxColumn.Name = "basicDataGridViewTextBoxColumn";
            // 
            // transportAllowanceDataGridViewTextBoxColumn
            // 
            this.transportAllowanceDataGridViewTextBoxColumn.DataPropertyName = "TransportAllowance";
            this.transportAllowanceDataGridViewTextBoxColumn.HeaderText = "TransportAllowance";
            this.transportAllowanceDataGridViewTextBoxColumn.Name = "transportAllowanceDataGridViewTextBoxColumn";
            // 
            // medicalAllowanceDataGridViewTextBoxColumn
            // 
            this.medicalAllowanceDataGridViewTextBoxColumn.DataPropertyName = "MedicalAllowance";
            this.medicalAllowanceDataGridViewTextBoxColumn.HeaderText = "MedicalAllowance";
            this.medicalAllowanceDataGridViewTextBoxColumn.Name = "medicalAllowanceDataGridViewTextBoxColumn";
            // 
            // houseRentDataGridViewTextBoxColumn
            // 
            this.houseRentDataGridViewTextBoxColumn.DataPropertyName = "HouseRent";
            this.houseRentDataGridViewTextBoxColumn.HeaderText = "HouseRent";
            this.houseRentDataGridViewTextBoxColumn.Name = "houseRentDataGridViewTextBoxColumn";
            // 
            // otherAllowanceDataGridViewTextBoxColumn
            // 
            this.otherAllowanceDataGridViewTextBoxColumn.DataPropertyName = "OtherAllowance";
            this.otherAllowanceDataGridViewTextBoxColumn.HeaderText = "OtherAllowance";
            this.otherAllowanceDataGridViewTextBoxColumn.Name = "otherAllowanceDataGridViewTextBoxColumn";
            // 
            // grossSalaryDataGridViewTextBoxColumn
            // 
            this.grossSalaryDataGridViewTextBoxColumn.DataPropertyName = "GrossSalary";
            this.grossSalaryDataGridViewTextBoxColumn.HeaderText = "GrossSalary";
            this.grossSalaryDataGridViewTextBoxColumn.Name = "grossSalaryDataGridViewTextBoxColumn";
            // 
            // taxDataGridViewTextBoxColumn
            // 
            this.taxDataGridViewTextBoxColumn.DataPropertyName = "Tax";
            this.taxDataGridViewTextBoxColumn.HeaderText = "Tax";
            this.taxDataGridViewTextBoxColumn.Name = "taxDataGridViewTextBoxColumn";
            // 
            // netGrossSalaryAfterTaxDataGridViewTextBoxColumn
            // 
            this.netGrossSalaryAfterTaxDataGridViewTextBoxColumn.DataPropertyName = "NetGrossSalaryAfterTax";
            this.netGrossSalaryAfterTaxDataGridViewTextBoxColumn.HeaderText = "NetGrossSalaryAfterTax";
            this.netGrossSalaryAfterTaxDataGridViewTextBoxColumn.Name = "netGrossSalaryAfterTaxDataGridViewTextBoxColumn";
            // 
            // totalWorkingDayDataGridViewTextBoxColumn
            // 
            this.totalWorkingDayDataGridViewTextBoxColumn.DataPropertyName = "TotalWorkingDay";
            this.totalWorkingDayDataGridViewTextBoxColumn.HeaderText = "TotalWorkingDay";
            this.totalWorkingDayDataGridViewTextBoxColumn.Name = "totalWorkingDayDataGridViewTextBoxColumn";
            // 
            // perdaySalaryDataGridViewTextBoxColumn
            // 
            this.perdaySalaryDataGridViewTextBoxColumn.DataPropertyName = "PerdaySalary";
            this.perdaySalaryDataGridViewTextBoxColumn.HeaderText = "PerdaySalary";
            this.perdaySalaryDataGridViewTextBoxColumn.Name = "perdaySalaryDataGridViewTextBoxColumn";
            // 
            // dayPayableDataGridViewTextBoxColumn
            // 
            this.dayPayableDataGridViewTextBoxColumn.DataPropertyName = "DayPayable";
            this.dayPayableDataGridViewTextBoxColumn.HeaderText = "DayPayable";
            this.dayPayableDataGridViewTextBoxColumn.Name = "dayPayableDataGridViewTextBoxColumn";
            // 
            // unpaidLeaveDataGridViewTextBoxColumn
            // 
            this.unpaidLeaveDataGridViewTextBoxColumn.DataPropertyName = "UnpaidLeave";
            this.unpaidLeaveDataGridViewTextBoxColumn.HeaderText = "UnpaidLeave";
            this.unpaidLeaveDataGridViewTextBoxColumn.Name = "unpaidLeaveDataGridViewTextBoxColumn";
            // 
            // givenAnnualLeaveDataGridViewTextBoxColumn
            // 
            this.givenAnnualLeaveDataGridViewTextBoxColumn.DataPropertyName = "GivenAnnualLeave";
            this.givenAnnualLeaveDataGridViewTextBoxColumn.HeaderText = "GivenAnnualLeave";
            this.givenAnnualLeaveDataGridViewTextBoxColumn.Name = "givenAnnualLeaveDataGridViewTextBoxColumn";
            // 
            // pHAttendenceDataGridViewTextBoxColumn
            // 
            this.pHAttendenceDataGridViewTextBoxColumn.DataPropertyName = "PHAttendence";
            this.pHAttendenceDataGridViewTextBoxColumn.HeaderText = "PHAttendence";
            this.pHAttendenceDataGridViewTextBoxColumn.Name = "pHAttendenceDataGridViewTextBoxColumn";
            // 
            // leaveWithPayDataGridViewTextBoxColumn
            // 
            this.leaveWithPayDataGridViewTextBoxColumn.DataPropertyName = "LeaveWithPay";
            this.leaveWithPayDataGridViewTextBoxColumn.HeaderText = "LeaveWithPay";
            this.leaveWithPayDataGridViewTextBoxColumn.Name = "leaveWithPayDataGridViewTextBoxColumn";
            // 
            // fineDataGridViewTextBoxColumn
            // 
            this.fineDataGridViewTextBoxColumn.DataPropertyName = "Fine";
            this.fineDataGridViewTextBoxColumn.HeaderText = "Fine";
            this.fineDataGridViewTextBoxColumn.Name = "fineDataGridViewTextBoxColumn";
            // 
            // deductionFromAnnualLeaveDataGridViewTextBoxColumn
            // 
            this.deductionFromAnnualLeaveDataGridViewTextBoxColumn.DataPropertyName = "DeductionFromAnnualLeave";
            this.deductionFromAnnualLeaveDataGridViewTextBoxColumn.HeaderText = "DeductionFromAnnualLeave";
            this.deductionFromAnnualLeaveDataGridViewTextBoxColumn.Name = "deductionFromAnnualLeaveDataGridViewTextBoxColumn";
            // 
            // advancePaidDataGridViewTextBoxColumn
            // 
            this.advancePaidDataGridViewTextBoxColumn.DataPropertyName = "AdvancePaid";
            this.advancePaidDataGridViewTextBoxColumn.HeaderText = "AdvancePaid";
            this.advancePaidDataGridViewTextBoxColumn.Name = "advancePaidDataGridViewTextBoxColumn";
            // 
            // deductionForLeaveDataGridViewTextBoxColumn
            // 
            this.deductionForLeaveDataGridViewTextBoxColumn.DataPropertyName = "DeductionForLeave";
            this.deductionForLeaveDataGridViewTextBoxColumn.HeaderText = "DeductionForLeave";
            this.deductionForLeaveDataGridViewTextBoxColumn.Name = "deductionForLeaveDataGridViewTextBoxColumn";
            // 
            // adjustmentDataGridViewTextBoxColumn
            // 
            this.adjustmentDataGridViewTextBoxColumn.DataPropertyName = "Adjustment";
            this.adjustmentDataGridViewTextBoxColumn.HeaderText = "Adjustment";
            this.adjustmentDataGridViewTextBoxColumn.Name = "adjustmentDataGridViewTextBoxColumn";
            // 
            // totalDeductionDataGridViewTextBoxColumn
            // 
            this.totalDeductionDataGridViewTextBoxColumn.DataPropertyName = "TotalDeduction";
            this.totalDeductionDataGridViewTextBoxColumn.HeaderText = "TotalDeduction";
            this.totalDeductionDataGridViewTextBoxColumn.Name = "totalDeductionDataGridViewTextBoxColumn";
            // 
            // previousDuesDataGridViewTextBoxColumn
            // 
            this.previousDuesDataGridViewTextBoxColumn.DataPropertyName = "PreviousDues";
            this.previousDuesDataGridViewTextBoxColumn.HeaderText = "PreviousDues";
            this.previousDuesDataGridViewTextBoxColumn.Name = "previousDuesDataGridViewTextBoxColumn";
            // 
            // totalAdditionDataGridViewTextBoxColumn
            // 
            this.totalAdditionDataGridViewTextBoxColumn.DataPropertyName = "TotalAddition";
            this.totalAdditionDataGridViewTextBoxColumn.HeaderText = "TotalAddition";
            this.totalAdditionDataGridViewTextBoxColumn.Name = "totalAdditionDataGridViewTextBoxColumn";
            // 
            // netPayableDataGridViewTextBoxColumn
            // 
            this.netPayableDataGridViewTextBoxColumn.DataPropertyName = "NetPayable";
            this.netPayableDataGridViewTextBoxColumn.HeaderText = "NetPayable";
            this.netPayableDataGridViewTextBoxColumn.Name = "netPayableDataGridViewTextBoxColumn";
            // 
            // salaryBindingSource
            // 
            this.salaryBindingSource.DataMember = "Salary";
            this.salaryBindingSource.DataSource = this.EmployeeMSDbDataSet;
            // 
            // EmployeeMSDbDataSet
            // 
            this.EmployeeMSDbDataSet.DataSetName = "EmployeeMSDbDataSet";
            this.EmployeeMSDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(908, 25);
            this.fillByToolStrip.TabIndex = 2;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // salaryTableAdapter
            // 
            this.salaryTableAdapter.ClearBeforeFill = true;
            // 
            // DisplayingSalaryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 529);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.SalaryDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplayingSalaryInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayingSalaryInfo";
            this.Load += new System.EventHandler(this.DisplayingSalaryInfo_Load);
            this.SalaryDetails.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salaryDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeMSDbDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SalaryDetails;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView salaryDetailsDataGridView;
        private EmployeeMSDbDataSet EmployeeMSDbDataSet;
        private System.Windows.Forms.BindingSource salaryBindingSource;
        private EmployeeMSDbDataSetTableAdapters.SalaryTableAdapter salaryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportAllowanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicalAllowanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseRentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherAllowanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netGrossSalaryAfterTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalWorkingDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perdaySalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayPayableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unpaidLeaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn givenAnnualLeaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHAttendenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveWithPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductionFromAnnualLeaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn advancePaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductionForLeaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adjustmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDeductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn previousDuesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAdditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netPayableDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button getDataButton;
    }
}