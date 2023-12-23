namespace MyOfficeSpace.Projects
{
    partial class AddProject
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
            this.ProjectBudgettxt = new System.Windows.Forms.TextBox();
            this.ProjectClienttxt = new System.Windows.Forms.TextBox();
            this.ProjectLocationtxt = new System.Windows.Forms.TextBox();
            this.ProjectNametxt = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ProjectDos = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ProjectDeadline = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ProjectBudgettxt
            // 
            this.ProjectBudgettxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectBudgettxt.Location = new System.Drawing.Point(445, 126);
            this.ProjectBudgettxt.Name = "ProjectBudgettxt";
            this.ProjectBudgettxt.Size = new System.Drawing.Size(218, 24);
            this.ProjectBudgettxt.TabIndex = 76;
            // 
            // ProjectClienttxt
            // 
            this.ProjectClienttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectClienttxt.Location = new System.Drawing.Point(140, 126);
            this.ProjectClienttxt.Name = "ProjectClienttxt";
            this.ProjectClienttxt.Size = new System.Drawing.Size(217, 24);
            this.ProjectClienttxt.TabIndex = 75;
            // 
            // ProjectLocationtxt
            // 
            this.ProjectLocationtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectLocationtxt.Location = new System.Drawing.Point(445, 56);
            this.ProjectLocationtxt.Name = "ProjectLocationtxt";
            this.ProjectLocationtxt.Size = new System.Drawing.Size(217, 24);
            this.ProjectLocationtxt.TabIndex = 73;
            // 
            // ProjectNametxt
            // 
            this.ProjectNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNametxt.Location = new System.Drawing.Point(140, 56);
            this.ProjectNametxt.Name = "ProjectNametxt";
            this.ProjectNametxt.Size = new System.Drawing.Size(217, 24);
            this.ProjectNametxt.TabIndex = 71;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Location = new System.Drawing.Point(281, 335);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(240, 50);
            this.btnAdd.TabIndex = 70;
            this.btnAdd.Text = "Add Project";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(210, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 69;
            this.label7.Text = "Start Date:";
            // 
            // ProjectDos
            // 
            this.ProjectDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDos.Location = new System.Drawing.Point(129, 188);
            this.ProjectDos.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.ProjectDos.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.ProjectDos.Name = "ProjectDos";
            this.ProjectDos.Size = new System.Drawing.Size(240, 21);
            this.ProjectDos.TabIndex = 68;
            this.ProjectDos.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(442, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 67;
            this.label6.Text = "Budget:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 66;
            this.label5.Text = "Client:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 64;
            this.label3.Text = "Location:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 62;
            this.label1.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(515, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 78;
            this.label8.Text = "Deadline:";
            // 
            // ProjectDeadline
            // 
            this.ProjectDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDeadline.Location = new System.Drawing.Point(434, 188);
            this.ProjectDeadline.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.ProjectDeadline.MinDate = new System.DateTime(2023, 12, 14, 0, 0, 0, 0);
            this.ProjectDeadline.Name = "ProjectDeadline";
            this.ProjectDeadline.Size = new System.Drawing.Size(240, 21);
            this.ProjectDeadline.TabIndex = 77;
            this.ProjectDeadline.Value = new System.DateTime(2023, 12, 14, 0, 0, 0, 0);
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ProjectDeadline);
            this.Controls.Add(this.ProjectBudgettxt);
            this.Controls.Add(this.ProjectClienttxt);
            this.Controls.Add(this.ProjectLocationtxt);
            this.Controls.Add(this.ProjectNametxt);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProjectDos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AddProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProject";
            this.Load += new System.EventHandler(this.AddProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProjectBudgettxt;
        private System.Windows.Forms.TextBox ProjectClienttxt;
        private System.Windows.Forms.TextBox ProjectLocationtxt;
        private System.Windows.Forms.TextBox ProjectNametxt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker ProjectDos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker ProjectDeadline;
    }
}