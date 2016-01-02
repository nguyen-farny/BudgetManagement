using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetManagement
{
    [Serializable]
    public class Account : BindingList<Operation>
    {
        public string Name { get; set; }
        public double Balance { get; set; }

        public Account()
        {
            Name = "";
            Balance = 0;
        }

        public double GetCurrentBalance()
        {
            // initial balance
            double balance = Balance;

            // add operations
            for (int i = 0; i < Count; i++)
                balance += Items[i].Amount;

            return balance; 
        }

        #region Sorting

        [NonSerialized]
        private bool _IsSortedCore = false;

        [NonSerialized]
        private ListSortDirection _SortDirectionCore = ListSortDirection.Ascending;

        [NonSerialized]
        private PropertyDescriptor _SortPropertyCore = null;

        protected override bool SupportsSortingCore
        {
            get
            {
                return true;
            }
        }

        protected override bool IsSortedCore
        {
            get
            {
                return _IsSortedCore;
            }
        }

        protected override void RemoveSortCore()
        {
            _IsSortedCore = false;
        }

        protected override ListSortDirection SortDirectionCore
        {
            get
            {
                return _SortDirectionCore; 
            }
        }

        protected override PropertyDescriptor SortPropertyCore
        {
            get
            {
                return _SortPropertyCore;
            }
        }

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            (Items as List<Operation>).Sort((a,b) => {
                int result = 0;
                if (prop.Name == "Amount")
                    result = a.Amount.CompareTo(b.Amount);
                else if (prop.Name == "Title")
                    result = a.Title.CompareTo(b.Title);
                else
                    result = a.Date.CompareTo(b.Date);

                if (direction == ListSortDirection.Descending)
                    result *= -1;

                return result;
            });

            _IsSortedCore = true;
            _SortDirectionCore = direction;
            _SortPropertyCore = prop;
        }

        #endregion
    }
}
