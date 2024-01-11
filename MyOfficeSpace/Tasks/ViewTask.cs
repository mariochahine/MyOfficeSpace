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
    public partial class ViewTask : Form
    {
        int v;
        public ViewTask(int vt)
        {
            InitializeComponent();
            vt = this.v;
        }

        private void ViewTask_Load(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT * FROM Tasks WHERE Task_Numb = "+v;

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    empID.Text = reader["Employee_SSN"].ToString();
                    ManagerID.Text = reader["Manager_Numb"].ToString();
                    assigndatebo.Text = reader["Assign_date"].ToString();
                    Deadlinebox.Text = reader["Deadline"].ToString();
                    TaskDetail.Text = reader["Task_Details"].ToString();

                    if(reader["Done"].ToString() == "0")
                    {
                        Status.Text = "Pending";
                    }
                    else
                    {
                        Status.Text = "Task Done";
                    }
                }
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
