using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace QuanLiKS_alpha_0._0._1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static int Main()
        {
            
            
            //Console.WriteLine(GetDatabasePath());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginMenu());
            return 0;
            
        }

        /*
        static string GetDatabasePath()
        {
            string dbFileName = "mydatabase.db";
            string currentDirectory = Directory.GetCurrentDirectory();
            string dbPath = Path.Combine(currentDirectory, dbFileName);
            return dbPath;
        }
        */
    }
}
