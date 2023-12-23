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

namespace MyOfficeSpace.Employees
{
    public partial class EditEmp : Form
    {
        string em;
        public EditEmp(string em)
        {
            InitializeComponent();
            this.em = em;
        }

        private void EditEmp_Load(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Employee_SSN, Employee_Name, Date_of_Birth, Phone, Email, Join_Date from Employees where Employee_Name = '" + em + "'";

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EmployeeSSNtxt.Text = reader["Employee_SSN"].ToString();
                    EmployeeNametxt.Text = reader["Employee_Name"].ToString();
                    EmployeeTeltxt.Text = reader["Phone"].ToString();
                    EmployeeEmailtxt.Text = reader["Email"].ToString();
                    EmployeeDob.Value = (DateTime)reader["Date_of_Birth"];
                    EmployeeDof.Value = (DateTime)reader["Join_Date"];
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update Employees set Employee_SSN = '" + EmployeeSSNtxt.Text + "', Employee_Name = '" + EmployeeNametxt.Text + "', Date_of_Birth = '" + EmployeeDob.Value + "', Phone = '" + EmployeeTeltxt.Text + "',Email = '" + EmployeeEmailtxt.Text + "', Join_Date = '" + EmployeeDof.Value + "' where Employee_Name = '" + em + "'";

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
