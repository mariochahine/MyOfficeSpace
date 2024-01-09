using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOfficeSpace.Tasks
{
    public partial class AssignTask : Form
    {
        public AssignTask()
        {
            InitializeComponent();
        }

        private void AssignTask_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_Office_SpaceDataSet.Managers' table. You can move, or remove it, as needed.
            this.managersTableAdapter.Fill(this.my_Office_SpaceDataSet.Managers);


        }
        DateTime currentDateTime = DateTime.Now;
        private void EmpName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            if(EmpName.Text=="" || TaskDetail.Text == "")
            {
                MessageBox.Show("Please fill all the fields!", "Missing Fields");
            }
            else
            {
                string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into Tasks (Task_Numb, Employee_SSN, Assign_Date, Manager_Numb, Task_Details, Done, Deadline) ";
                cmd.CommandText += "values('', '" + EmpName.ValueMember + "', '" + currentDateTime + "', '" + ManagerID.SelectedIndex.ToString() + "', '" + TaskDetail.Text + "', '0','"+Deadline.Value+"')";

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    MessageBox.Show("Record Added!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                    return;
                }
                finally
                {
                    conn.Close();
                    this.Close();
                }
            }
        }
    }
}
