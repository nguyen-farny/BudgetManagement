using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace budgetManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Account acc = new Account();
            acc.Name = "Compte courant"; 

            /*
            BindingList<Operation> operations = new BindingList<Operation>();
            operations.Add(new Operation("Loyer", 1120, DateTime.Now));
            operations.Add(new Operation("Telephone", 4, DateTime.Now));
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new CreateOperation());

            //Application.Run(new OperationGrid(operations));
            Application.Run(new Home(acc));
        }
    }
}
