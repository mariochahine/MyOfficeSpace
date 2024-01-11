using MyOfficeSpace.Clients;
using MyOfficeSpace.Employees;
using MyOfficeSpace.Projects;
using MyOfficeSpace.Tasks;
using MyOfficeSpace.View;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyOfficeSpace
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }


        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool isDragging = false;
        private int dragStartX, dragStartY;

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_Office_SpaceDataSet.Payroll' table. You can move, or remove it, as needed.
            this.payrollTableAdapter.Fill(this.my_Office_SpaceDataSet.Payroll);
            // TODO: This line of code loads data into the 'my_Office_SpaceDataSet.Accountants' table. You can move, or remove it, as needed.
            this.accountantsTableAdapter.Fill(this.my_Office_SpaceDataSet.Accountants);
            // TODO: This line of code loads data into the 'my_Office_SpaceDataSet.Expenses' table. You can move, or remove it, as needed.
            this.expensesTableAdapter.Fill(this.my_Office_SpaceDataSet.Expenses);
            // TODO: This line of code loads data into the 'my_Office_SpaceDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.my_Office_SpaceDataSet.Employees);
            // TODO: This line of code loads data into the 'my_Office_SpaceDataSet.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.my_Office_SpaceDataSet.Attendance);

        }

        private void ManagerForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragStartX = e.X;
                dragStartY = e.Y;
            }
        }

        private void ManagerForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void ManagerForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.X - dragStartX;
                int deltaY = e.Y - dragStartY;

                // Update the form's position
                Location = new System.Drawing.Point(Left + deltaX, Top + deltaY);
            }
        }

        private void Minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
       
        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lv = new Login();
            lv.ShowDialog();
        }



        List<ProjectList> Projects = new List<ProjectList>();
        private void RefreshProjectList_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Project_Name from Projects";

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                ProjectList.Items.Clear();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        ProjectList.Items.Add(reader["Project_Name"].ToString());
                        Projects.Add(new ProjectList(reader["Project_Name"].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error003: " + ex.Message);
                return;
            }
            finally
            {
                conn.Close();
            }
        }


        List<ClientList> Clients = new List<ClientList>();
        private void RefreshClientListbtn_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Client_Name from Clients";

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                ClientsList.Items.Clear();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        ClientsList.Items.Add(reader["Client_Name"].ToString());
                        Clients.Add(new ClientList(reader["Client_Name"].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error004: " + ex.Message);
                return;
            }
            finally
            {
                conn.Close();
            }
        }


        List<EmployeeList> Employees = new List<EmployeeList>();
        private void RefreshEmployeeList_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Employee_Name from Employees";
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                EmployeesList.Items.Clear();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        EmployeesList.Items.Add(reader["Employee_Name"].ToString());
                        Employees.Add(new EmployeeList(reader["Employee_Name"].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error005: " + ex.Message);
                return;
            }
            finally
            {
                conn.Close();
            }
        }


        List<FileList> Files = new List<FileList>();
        private void RefreshFile_Click(object sender, EventArgs e)
        {
            FileList.Items.Clear();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderName = "Main Folder";
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


        List<TaskList> TaskList = new List<TaskList>();
        private void BtnRefreshTask_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Task_Numb, Employee_Name, Task_Details from Employees join Tasks on Employees.Employee_SSN = Tasks.Employee_SSN";
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                listTask.Items.Clear();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["Task_Numb"].ToString());
                    item.SubItems.Add(reader["Employee_Name"].ToString());
                    item.SubItems.Add(reader["Task_Details"].ToString());

                    listTask.Items.Add(item);

                    TaskList.Add(new TaskList(
                        reader["Task_Numb"].ToString(),
                        reader["Employee_Name"].ToString(),
                        reader["Task_Details"].ToString()
                    ));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error006: " + ex.Message);
                return;
            }
            finally
            {
                conn.Close();
            }
        }




        private void Createfolderbtn_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string folderName = "Main Folder";
            string subfolderName = "Shared Folder";
            string empfolderName = "Employees";
            string accfolderName = "Accountants";
            string hrfolderName = "HR";

            string folderPath = Path.Combine(desktopPath, folderName); // Main folder

            string subfolderPath = Path.Combine(folderPath, subfolderName); //main Folder/sharedfolder

            string empfolderPath = Path.Combine(subfolderPath, empfolderName); //main Folder/sharedfolder/employee
            string accfolderPath = Path.Combine(subfolderPath, accfolderName);  //main Folder/sharedfolder/accountant
            string hrfolderPath = Path.Combine(subfolderPath, hrfolderName);  //main Folder/sharedfolder/hr

            if (Directory.Exists(folderPath))
            {
                MessageBox.Show("The folder already exists.", "Main Folder", MessageBoxButtons.OK);
            }
            else
            {
                Directory.CreateDirectory(folderPath);
                Directory.CreateDirectory(subfolderPath);
                Directory.CreateDirectory(empfolderPath);
                Directory.CreateDirectory(accfolderPath);
                Directory.CreateDirectory(hrfolderPath);

                MessageBox.Show("Folder created successfully.", "Main Folder", MessageBoxButtons.OK);
            }
        }

        private void OpenMainFolder_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderName = "Main Folder";
            string folderPath = Path.Combine(desktopPath, folderName);
            Process.Start(folderPath);
        }

        private void OpenFilebtn_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string mainFolderName = "Main Folder";
            string sharedFolderName = "Shared Folder";

            string mainFolderPath = Path.Combine(desktopPath, mainFolderName);
            string sharedFolderPath = Path.Combine(mainFolderPath, sharedFolderName);

            if (FileList.SelectedItems.Count > 0)
            {
                string fileName = FileList.SelectedItems[0].Text;
                string filePathInMainFolder = Path.Combine(mainFolderPath, fileName);
                string filePathInSharedFolder = Path.Combine(sharedFolderPath, fileName);
                if (File.Exists(filePathInMainFolder))
                {
                    Process.Start(filePathInMainFolder);
                }
                else if (File.Exists(filePathInSharedFolder))
                {
                    Process.Start(filePathInSharedFolder);
                }
                else
                {
                    MessageBox.Show("File not found!", "Open File", MessageBoxButtons.OKCancel);
                }
            }
            else
            {
                MessageBox.Show("Please select at least one file", "Open File", MessageBoxButtons.OKCancel);
            }
        }

        private void DeleteFilebtn_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string mainFolderName = "Main Folder";
            string sharedFolderName = "Shared Folder";

            string mainFolderPath = Path.Combine(desktopPath, mainFolderName);
            string sharedFolderPath = Path.Combine(mainFolderPath, sharedFolderName);

            if (FileList.SelectedItems.Count > 0)
            {
                string fileName = FileList.SelectedItems[0].Text;
                string filePathInMainFolder = Path.Combine(mainFolderPath, fileName);
                string filePathInSharedFolder = Path.Combine(sharedFolderPath, fileName);

                // Check if the file exists in the main folder, and delete it if found
                if (File.Exists(filePathInMainFolder))
                {
                    File.Delete(filePathInMainFolder);
                    MessageBox.Show("File Deleted!", "Delete File", MessageBoxButtons.OKCancel);
                }
                else if (File.Exists(filePathInSharedFolder))
                {
                    File.Delete(filePathInSharedFolder);
                    MessageBox.Show("File Deleted!", "Delete File", MessageBoxButtons.OKCancel);
                }
                else
                {
                    MessageBox.Show("File not found!", "Delete File", MessageBoxButtons.OKCancel);
                }
            }
            else
            {
                MessageBox.Show("Please select at least one file", "Delete File", MessageBoxButtons.OKCancel);
            }
        }

        private void RenameFilebtn_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string mainFolderName = "Main Folder";
            string sharedFolderName = "Shared Folder";

            string mainFolderPath = Path.Combine(desktopPath, mainFolderName);
            string sharedFolderPath = Path.Combine(mainFolderPath, sharedFolderName);

            if (FileList.SelectedItems.Count == 1)
            {
                string oldFileName = FileList.SelectedItems[0].Text;
                string oldFilePathInMainFolder = Path.Combine(mainFolderPath, oldFileName);
                string oldFilePathInSharedFolder = Path.Combine(sharedFolderPath, oldFileName);

                string newFileName = FileSearch.Text;
                string newFilePathInMainFolder = Path.Combine(mainFolderPath, newFileName);
                string newFilePathInSharedFolder = Path.Combine(sharedFolderPath, newFileName);

                if (newFileName == "")
                {
                    MessageBox.Show("Please Enter a Valid Name.", "Failed", MessageBoxButtons.OKCancel);
                }
                else
                {
                    if (File.Exists(oldFilePathInMainFolder))
                    {
                        File.Move(oldFilePathInMainFolder, newFilePathInMainFolder);
                        MessageBox.Show("File renamed successfully", "Success");
                    }
                    else if (File.Exists(oldFilePathInSharedFolder))
                    {
                        File.Move(oldFilePathInSharedFolder, newFilePathInSharedFolder);
                        MessageBox.Show("File renamed successfully", "Success");
                    }
                    else
                    {
                        MessageBox.Show("File not found!", "Failed", MessageBoxButtons.OKCancel);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select one file to rename.", "Failed", MessageBoxButtons.OKCancel);
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

        private void btnProjectSearch_Click(object sender, EventArgs e)
        {
            var result = Projects.Where(x => x.ProjectName.Trim().ToLower().Contains(ProjectSearch.Text));
            ProjectList.Items.Clear();
            foreach (var Projectname in result)
            {
                ListViewItem listViewItem = new ListViewItem(Projectname.ProjectName);

                ProjectList.Items.Add(listViewItem);
            }
        }

        private void btnClientSearch_Click(object sender, EventArgs e)
        {
            var result = Clients.Where(x => x.ClientName.ToLower().Contains(ClientSearch.Text));
            ClientsList.Items.Clear();
            foreach (var Clientname in result)
            {
                ListViewItem listViewItem = new ListViewItem(Clientname.ClientName);

                ClientsList.Items.Add(listViewItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileList.Items.Clear();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderName = Path.Combine("Main Folder", "Shared Folder");
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

        private void btnemp_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderName = "Main Folder";
            string folderPath = Path.Combine(desktopPath, folderName);

            if (FileList.SelectedItems.Count > 0)
            {
                string oldFilePath = folderPath + "\\" + FileList.SelectedItems[0].Text;
                string newFilePath = Path.Combine(folderPath, "Shared Folder", "Employees", FileList.SelectedItems[0].Text);

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

        private void btnHR_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderName = "Main Folder";
            string folderPath = Path.Combine(desktopPath, folderName);

            if (FileList.SelectedItems.Count > 0)
            {
                string oldFilePath = folderPath + "\\" + FileList.SelectedItems[0].Text;
                string newFilePath = Path.Combine(folderPath, "Shared Folder", "HR", FileList.SelectedItems[0].Text);

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

        private void btnAcc_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderName = "Main Folder";
            string folderPath = Path.Combine(desktopPath, folderName);

            if (FileList.SelectedItems.Count > 0)
            {
                string oldFilePath = folderPath + "\\" + FileList.SelectedItems[0].Text;
                string newFilePath = Path.Combine(folderPath, "Shared Folder", "Accountants", FileList.SelectedItems[0].Text);

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



        private void AddProjectbtn_Click(object sender, EventArgs e)
        {
            AddProject ap = new AddProject();
            ap.ShowDialog();
        }

        private void ProjectDetailbtn_Click(object sender, EventArgs e)
        {
            if (ProjectList.SelectedItems.Count == 1)
            {
                string pr = ProjectList.SelectedItems[0].Text;
                ViewProject vp = new ViewProject(pr);
                vp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select one Project", "Project Details", MessageBoxButtons.OK);
                RefreshProjectList_Click(sender, e);
            }
        }

        private void EditProjectbtn_Click(object sender, EventArgs e)
        {
            if (ProjectList.SelectedItems.Count == 1)
            {
                string pr = ProjectList.SelectedItems[0].Text;
                EditProject ep = new EditProject(pr);
                ep.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select one Project", "Project Details", MessageBoxButtons.OK);
                RefreshProjectList_Click(sender, e);
            }
        }


        private void RemoveProjectbtn_Click(object sender, EventArgs e)
        {
            if (ProjectList.SelectedItems.Count >= 1)
            {
                string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE from Projects where Project_Name = '" + ProjectList.SelectedItems[0].Text + "'";


                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted!", "Delete");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error007: " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select at least one Project", "Remove Project", MessageBoxButtons.OK);
                RefreshProjectList_Click(sender, e);
            }
        }





        private void AddClientbtn_Click(object sender, EventArgs e)
        {
            AddClient ac = new AddClient();
            ac.ShowDialog();
        }

        private void EditClientbtn_Click(object sender, EventArgs e)
        {
            if (ClientsList.SelectedItems.Count == 1)
            {
                string c = ClientsList.SelectedItems[0].Text;
                EditClient ec = new EditClient(c);
                ec.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select one Client", "Client Details", MessageBoxButtons.OK);
                RefreshClientListbtn_Click(sender, e);
            }
        }

        private void ClientDetailBtn_Click(object sender, EventArgs e)
        {
            if (ClientsList.SelectedItems.Count == 1)
            {
                string c = ClientsList.SelectedItems[0].Text;
                ViewClient vc = new ViewClient(c);
                //MessageBox.Show(c);
                vc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select one Client", "Client Details", MessageBoxButtons.OK);
                RefreshClientListbtn_Click(sender, e);
            }
        }

        private void RemoveClientbtn_Click(object sender, EventArgs e)
        {
            if (ClientsList.SelectedItems.Count >= 1)
            {
                string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE from Clients where Client_Name = '" + ClientsList.SelectedItems[0].Text + "'";
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                    RefreshClientListbtn_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Please select at least one Employee", "Remove Employee", MessageBoxButtons.OK);
                RefreshClientListbtn_Click(sender, e);
            }
        }






        private void AddEmployeebtn_Click(object sender, EventArgs e)
        {
            AddEmp ae = new AddEmp();
            ae.ShowDialog();
        }

        private void EditEmployeebtn_Click(object sender, EventArgs e)
        {
            if (EmployeesList.SelectedItems.Count == 1)
            {
                string em = EmployeesList.SelectedItems[0].Text;
                EditEmp ee = new EditEmp(em);
                ee.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select one Employee", "Employee Details", MessageBoxButtons.OK);
                RefreshEmployeeList_Click(sender, e);
            }
        }

        private void EmployeeDetailbtn_Click(object sender, EventArgs e)
        {
            if (EmployeesList.SelectedItems.Count == 1)
            {
                string em = EmployeesList.SelectedItems[0].Text;
                ViewEmp ve = new ViewEmp(em);
                ve.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select one Employee", "Employee Details", MessageBoxButtons.OK);
                RefreshEmployeeList_Click(sender, e);
            }
        }

        private void RemoveEmployeebtn_Click(object sender, EventArgs e)
        {
            if (EmployeesList.SelectedItems.Count >= 1)
            {
                string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE from Employees where Employee_Name = '" + EmployeesList.SelectedItems[0].Text + "'";

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted!");
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
            else
            {
                MessageBox.Show("Please select at least at least one Employee", "Remove Employee", MessageBoxButtons.OK);
                RefreshEmployeeList_Click(sender, e);
            }
        }


        

        
        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            AssignTask ass = new AssignTask();
            ass.ShowDialog();

        }

        private void BtnViewTask_Click(object sender, EventArgs e)
        {
            if (listTask.SelectedItems.Count == 1)
            {
                int numb = int.Parse(listTask.SelectedItems[0].Text);
                ViewTask et = new ViewTask(numb);
                et.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select one Task", "Task Details", MessageBoxButtons.OK);
                BtnRefreshTask_Click(sender, e);
            }
        }

        private void BtnRemoveTask_Click(object sender, EventArgs e)
        {
            if (EmployeesList.SelectedItems.Count >= 1)
            {
                string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE from Tasks where Task_numb = '" + EmployeesList.SelectedItems[0].Text + "'";

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted!");
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
            else
            {
                MessageBox.Show("Please select at least at least one Task", "Remove Task", MessageBoxButtons.OK);
                RefreshEmployeeList_Click(sender, e);
            }
        }

        private void BtnEditTask_Click(object sender, EventArgs e)
        {
            if (listTask.SelectedItems.Count == 1)
            {
                String tsknum = listTask.SelectedItems[0].Text;
                EditTask et = new EditTask(tsknum);
                et.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select one Task", "Task Details", MessageBoxButtons.OK);
                BtnRefreshTask_Click(sender, e);
            }

        }






        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindingSource1.Filter = "Employee_SSN=" + bunifuDropdown1.SelectedValue;
        }

        private void bunifuDropdown3_SelectedIndexChanged(object sender, EventArgs e)
        {
            payrollBindingSource.Filter = "Employee_SSN=" + bunifuDropdown3.SelectedValue;
        }

        private void bunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {
            expensesBindingSource.Filter = "Expenses_Numb=" + bunifuDropdown2.SelectedValue;
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
                        cmd.CommandText = "Select Employee_name from Employees where Employee_SSN = "+ dataGridView1.Rows[e.RowIndex].Cells[1].Value+"";
                        /*cmd.Parameters.AddWithValue("@Employee_SSN", e.Value);*/

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



        private void reset_Click(object sender, EventArgs e)
        {
            bindingSource1.Filter = "";
        }

        private void resetpay_Click(object sender, EventArgs e)
        {
            payrollBindingSource.Filter = "";
        }

        private void resetex_Click(object sender, EventArgs e)
        {
            expensesBindingSource.Filter = "";
        }

        private void ViewTrans_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int expenseNumber = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);

                ViewTrans vt = new ViewTrans(expenseNumber);
                vt.Show();
            }
            else
            {
                MessageBox.Show("Please select one Row", "Transaction Details", MessageBoxButtons.OK);
            }
        }

        private void Approve_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int Approvalid = Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value);

                if(Approvalid != 0)
                {
                    MessageBox.Show("Transaction Already Approved", "Transaction Approval", MessageBoxButtons.OK);
                }
                else
                {
                    string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(connString);

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "update Expenses set Approval_ID = 1 where Expense_Numb = '" + Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value) + "'";
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        MessageBox.Show("Transaction Approved", "Transaction Approval", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error010: " + ex.Message);
                        return;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select one Row", "Transaction Details", MessageBoxButtons.OK);
            }
        }

        private void ApprovePay_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                int Approvalid = Convert.ToInt32(dataGridView3.CurrentRow.Cells[3].Value);

                if (Approvalid != 0)
                {
                    MessageBox.Show("Payroll Already Approved", "Payroll Approval", MessageBoxButtons.OK);
                }
                else
                {
                    string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(connString);

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "update Expenses set Approval_ID = 1 where Expense_Numb = '" + Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value) + "'";
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        MessageBox.Show("Payroll Approved", "Payroll Approval", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error010: " + ex.Message);
                        return;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select one Row", "Payroll Details", MessageBoxButtons.OK);
            }
        }

        private void Viewpay_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                int paynumb = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value);

                ViewPayroll vp = new ViewPayroll(paynumb);
                vp.Show();
            }
            else
            {
                MessageBox.Show("Please select one Row", "Payroll Details", MessageBoxButtons.OK);
            }
        }

        private void S(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AttDate_ValueChanged(object sender, EventArgs e)
        {
            bindingSource1.Filter = string.Format("Day = '{0:yyyy-MM-dd}'", AttDate.Value.Date);           

        }






    }
}
