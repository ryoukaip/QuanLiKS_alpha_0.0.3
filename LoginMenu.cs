using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace QuanLiKS_alpha_0._0._1
{
    public partial class LoginMenu : Form
    {
        private static SQLiteConnection sqlite_conn;
        private static string loginName;
        public LoginMenu()
        {
            InitializeComponent();
            textBox1.Select();
            sqlite_conn = SQL_Handler.setConnection();
            SQL_Handler.ReadData(sqlite_conn);
            
        }

        public static string getLoginName { get{ return loginName; } }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                this.Show();
                return;
            }
            Application.Exit();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            bool flag = false ; // flag to check login success or not
                                // use when comeback from others forms
            string username, password;
            username = textBox1.Text; password = textBox2.Text;
            
            List<string> nameList = SQL_Handler.getNameList();
            List<string> passwordList = SQL_Handler.getPasswordList();
            try
            {
                for (int i = 0; i < nameList.Count; i++)
                {
                    //if (nameList[i] == username && passwordList[i] == password)
                    if (true)
                    {
                        flag = true;
                        //MessageBox.Show("ok");
                        loginName = username;
                        this.Hide();
                        MainInterface mainInterface = new MainInterface();
                        mainInterface.ShowDialog();
                        this.Show();
                        break;
;                    }
                    
                }
                
                //textBox1.Clear();
                textBox2.Clear();

                textBox2.Focus();
                if (!flag)
                {
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBox.Show("Invalid login", "Error", MessageBoxButtons.OK, icon);
                }
                flag = false ;
                
            }
            catch
            {
                MessageBox.Show("Error.");
            }
            finally
            {
                // close connection
                sqlite_conn.Close();
            }
        }

        private void button_clear_input_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            textBox1.Focus();
        }
    }

    
}
