using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Net;

namespace MyOfficeSpace
{
    //Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public async void copytoclipboard()
        {
            await Task.Delay(3000);
            string message = "Hello boss.\nI seem to have forgotten my password.\nCan you provide me with my Security Question please.";

            MessageBoxOptions options = MessageBoxOptions.DefaultDesktopOnly;
            DialogResult result = MessageBox.Show(message, "Do you want to copy this message to clipboard?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, options);


            if (result == DialogResult.Yes)
            {
                Clipboard.SetText(message);
                MessageBox.Show("Message copied to clipboard!", "Copy Successful", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, options);
            }
        }

        public async void sendEmail()
        {

            try
            {
                await Task.Delay(3000);

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "https://mail.google.com/mail/u/0/?view=cm&fs=1&tf=1",
                    UseShellExecute = true
                };

                Process.Start(startInfo);

                Console.WriteLine("Gmail opened with a new email draft.");
                copytoclipboard();
            }

            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while opening Gmail: " + ex.Message);
            }
        }

        public void Window()
        {
            string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT pos.Position ";
            cmd.CommandText += "FROM Position AS pos join Credentials AS c on pos.Position_ID = c.Position_ID ";
            cmd.CommandText += "WHERE c.ID = " + IDbox.Text;

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string position = reader.GetString(0);

                    if (position == "Manager")
                    {
                        ManagerForm mf = new ManagerForm();
                        mf.Show();
                        MessageBox.Show("Manager Login successful!", "Welcome!");
                    }
                    else if("Accountant" == position)
                    {
                        AccountantForm af = new AccountantForm();
                        af.Show();
                        MessageBox.Show("Accountant Login successful!", "Welcome!");
                    }
                    else if("HR" == position)
                    {
                        HRForm hf = new HRForm();
                        hf.Show();
                        MessageBox.Show("HR Login successful!", "Welcome!");
                    }
                    else if("Employee"== position)
                    {
                        EmployeeForm ef = new EmployeeForm();
                        ef.Show();
                        MessageBox.Show("Employee Login successful!", "Welcome!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID!");
                }
                this.Hide();
                reader.Close();
            }



            catch (Exception ex)
            {
                MessageBox.Show("Error002: " + ex.Message);
                return;
            }
            finally
            {
                conn.Close();
            }
        }

        private void Passwordbox_TextChanged(object sender, EventArgs e)
        {
            Passwordbox.PasswordChar = '*';
        }

        private void Forgotpass_Click(object sender, EventArgs e)
        {
            SecurityTip.Visible = true;
            sendEmail();
        }

        private void Minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (IDbox.Text == "" || Passwordbox.Text == "")
            {
                MessageBox.Show("Please enter both your ID and Password", "Missing Credentials", MessageBoxButtons.OK);
            }
            else
            {
                string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT Password from Credentials WHERE ID =" + IDbox.Text;
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (!reader.Read())
                    {
                        MessageBox.Show("Make sure to insert an exist Id!");
                        IDbox.Clear();
                        Passwordbox.Clear();
                        return;
                    }
                    else
                    {

                        string pass = reader.GetString(0);
                        if (Passwordbox.Text == pass)
                        {
                            Window();
                        }
                        else
                        {
                            MessageBox.Show("Invalid password!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error001: " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }

            }
        }
    }
}
