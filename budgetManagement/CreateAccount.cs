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
    public partial class CreateAccount : Form
    {
        public Account Account { get; set; }

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (accountNameInput.Text.Length != 0)
            {
                Account = new Account();

                Account.Name = accountNameInput.Text;
                Account.Balance = (double)initialBalanceInput.Value;

                Close();
            }
            else
            {
                accountNameInput.BackColor = Color.LightPink;
            }
        }

        private void accountNameInput_TextChanged(object sender, EventArgs e)
        {
            if (accountNameInput.Text.Length != 0)
                accountNameInput.BackColor = Color.White;
            else
                accountNameInput.BackColor = Color.LightPink;
        }
    }
}
