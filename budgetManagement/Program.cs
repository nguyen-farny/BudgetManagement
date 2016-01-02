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
            // 1) Try to load saved data

            // 2) If nothing saved, create a new account
            Account account = GetSavedAccount();
            if(account == null)
                account = CreateNewAccount();

            // 3) Register a listener on account, and save automatically when it is updated
            account.ListChanged += OnAccountUpdated;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
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
            Account newAccount = new Account();
            newAccount.Name = "Compte courant";
            return newAccount; 
        }
    }
}
