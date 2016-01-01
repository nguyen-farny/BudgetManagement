using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace budgetManagement
{
    public class Operation
    {
        public double amount { get; set; }
        public string title { get; set; }
        public DateTime date { get; set; }
 
        public Operation()
        {
            title = "";
            amount = 0;
            date = DateTime.Now;
        }

        public Operation(string t, double a, DateTime d)
        {
            title = t;
            amount = a;
            date = d;
        }

        public override string ToString()
        {
            return "{ " + title + ", " + amount + ", " + date.ToShortDateString() + " }";
        }

        internal bool IsValid()
        {
            return IsValidTitle() && IsValidAmount() && IsValidDate();
        }

        internal bool IsValidTitle()
        {
            return title != "";
        }

        internal bool IsValidAmount()
        {
            return amount != 0;
        }

        internal bool IsValidDate()
        {
            return date != null;
        }
    }
}
