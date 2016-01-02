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
    public partial class Home : Form
    {
        private Account acc; 

        public Home(Account account)
        {
            InitializeComponent();
            this.acc = account; 
        }

        private void createOperation_Click(object sender, EventArgs e)
        {
            CreateOperation form = new CreateOperation(acc);
            form.ShowDialog(); // (modal)
        }

        private void detail_Click(object sender, EventArgs e)
        {
            string name = "Detail Of " + acc.Name;
            Form form = Application.OpenForms[name];
            if (form == null)
            {
                form = new OperationGrid(acc);
                form.Name = name;
                form.Show(); // (not modal)
            }
            else
            {
                form.Focus();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // register listener
            acc.ListChanged += Operations_ListChanged;

            // set initial values
            labelSolde.Text = acc.GetCurrentBalance().ToString() + " €";
            groupBox1 .Text = acc.Name; 
        }

        private void Operations_ListChanged(object sender, ListChangedEventArgs e)
        {
            // display result
            labelSolde.Text = acc.GetCurrentBalance().ToString()+ " €";
        }
    }
}
