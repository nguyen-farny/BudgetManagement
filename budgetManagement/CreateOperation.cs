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

            dateTimePicker.Value = DateTime.Now;
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            Operation o = GetOperation();
            if (o.IsValid())
            {
                acc.Add(o);
                this.Close();
            }
            else
            {
                ValidateChildren();
            }
        }

        private Operation GetOperation()
        {
            string title = titreBox.Text;
            double amount = decimal.ToDouble(montantBox.Value);
            DateTime date = dateTimePicker.Value;

            Operation o = new Operation(title, amount, date);
            return o;
        }

        private void Annuler_Click_1(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void titreBox_Validating(object sender, CancelEventArgs e)
        {
            Operation o = GetOperation();
            if (!o.IsValidTitle())
                titreBox.BackColor = Color.LightPink;
            else
                titreBox.BackColor = Color.White;
        }

        private void titreBox_TextChanged(object sender, EventArgs e)
        {
            titreBox_Validating(sender, null);
        }

        private void montantBox_Validating(object sender, CancelEventArgs e)
        {
            Operation o = GetOperation();
            if (!o.IsValidAmount())
                montantBox.BackColor = Color.LightPink;
            else
                montantBox.BackColor = Color.White;
        }

        private void montantBox_ValueChanged(object sender, EventArgs e)
        {
            montantBox_Validating(sender, null); 
        }

    }
}
