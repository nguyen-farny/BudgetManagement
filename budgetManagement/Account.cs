using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetManagement
{
    public class Account
    {
        public string Name { get; set; }
        public BindingList<Operation> Operations { get; set; }
        public double Balance { get; set; }

        public Account()
        {
            Name = "";
            Operations = new BindingList<Operation>(); 
            Balance = 0;
        }

        public double GetCurrentBalance()
        {
            // initial balance
            double balance = Balance;

            // add operations
            for (int i = 0; i < Operations.Count; i++)
                balance += Operations[i].amount;

            return balance; 
        }
    }
}
