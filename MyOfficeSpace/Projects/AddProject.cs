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

namespace MyOfficeSpace.Projects
{
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ProjectNametxt.Text == "" || ProjectLocationtxt.Text == "" ||  ProjectBudgettxt.Text == "" || ProjectClienttxt.Text == "")
            {
                MessageBox.Show("Please fill all the fields!", "Missing Fields");
            }
            else
            {
                string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into Projects (Project_ID, Project_Name, Client_ID, Budget, Start_Date, Deadline, Project_Location) ";
                cmd.CommandText += "values('','" + ProjectNametxt.Text + "', '"  + ProjectClienttxt.Text + "', '" + ProjectBudgettxt.Text + "', '" + ProjectDos.Value + "', '" + ProjectDeadline.Value + "', '" + ProjectLocationtxt.Text + "')";

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

        private void AddProject_Load(object sender, EventArgs e)
        {

        }
    }
}
