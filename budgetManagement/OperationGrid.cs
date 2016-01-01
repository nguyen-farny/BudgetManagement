using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace budgetManagement
{
    public partial class OperationGrid : Form
    {
        private Account acc;

        public OperationGrid(Account account)
        {
            InitializeComponent();
            this.acc = account;

            dataGridView.DataSource = this.acc;
        }

        private void OperationGrid_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.acc.ResetBindings();
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = dataGridView.Columns[e.ColumnIndex];
            if(column.DataPropertyName == "Date")
            {
                DateTime date = (DateTime)e.Value;
                e.Value = date.ToShortDateString();
            }
            else if(column.DataPropertyName == "Amount")
            {
                double amount = (double)e.Value;
                if (amount < 0)
                    e.CellStyle.ForeColor = Color.DarkRed;
            }
        }
    }
}
