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
    public partial class AddEmp : Form
    {
        public AddEmp()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (EmployeeEmailtxt.Text == "" || EmployeeSSNtxt.Text == "" || EmployeeNametxt.Text == "" || EmployeeTeltxt.Text == "")
            {
                MessageBox.Show("Please fill all the fields!", "Missing Fields");
            }
            else
            {
                string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into Employees (Employee_SSN, Employee_Name, Date_of_Birth, Phone, Email, Join_date, Termination_Date, Supervisor_Numb, Salary, Rate, Bank_Iban, HR_Numb) ";
                cmd.CommandText += "values('" + EmployeeSSNtxt.Text + "', '" + EmployeeNametxt.Text + "', '" + EmployeeDob.Value + "', '" + EmployeeTeltxt.Text + "', '" + EmployeeEmailtxt.Text + "', '" + EmployeeDof.Value + "','','','','','','')";

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

        private void AddEmp_Load(object sender, EventArgs e)
        {

        }
    }
}
