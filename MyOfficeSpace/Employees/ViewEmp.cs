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
    public partial class ViewEmp : Form
    {
        string em;
        public ViewEmp(string em)
        {
            InitializeComponent();
            this.em = em;
        }

        private void ViewEmp_Load(object sender, EventArgs e)
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
                    EmployeeDobtxt.Text = reader["Date_of_Birth"].ToString();
                    EmployeeDoftxt.Text = reader["Join_Date"].ToString();
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
