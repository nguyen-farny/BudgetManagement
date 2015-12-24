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
    public partial class CreateOperation : Form
    {
        private Account acc; 

        public CreateOperation(Account account)
        {
            InitializeComponent();
            this.acc = account; 
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            string title = titreBox.Text;
            double amount = double.Parse(montantBox.Text);
            DateTime date = dateTimePicker.Value;

            Operation o = new Operation(title, amount, date);

            acc.Operations.Add(o);

            // MessageBox.Show("Vous venez d'ajouter l'opération : " + o.ToString());
            this.Close();
        }
       
        private void Annuler_Click_1(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void CreateOperation_Load(object sender, EventArgs e)
        {

        }
    }
}
