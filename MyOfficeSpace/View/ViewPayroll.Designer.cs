namespace MyOfficeSpace.View
{
    partial class ViewPayroll
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.payrollNumbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountantNumbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myOfficeSpaceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.my_Office_SpaceDataSet = new MyOfficeSpace.My_Office_SpaceDataSet();
            this.payrollTableAdapter = new MyOfficeSpace.My_Office_SpaceDataSetTableAdapters.PayrollTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myOfficeSpaceDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_Office_SpaceDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.payrollNumbDataGridViewTextBoxColumn,
            this.employeeSSNDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.accountantNumbDataGridViewTextBoxColumn,
            this.approvalIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.payrollBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(21, 34);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(916, 154);
            this.dataGridView2.TabIndex = 42;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // payrollNumbDataGridViewTextBoxColumn
            // 
            this.payrollNumbDataGridViewTextBoxColumn.DataPropertyName = "Payroll_Numb";
            this.payrollNumbDataGridViewTextBoxColumn.HeaderText = "Payroll Number";
            this.payrollNumbDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payrollNumbDataGridViewTextBoxColumn.Name = "payrollNumbDataGridViewTextBoxColumn";
            this.payrollNumbDataGridViewTextBoxColumn.ReadOnly = true;
            this.payrollNumbDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeSSNDataGridViewTextBoxColumn
            // 
            this.employeeSSNDataGridViewTextBoxColumn.DataPropertyName = "Employee_SSN";
            this.employeeSSNDataGridViewTextBoxColumn.HeaderText = "Employee SSN";
            this.employeeSSNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeSSNDataGridViewTextBoxColumn.Name = "employeeSSNDataGridViewTextBoxColumn";
            this.employeeSSNDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeSSNDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 80;
            // 
            // accountantNumbDataGridViewTextBoxColumn
            // 
            this.accountantNumbDataGridViewTextBoxColumn.DataPropertyName = "Accountant_Numb";
            this.accountantNumbDataGridViewTextBoxColumn.HeaderText = "Accountant Number";
            this.accountantNumbDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accountantNumbDataGridViewTextBoxColumn.Name = "accountantNumbDataGridViewTextBoxColumn";
            this.accountantNumbDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountantNumbDataGridViewTextBoxColumn.Width = 80;
            // 
            // approvalIDDataGridViewTextBoxColumn
            // 
            this.approvalIDDataGridViewTextBoxColumn.DataPropertyName = "Approval_ID";
            this.approvalIDDataGridViewTextBoxColumn.HeaderText = "Approval ID";
            this.approvalIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.approvalIDDataGridViewTextBoxColumn.Name = "approvalIDDataGridViewTextBoxColumn";
            this.approvalIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.approvalIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // payrollBindingSource
            // 
            this.payrollBindingSource.DataMember = "Payroll";
            this.payrollBindingSource.DataSource = this.myOfficeSpaceDataSetBindingSource;
            // 
            // myOfficeSpaceDataSetBindingSource
            // 
            this.myOfficeSpaceDataSetBindingSource.DataSource = this.my_Office_SpaceDataSet;
            this.myOfficeSpaceDataSetBindingSource.Position = 0;
            // 
            // my_Office_SpaceDataSet
            // 
            this.my_Office_SpaceDataSet.DataSetName = "My_Office_SpaceDataSet";
            this.my_Office_SpaceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payrollTableAdapter
            // 
            this.payrollTableAdapter.ClearBeforeFill = true;
            // 
            // ViewPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 222);
            this.Controls.Add(this.dataGridView2);
            this.Name = "ViewPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPayroll";
            this.Load += new System.EventHandler(this.ViewPayroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myOfficeSpaceDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_Office_SpaceDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource myOfficeSpaceDataSetBindingSource;
        private My_Office_SpaceDataSet my_Office_SpaceDataSet;
        private System.Windows.Forms.BindingSource payrollBindingSource;
        private My_Office_SpaceDataSetTableAdapters.PayrollTableAdapter payrollTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn payrollNumbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeSSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountantNumbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvalIDDataGridViewTextBoxColumn;
    }
}