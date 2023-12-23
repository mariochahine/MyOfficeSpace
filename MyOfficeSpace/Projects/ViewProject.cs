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
    public partial class ViewProject : Form
    {
        string project;
        public ViewProject(string pr)
        {            
            InitializeComponent();
            this.project = pr;
        }

        private void ViewProject_Load(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Project_Name, Budget, Client_ID, Start_Date, Deadline, Project_Location from Projects where Project_Name = '" + project + "'";

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ProjectNametxt.Text = reader["Project_Name"].ToString();
                    ProjectLocationtxt.Text = reader["Project_Location"].ToString();
                    ProjectBudgettxt.Text = reader["Budget"].ToString();
                    ProjectClienttxt.Text = reader["Client_ID"].ToString();
                    ProjectDos.Text = reader["Start_Date"].ToString();
                    ProjectDeadline.Text = reader["Deadline"].ToString();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
