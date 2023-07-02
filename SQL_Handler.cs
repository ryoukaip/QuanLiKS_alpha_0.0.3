using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKS_alpha_0._0._1
{
    internal class SQL_Handler
    {
        public static SQLiteConnection setConnection()
        {
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=Resources/mydatabase.db; Version = 3;");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return sqlite_conn;
        }

        public static void InsertData(SQLiteConnection sqlite_conn)
        {
            SQLiteCommand cmd;
            cmd = sqlite_conn.CreateCommand();

        }

        private static List<string> nameList = new List<string>();
        private static List<string> passwordList = new List<string>();

        private static void setEntries( string name, string password )
        {
            nameList.Add( name );
            passwordList.Add( password );
        }

        public static List <string> getNameList()
        {
            return nameList;
        }
        public static List<string> getPasswordList()
        {
            return passwordList;
        }

        public static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM RECEPTIONIST";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            if (sqlite_datareader.HasRows)
            {
                while (sqlite_datareader.Read())
                {
                    int id = sqlite_datareader.GetInt32(0); // get column number 0
                    string name = sqlite_datareader.GetString(1); //get column number 1
                    string password = sqlite_datareader.GetString(2); //get column number 2

                    setEntries( name, password);
                }
            }


            conn.Close();
        }

    }
}
