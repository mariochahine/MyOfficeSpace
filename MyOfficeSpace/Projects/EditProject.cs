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
    public partial class EditProject : Form
    {
        string pr;
        public EditProject(string pr)
        {
            InitializeComponent();
            this.pr = pr;
        }

        private void EditProject_Load(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Project_Name, Budget, Client_ID, Start_Date, Deadline, Project_Location from Projects where Project_Name = '" + pr + "'";

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
                MessageBox.Show("Error", "Error: " + ex.Message);
                return;
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update Projects set Project_Name = '" + ProjectNametxt.Text + "', Budget = '" + ProjectBudgettxt.Text + "', Client_ID = '" + ProjectClienttxt.Text + "', Start_Date = '" + ProjectDos.Value + "', Project_Location = '" + ProjectLocationtxt.Text + "' where Project_Name = '" + pr + "'";

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
