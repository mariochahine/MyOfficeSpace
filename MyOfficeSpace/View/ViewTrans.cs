using Bunifu.UI.WinForms;
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
    public partial class ViewTrans : Form
    {
        int i;
        public ViewTrans(int i)
        {
            InitializeComponent();
            this.i = i; 
        }

        private void ViewTrans_Load(object sender, EventArgs e)
        {
            this.expensesTableAdapter.Fill(this.my_Office_SpaceDataSet.Expenses);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            expensesBindingSource.Filter = "Expense_Numb=" + i;
        }
    }
}
