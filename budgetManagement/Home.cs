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

        private void button2_Click(object sender, EventArgs e)
        {
            CreateOperation form = new CreateOperation(acc);

            // FORMULAIRE MODAL  
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OperationGrid form = new OperationGrid(acc.Operations);

            // FORMULAIRE MODAL  
            form.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // register listener
            acc.Operations.ListChanged += Operations_ListChanged;

            // set initial values
            label3.Text = acc.GetCurrentBalance().ToString() + " €";
            label1.Text = acc.Name; 
        }

        private void Operations_ListChanged(object sender, ListChangedEventArgs e)
        {
            // display result
            label3.Text = acc.GetCurrentBalance().ToString()+ " €";
        }
    }
}
