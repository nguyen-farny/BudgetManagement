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
        public OperationGrid(Object datasource)
        {
            InitializeComponent();
            dataGridView.DataSource = datasource;
        }

        private void OperationGrid_Load(object sender, EventArgs e)
        {
            
        }
    }
}
