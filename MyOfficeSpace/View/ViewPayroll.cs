using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOfficeSpace.View
{
    public partial class ViewPayroll : Form
    {
        int i;
        public ViewPayroll(int i)
        {
            this.i = i;
            InitializeComponent();
        }

        private void ViewPayroll_Load(object sender, EventArgs e)
        {
            this.payrollTableAdapter.Fill(this.my_Office_SpaceDataSet.Payroll);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            payrollBindingSource.Filter = "Payroll_Numb=" + i;
        }
    }
}
