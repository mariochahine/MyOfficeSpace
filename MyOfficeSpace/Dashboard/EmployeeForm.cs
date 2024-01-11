using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOfficeSpace
{
    public partial class EmployeeForm : Form
    {
        int id;
        public EmployeeForm(int ID)
        {
            InitializeComponent();
            this.id = ID;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lv = new Login();
            lv.ShowDialog();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void OpenFilebtn_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderName = Path.Combine("Main Folder", "Shared Folder", "Employees");
            string folderPath = Path.Combine(desktopPath, folderName);

            if (FileList.SelectedItems.Count > 0)
            {
                string fileName = FileList.SelectedItems[0].Text;
                string filePath = Path.Combine(folderPath, fileName);

                Process.Start(filePath);
            }
            else
            {
                MessageBox.Show("Please select at least at least one file", "Open File", MessageBoxButtons.OKCancel);
            }
        }

        private void DeleteFilebtn_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderName = Path.Combine("Main Folder", "Shared Folder", "Employees");
            string folderPath = Path.Combine(desktopPath, folderName);

            if (FileList.SelectedItems.Count > 0)
            {
                string fileName = FileList.SelectedItems[0].Text;
                string filePath = Path.Combine(folderPath, fileName);

                File.Delete(filePath);
            }
            else
            {
                MessageBox.Show("Please select at least at least one file", "Delete File", MessageBoxButtons.OKCancel);
            }
        }

        private void RenameFilebtn_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderName = Path.Combine("Main Folder", "Shared Folder", "Employees");
            string folderPath = Path.Combine(desktopPath, folderName);


            if (FileList.SelectedItems.Count == 1)
            {
                string oldFilePath = folderPath + "\\" + FileList.SelectedItems[0].Text;
                string newFilePath = folderPath + "\\" + FileSearch.Text;
                if (FileSearch.Text == "")
                {
                    MessageBox.Show("Please Enter a Valid Name.", "Failed", MessageBoxButtons.OKCancel);
                }
                else
                {
                    File.Move(oldFilePath, newFilePath);
                    MessageBox.Show("File renamed successfully.", "Success");
                }
            }
            else MessageBox.Show("Please select one file to rename.", "Failed", MessageBoxButtons.OKCancel);
        }

        private void ShareFilebtn_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderName = Path.Combine("Main Folder", "Shared Folder", "Employees");
            string folderPath = Path.Combine(desktopPath, folderName);

            if (FileList.SelectedItems.Count > 0)
            {
                string oldFilePath = Path.Combine(folderPath, FileList.SelectedItems[0].Text);
                string newFilePath = Path.Combine(desktopPath, "Shared Folder", $"{id} - {FileList.SelectedItems[0].Text}");

                if (File.Exists(newFilePath))
                {
                    MessageBox.Show("File already Exists in that folder.", "Copy Failed", MessageBoxButtons.OK);
                }
                else
                {
                    File.Copy(oldFilePath, newFilePath);
                    MessageBox.Show("File shared successfully.", "Success");
                }
            }
            else MessageBox.Show("Please select at least one file to copy.", "Failed");
        }


        List<FileList> Files = new List<FileList>();
        private void button2_Click(object sender, EventArgs e)
        {
            FileList.Items.Clear();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderName = Path.Combine("Main Folder", "Shared Folder", "Employees");
            string folderPath = Path.Combine(desktopPath, folderName);

            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
                FileInfo[] files = directoryInfo.GetFiles();

                foreach (var file in files)
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.SubItems.Add(file.Length.ToString());
                    FileList.Items.Add(item);
                    Files.Add(new FileList(file.Name));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reading the files: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFileSearch_Click(object sender, EventArgs e)
        {
            var result = Files.Where(x => x.FileName.ToLower().Contains(FileSearch.Text));
            FileList.Items.Clear();
            foreach (var Filename in result)
            {
                ListViewItem listViewItem = new ListViewItem(Filename.FileName);

                FileList.Items.Add(listViewItem);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "Select Employee_name from Employees where Employee_SSN = " + id;

                        try
                        {
                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                e.Value = reader["Employee_name"].ToString();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                            return;
                        }
                    }
                }
            }
        }


        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_Office_SpaceDataSet.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.my_Office_SpaceDataSet.Attendance);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            attendanceBindingSource.Filter = string.Format("Day = '{0:yyyy-MM-dd}'", attDate.Value.Date);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            attendanceBindingSource.Filter = "Employee_SSN=" + id;
        }

        private void Sgnin_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;
            DateTime time = DateTime.Now;

            string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO Attendance (Attendance_Numb, Employee_SSN, Day, Sign_in, sign_out) VALUES('', '" + id + "','" + date + "','" + time + "','')";

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        MessageBox.Show("Record Updated!", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void signout_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            DateTime date = DateTime.Today;

            string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE Attendance SET Sign_out = '"+time+"' WHERE Day ='"+date +"'";

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        MessageBox.Show("Record Updated!", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
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
}
