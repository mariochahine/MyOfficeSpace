namespace MyOfficeSpace.Tasks
{
    partial class ViewTask
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TaskDetail = new System.Windows.Forms.TextBox();
            this.empID = new System.Windows.Forms.TextBox();
            this.Deadlinebox = new System.Windows.Forms.TextBox();
            this.ManagerID = new System.Windows.Forms.TextBox();
            this.assigndatebo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Task Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Deadline";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Manager ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Employee SSN";
            // 
            // TaskDetail
            // 
            this.TaskDetail.Location = new System.Drawing.Point(59, 193);
            this.TaskDetail.Multiline = true;
            this.TaskDetail.Name = "TaskDetail";
            this.TaskDetail.ReadOnly = true;
            this.TaskDetail.Size = new System.Drawing.Size(675, 200);
            this.TaskDetail.TabIndex = 29;
            // 
            // empID
            // 
            this.empID.Location = new System.Drawing.Point(191, 46);
            this.empID.Name = "empID";
            this.empID.ReadOnly = true;
            this.empID.Size = new System.Drawing.Size(152, 22);
            this.empID.TabIndex = 37;
            // 
            // Deadlinebox
            // 
            this.Deadlinebox.Location = new System.Drawing.Point(456, 114);
            this.Deadlinebox.Name = "Deadlinebox";
            this.Deadlinebox.ReadOnly = true;
            this.Deadlinebox.Size = new System.Drawing.Size(152, 22);
            this.Deadlinebox.TabIndex = 38;
            // 
            // ManagerID
            // 
            this.ManagerID.Location = new System.Drawing.Point(456, 46);
            this.ManagerID.Name = "ManagerID";
            this.ManagerID.ReadOnly = true;
            this.ManagerID.Size = new System.Drawing.Size(152, 22);
            this.ManagerID.TabIndex = 39;
            // 
            // assigndatebo
            // 
            this.assigndatebo.Location = new System.Drawing.Point(191, 114);
            this.assigndatebo.Name = "assigndatebo";
            this.assigndatebo.ReadOnly = true;
            this.assigndatebo.Size = new System.Drawing.Size(152, 22);
            this.assigndatebo.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Assign Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(321, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 42;
            this.label6.Text = "Status:";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(387, 413);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 16);
            this.Status.TabIndex = 43;
            // 
            // ViewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.assigndatebo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ManagerID);
            this.Controls.Add(this.Deadlinebox);
            this.Controls.Add(this.empID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TaskDetail);
            this.Name = "ViewTask";
            this.Text = "ViewTask";
            this.Load += new System.EventHandler(this.ViewTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TaskDetail;
        private System.Windows.Forms.TextBox empID;
        private System.Windows.Forms.TextBox Deadlinebox;
        private System.Windows.Forms.TextBox ManagerID;
        private System.Windows.Forms.TextBox assigndatebo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Status;
    }
}