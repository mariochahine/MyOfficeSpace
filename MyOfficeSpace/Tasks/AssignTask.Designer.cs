namespace MyOfficeSpace.Tasks
{
    partial class AssignTask
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
            this.EmpName = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.myOfficeSpaceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.my_Office_SpaceDataSet = new MyOfficeSpace.My_Office_SpaceDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TaskDetail = new System.Windows.Forms.TextBox();
            this.Deadline = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAddTask = new System.Windows.Forms.Button();
            this.employeesTableAdapter = new MyOfficeSpace.My_Office_SpaceDataSetTableAdapters.EmployeesTableAdapter();
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ManagerID = new System.Windows.Forms.ComboBox();
            this.managersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managersTableAdapter = new MyOfficeSpace.My_Office_SpaceDataSetTableAdapters.ManagersTableAdapter();
            this.employeesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myOfficeSpaceDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_Office_SpaceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpName
            // 
            this.EmpName.DataSource = this.employeesBindingSource4;
            this.EmpName.DisplayMember = "Employee_Name";
            this.EmpName.FormattingEnabled = true;
            this.EmpName.Location = new System.Drawing.Point(62, 55);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(165, 24);
            this.EmpName.TabIndex = 0;
            this.EmpName.ValueMember = "Employee_SSN";
            this.EmpName.SelectedIndexChanged += new System.EventHandler(this.EmpName_SelectedIndexChanged);
            // 
            // employeesBindingSource3
            // 
            this.employeesBindingSource3.DataMember = "Employees";
            this.employeesBindingSource3.DataSource = this.myOfficeSpaceDataSetBindingSource;
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
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.myOfficeSpaceDataSetBindingSource;
            // 
            // TaskDetail
            // 
            this.TaskDetail.Location = new System.Drawing.Point(62, 216);
            this.TaskDetail.Multiline = true;
            this.TaskDetail.Name = "TaskDetail";
            this.TaskDetail.Size = new System.Drawing.Size(675, 200);
            this.TaskDetail.TabIndex = 2;
            // 
            // Deadline
            // 
            this.Deadline.Location = new System.Drawing.Point(298, 57);
            this.Deadline.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.Deadline.Name = "Deadline";
            this.Deadline.Size = new System.Drawing.Size(226, 22);
            this.Deadline.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Manager ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Deadline";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Task Details";
            // 
            // BtnAddTask
            // 
            this.BtnAddTask.Location = new System.Drawing.Point(604, 55);
            this.BtnAddTask.Name = "BtnAddTask";
            this.BtnAddTask.Size = new System.Drawing.Size(133, 105);
            this.BtnAddTask.TabIndex = 27;
            this.BtnAddTask.Text = "Assign Task";
            this.BtnAddTask.UseVisualStyleBackColor = true;
            this.BtnAddTask.Click += new System.EventHandler(this.BtnAddTask_Click);
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataMember = "Employees";
            this.employeesBindingSource1.DataSource = this.myOfficeSpaceDataSetBindingSource;
            // 
            // employeesBindingSource2
            // 
            this.employeesBindingSource2.DataMember = "Employees";
            this.employeesBindingSource2.DataSource = this.my_Office_SpaceDataSet;
            // 
            // ManagerID
            // 
            this.ManagerID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeesBindingSource, "Employee_Name", true));
            this.ManagerID.DataSource = this.managersBindingSource;
            this.ManagerID.DisplayMember = "Manager_ID";
            this.ManagerID.FormattingEnabled = true;
            this.ManagerID.Location = new System.Drawing.Point(62, 138);
            this.ManagerID.Name = "ManagerID";
            this.ManagerID.Size = new System.Drawing.Size(165, 24);
            this.ManagerID.TabIndex = 28;
            this.ManagerID.ValueMember = "Manager_ID";
            // 
            // managersBindingSource
            // 
            this.managersBindingSource.DataMember = "Managers";
            this.managersBindingSource.DataSource = this.myOfficeSpaceDataSetBindingSource;
            // 
            // managersTableAdapter
            // 
            this.managersTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingSource4
            // 
            this.employeesBindingSource4.DataMember = "Employees";
            this.employeesBindingSource4.DataSource = this.myOfficeSpaceDataSetBindingSource;
            // 
            // AssignTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ManagerID);
            this.Controls.Add(this.BtnAddTask);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Deadline);
            this.Controls.Add(this.TaskDetail);
            this.Controls.Add(this.EmpName);
            this.Name = "AssignTask";
            this.Text = "AssignTask";
            this.Load += new System.EventHandler(this.AssignTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myOfficeSpaceDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_Office_SpaceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EmpName;
        private System.Windows.Forms.TextBox TaskDetail;
        private System.Windows.Forms.DateTimePicker Deadline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAddTask;
        private System.Windows.Forms.BindingSource myOfficeSpaceDataSetBindingSource;
        private My_Office_SpaceDataSet my_Office_SpaceDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private My_Office_SpaceDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource1;
        private System.Windows.Forms.BindingSource employeesBindingSource2;
        private System.Windows.Forms.ComboBox ManagerID;
        private System.Windows.Forms.BindingSource managersBindingSource;
        private My_Office_SpaceDataSetTableAdapters.ManagersTableAdapter managersTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource3;
        private System.Windows.Forms.BindingSource employeesBindingSource4;
    }
}