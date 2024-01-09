namespace MyOfficeSpace.Tasks
{
    partial class EditTask
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
            this.BtnAddTask = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.managerID = new System.Windows.Forms.NumericUpDown();
            this.Deadline = new System.Windows.Forms.DateTimePicker();
            this.TaskDetail = new System.Windows.Forms.TextBox();
            this.empid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.managerID)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAddTask
            // 
            this.BtnAddTask.Location = new System.Drawing.Point(606, 54);
            this.BtnAddTask.Name = "BtnAddTask";
            this.BtnAddTask.Size = new System.Drawing.Size(133, 105);
            this.BtnAddTask.TabIndex = 36;
            this.BtnAddTask.Text = "Edit Task";
            this.BtnAddTask.UseVisualStyleBackColor = true;
            this.BtnAddTask.Click += new System.EventHandler(this.BtnAddTask_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Task Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Deadline";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Manager ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Employee SSN";
            // 
            // managerID
            // 
            this.managerID.Location = new System.Drawing.Point(65, 137);
            this.managerID.Name = "managerID";
            this.managerID.Size = new System.Drawing.Size(165, 22);
            this.managerID.TabIndex = 31;
            // 
            // Deadline
            // 
            this.Deadline.Location = new System.Drawing.Point(300, 56);
            this.Deadline.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.Deadline.Name = "Deadline";
            this.Deadline.Size = new System.Drawing.Size(226, 22);
            this.Deadline.TabIndex = 30;
            // 
            // TaskDetail
            // 
            this.TaskDetail.Location = new System.Drawing.Point(64, 215);
            this.TaskDetail.Multiline = true;
            this.TaskDetail.Name = "TaskDetail";
            this.TaskDetail.Size = new System.Drawing.Size(675, 200);
            this.TaskDetail.TabIndex = 29;
            // 
            // empid
            // 
            this.empid.Location = new System.Drawing.Point(58, 58);
            this.empid.Name = "empid";
            this.empid.ReadOnly = true;
            this.empid.Size = new System.Drawing.Size(172, 22);
            this.empid.TabIndex = 37;
            // 
            // EditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.empid);
            this.Controls.Add(this.BtnAddTask);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.managerID);
            this.Controls.Add(this.Deadline);
            this.Controls.Add(this.TaskDetail);
            this.Name = "EditTask";
            this.Text = "EditTask";
            this.Load += new System.EventHandler(this.EditTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.managerID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown managerID;
        private System.Windows.Forms.DateTimePicker Deadline;
        private System.Windows.Forms.TextBox TaskDetail;
        private System.Windows.Forms.TextBox empid;
    }
}