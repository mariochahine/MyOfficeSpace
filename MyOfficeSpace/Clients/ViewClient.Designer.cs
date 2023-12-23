namespace MyOfficeSpace.Clients
{
    partial class ViewClient
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
            this.ClientTeltxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClientEmailtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientIDtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientNametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientTeltxt
            // 
            this.ClientTeltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientTeltxt.Location = new System.Drawing.Point(285, 252);
            this.ClientTeltxt.Name = "ClientTeltxt";
            this.ClientTeltxt.ReadOnly = true;
            this.ClientTeltxt.Size = new System.Drawing.Size(218, 24);
            this.ClientTeltxt.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 62;
            this.label4.Text = "Tel:";
            // 
            // ClientEmailtxt
            // 
            this.ClientEmailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientEmailtxt.Location = new System.Drawing.Point(286, 127);
            this.ClientEmailtxt.Name = "ClientEmailtxt";
            this.ClientEmailtxt.ReadOnly = true;
            this.ClientEmailtxt.Size = new System.Drawing.Size(217, 24);
            this.ClientEmailtxt.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 60;
            this.label3.Text = "Email:";
            // 
            // ClientIDtxt
            // 
            this.ClientIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientIDtxt.Location = new System.Drawing.Point(285, 189);
            this.ClientIDtxt.Name = "ClientIDtxt";
            this.ClientIDtxt.ReadOnly = true;
            this.ClientIDtxt.Size = new System.Drawing.Size(218, 24);
            this.ClientIDtxt.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 58;
            this.label2.Text = "ID:";
            // 
            // ClientNametxt
            // 
            this.ClientNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNametxt.Location = new System.Drawing.Point(286, 64);
            this.ClientNametxt.Name = "ClientNametxt";
            this.ClientNametxt.ReadOnly = true;
            this.ClientNametxt.Size = new System.Drawing.Size(217, 24);
            this.ClientNametxt.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 56;
            this.label1.Text = "Name:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Location = new System.Drawing.Point(263, 319);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(240, 50);
            this.btnClose.TabIndex = 55;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ViewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClientTeltxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClientEmailtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClientIDtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClientNametxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Name = "ViewClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewClient";
            this.Load += new System.EventHandler(this.ViewClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClientTeltxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClientEmailtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClientIDtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClientNametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}