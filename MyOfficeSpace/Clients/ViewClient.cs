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
    public partial class ViewClient : Form
    {
        string s;
        public ViewClient(string s)
        {
            InitializeComponent();
            this.s = s;
        }

        private void ViewClient_Load(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=My_Office_Space;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Client_ID, Client_Name,Phone,Email from Clients where Client_Name = '" + s + "'";

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ClientIDtxt.Text = reader["Client_ID"].ToString();
                    ClientNametxt.Text = reader["Client_Name"].ToString();
                    ClientTeltxt.Text = reader["Phone"].ToString();
                    ClientEmailtxt.Text = reader["Email"].ToString();
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
