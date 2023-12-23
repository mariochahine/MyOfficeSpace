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

namespace MyOfficeSpace.Clients
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ClientEmailtxt.Text == "" || ClientIDtxt.Text == "" || ClientNametxt.Text == "" || ClientTeltxt.Text == "")
            {
                MessageBox.Show("Please fill all the fields!", "Missing Fields");
            }
            else
            {
                string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into Clients (Client_ID, Client_Name, Phone, Email) values(" + ClientIDtxt.Text + ", '" + ClientNametxt.Text + "', " + ClientTeltxt.Text + ", '" + ClientEmailtxt.Text + "')";

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    MessageBox.Show("Record Added!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                    this.Close();
                }

            }
        }

        private void AddClient_Load(object sender, EventArgs e)
        {

        }
    }
}
