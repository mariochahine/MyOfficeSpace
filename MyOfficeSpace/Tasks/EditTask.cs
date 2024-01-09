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
    public partial class EditTask : Form
    {
        string tsk;
        public EditTask(String Tsk)
        {
            InitializeComponent();
            this.tsk = Tsk;
        }

        private void EditTask_Load(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Employee_SSN, Manager_Numb, Task_Details, Deadline from Tasks where Task_Numb = '" +tsk+ "'";

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    empid.Text = reader["Employee_SSN"].ToString();
                    managerID.Value = decimal.Parse(reader["Manager_Numb"].ToString());
                    Deadline.Value = DateTime.Parse(reader["Deadline"].ToString());
                    TaskDetail.Text = reader["Task_Details"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Error: " + ex.Message);
                return;
            }
            finally
            {
                conn.Close();
            }
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update Tasks set Manager_Numb = '" + managerID.Value + "', Task_Details = '" +TaskDetail.Text + "', Deadline = '"+Deadline.Value+"' from Tasks where Task_Numb = '" + tsk + "'";

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Record Updated!", "Success");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
                return;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
