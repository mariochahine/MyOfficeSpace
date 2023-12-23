namespace MyOfficeSpace.Employees
{
    partial class AddEmp
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.EmployeeDof = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmployeeDob = new System.Windows.Forms.DateTimePicker();
            this.EmployeeTeltxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmployeeEmailtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeeSSNtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmployeeNametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Location = new System.Drawing.Point(273, 345);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(240, 50);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add Employee";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // EmployeeDof
            // 
            this.EmployeeDof.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDof.Location = new System.Drawing.Point(438, 204);
            this.EmployeeDof.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.EmployeeDof.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.EmployeeDof.Name = "EmployeeDof";
            this.EmployeeDof.Size = new System.Drawing.Size(234, 21);
            this.EmployeeDof.TabIndex = 24;
            this.EmployeeDof.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(435, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Hiring Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Date of Birth:";
            // 
            // EmployeeDob
            // 
            this.EmployeeDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDob.Location = new System.Drawing.Point(133, 204);
            this.EmployeeDob.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.EmployeeDob.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.EmployeeDob.Name = "EmployeeDob";
            this.EmployeeDob.Size = new System.Drawing.Size(230, 21);
            this.EmployeeDob.TabIndex = 21;
            this.EmployeeDob.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // EmployeeTeltxt
            // 
            this.EmployeeTeltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeTeltxt.Location = new System.Drawing.Point(438, 123);
            this.EmployeeTeltxt.Name = "EmployeeTeltxt";
            this.EmployeeTeltxt.Size = new System.Drawing.Size(234, 24);
            this.EmployeeTeltxt.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tel:";
            // 
            // EmployeeEmailtxt
            // 
            this.EmployeeEmailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeEmailtxt.Location = new System.Drawing.Point(133, 123);
            this.EmployeeEmailtxt.Name = "EmployeeEmailtxt";
            this.EmployeeEmailtxt.Size = new System.Drawing.Size(230, 24);
            this.EmployeeEmailtxt.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email:";
            // 
            // EmployeeSSNtxt
            // 
            this.EmployeeSSNtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeSSNtxt.Location = new System.Drawing.Point(438, 48);
            this.EmployeeSSNtxt.Name = "EmployeeSSNtxt";
            this.EmployeeSSNtxt.Size = new System.Drawing.Size(234, 24);
            this.EmployeeSSNtxt.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "SSN:";
            // 
            // EmployeeNametxt
            // 
            this.EmployeeNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNametxt.Location = new System.Drawing.Point(133, 48);
            this.EmployeeNametxt.Name = "EmployeeNametxt";
            this.EmployeeNametxt.Size = new System.Drawing.Size(230, 24);
            this.EmployeeNametxt.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name:";
            // 
            // AddEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.EmployeeDof);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmployeeDob);
            this.Controls.Add(this.EmployeeTeltxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmployeeEmailtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmployeeSSNtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmployeeNametxt);
            this.Controls.Add(this.label1);
            this.Name = "AddEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.AddEmp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker EmployeeDof;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker EmployeeDob;
        private System.Windows.Forms.TextBox EmployeeTeltxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmployeeEmailtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmployeeSSNtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmployeeNametxt;
        private System.Windows.Forms.Label label1;
    }
}