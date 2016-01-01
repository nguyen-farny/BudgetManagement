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
        public double Amount { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
 
        public Operation()
        {
            Title = "";
            Amount = 0;
            Date = DateTime.Now;
        }

        public Operation(string t, double a, DateTime d)
        {
            Title = t;
            Amount = a;
            Date = d;
        }

        public override string ToString()
        {
            return "{ " + Title + ", " + Amount + ", " + Date.ToShortDateString() + " }";
        }

        internal bool IsValid()
        {
            return IsValidTitle() && IsValidAmount() && IsValidDate();
        }

        internal bool IsValidTitle()
        {
            return Title != "";
        }

        internal bool IsValidAmount()
        {
            return Amount != 0;
        }

        internal bool IsValidDate()
        {
            return Date != null;
        }
    }
}
