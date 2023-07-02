using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKS_alpha_0._0._1
{
    public partial class MainInterface : Form
    {
        private string none = "none";
        public MainInterface()
        {
            InitializeComponent();
            label_staff_info.Text = LoginMenu.getLoginName;
        }
        

        

        private void MainInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Cancel the default close operation
                Application.Exit(); // Close the entire application
            }
        }

        

        private void button_logout_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                this.Show();
                return;
            }
            
            this.DialogResult = DialogResult.OK;
            //this.Hide();
        }

        private void button_add_room_Click(object sender, EventArgs e)
        {
            //AddNewRoom add = new AddNewRoom();
            //add.Show();
            dataGridView.Rows.Add("1", "Luong Nguyen Khoi","12:00AM 27-03-2023", "12:00AM 29-03-2023", none, none, none);

        }
    }
}
