using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1) Try to load saved data
            Account account = GetSavedAccount();

            // 2) If nothing saved, create a new account
            if (account == null)
                account = CreateNewAccount();

            // 3) No account data, quit application
            if (account == null)
                return;

            // 4) Save newly created account
            SaveAccount(account); 

            // 5) Register a listener on account, and save automatically when it is updated
            account.ListChanged += OnAccountUpdated;

            Application.Run(new Home(account));
        }

        private static void SaveAccount(Account acc)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("AccountInfo.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, acc);
            stream.Close();
        }

        private static void OnAccountUpdated(object sender, ListChangedEventArgs e)
        {
            SaveAccount(sender as Account);
        }

        private static Account GetSavedAccount()
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("AccountInfo.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Account account = (Account)formatter.Deserialize(stream);
                stream.Close();

                return account;
            }
            catch(Exception)
            {
                return null;
            }
        }

        private static Account CreateNewAccount()
        {
            CreateAccount createAccount = new CreateAccount();
            Application.Run(createAccount);

            return createAccount.Account; 
        }
    }
}
