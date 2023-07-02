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
    public partial class AddNewRoom : Form
    {
        private static string RoomID;
        private static string customerName;
        private static string DateCheckIn;
        private static string DateCheckOut;
        private static string TimeCheckIn;
        private static string TimeCheckOut;
        private static List<string> Drinks = new List<string>();
        private static List<string> Food = new List<string>();
        private static bool extraService = false;
        private static int laundry = 0;
        public AddNewRoom()
        {
            InitializeComponent();
        }

        public void getData()
        {

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_plusDrinks_Click(object sender, EventArgs e)
        {
            if (comboBox_Drinks.Text.Any())
            {
                listView_drinks.Items.Add(comboBox_Drinks.Text);
            }
        }

        private void checkBox_exsrv_CheckedChanged(object sender, EventArgs e)
        {
            if (label_ex_service_count.Text == "No")
            {
                label_ex_service_count.Text = "Yes";
                return;
            }
            label_ex_service_count.Text = "No";
        }

        private void button_ldryPlus_Click(object sender, EventArgs e)
        {
            if (checkBox_laundry.Checked)
            {
                int tmp = Convert.ToInt32(label_laundry_count.Text);
                tmp += (int)numericUpDown_Laundry.Value;
                label_laundry_count.Text = tmp.ToString();
            }
        }

        private void button_ldryMinus_Click(object sender, EventArgs e)
        {
            if (checkBox_laundry.Checked)
            {
                int tmp = Convert.ToInt32(label_laundry_count.Text);
                if (tmp > 0)
                {
                    tmp -= (int)numericUpDown_Laundry.Value;
                    label_laundry_count.Text = tmp.ToString();                                                                                                                                  
                }
                
            }
        }

        private void button_plusFood_Click(object sender, EventArgs e)
        {
            if (comboBox_Food.Text.Any())
            {
                listView_food.Items.Add(comboBox_Food.Text);
            }
        }

        private void button_add_room_Click(object sender, EventArgs e)
        {
            RoomID = textBox_id.Text;
            customerName = textBox_name.Text;
            DateCheckIn = dateTimePicker_dateIn.Value.ToString("dd-MM-yyyy");
            DateCheckOut = dateTimePicker_DateOut.Value.ToString("dd-MM-yyyy");
            TimeCheckIn = dateTimePicker_timeIn.Value.ToString("HH:mm");
            TimeCheckOut = dateTimePicker_timeOut.Value.ToString("HH:mm");
            foreach (ListViewItem item in listView_drinks.Items)
            {
                Drinks.Add(item.Text);
            }
            foreach (ListViewItem item in listView_food.Items)
            {
                Food.Add(item.Text);
            }
            if (label_ex_service_count.Text == "Yes")
            {
                extraService = true;
            }
            if (checkBox_laundry.Checked)
            {
                laundry = Convert.ToInt32(label_laundry_count.Text);
            }
            //MessageBox.Show(RoomID);
            // create a msgbox to show all the data for testing
            MessageBox.Show("RoomID: " + RoomID + "\nCustomer Name: " + customerName + "\nDate Check In: " + DateCheckIn + "\nDate Check Out: " + DateCheckOut + "\nTime Check In: " + TimeCheckIn + "\nTime Check Out: " + TimeCheckOut + "\nDrinks: " + Drinks + "\nFood: " + Food + "\nExtra Service: " + extraService + "\nLaundry: " + laundry);

        }

        private void button_removeFood_Click(object sender, EventArgs e)
        {
            if (listView_food.SelectedItems.Count > 0)
            {
                listView_food.Items.Remove(listView_food.SelectedItems[0]);
            }
        }

        private void button_remove_drinks_Click(object sender, EventArgs e)
        {
            if (listView_drinks.SelectedItems.Count > 0)
            {
                listView_drinks.Items.Remove(listView_drinks.SelectedItems[0]);
            }
        }

        private void textBox_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private void textBox_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }
    }
}
