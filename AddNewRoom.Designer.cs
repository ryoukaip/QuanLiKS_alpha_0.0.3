namespace QuanLiKS_alpha_0._0._1
{
    partial class AddNewRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_room_id = new System.Windows.Forms.Label();
            this.dateTimePicker_timeOut = new System.Windows.Forms.DateTimePicker();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_checkin = new System.Windows.Forms.Label();
            this.label_checkout = new System.Windows.Forms.Label();
            this.dateTimePicker_DateOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_timeIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_dateIn = new System.Windows.Forms.DateTimePicker();
            this.label_services = new System.Windows.Forms.Label();
            this.numericUpDown_Laundry = new System.Windows.Forms.NumericUpDown();
            this.label_food = new System.Windows.Forms.Label();
            this.button_plusFood = new System.Windows.Forms.Button();
            this.comboBox_Food = new System.Windows.Forms.ComboBox();
            this.label_drinks = new System.Windows.Forms.Label();
            this.button_plusDrinks = new System.Windows.Forms.Button();
            this.comboBox_Drinks = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_ex_service_count = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_laundry_count = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_listDrinks = new System.Windows.Forms.Label();
            this.listView_food = new System.Windows.Forms.ListView();
            this.button_add_room = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ldryMinus = new System.Windows.Forms.Button();
            this.button_ldryPlus = new System.Windows.Forms.Button();
            this.checkBox_exsrv = new System.Windows.Forms.CheckBox();
            this.checkBox_laundry = new System.Windows.Forms.CheckBox();
            this.button_removeFood = new System.Windows.Forms.Button();
            this.button_remove_drinks = new System.Windows.Forms.Button();
            this.listView_drinks = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Laundry)).BeginInit();
            this.SuspendLayout();
            // 
            // label_room_id
            // 
            this.label_room_id.AutoSize = true;
            this.label_room_id.Location = new System.Drawing.Point(12, 24);
            this.label_room_id.Name = "label_room_id";
            this.label_room_id.Size = new System.Drawing.Size(52, 13);
            this.label_room_id.TabIndex = 0;
            this.label_room_id.Text = "Room ID:";
            // 
            // dateTimePicker_timeOut
            // 
            this.dateTimePicker_timeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_timeOut.Location = new System.Drawing.Point(364, 104);
            this.dateTimePicker_timeOut.Name = "dateTimePicker_timeOut";
            this.dateTimePicker_timeOut.ShowUpDown = true;
            this.dateTimePicker_timeOut.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker_timeOut.TabIndex = 1;
            this.dateTimePicker_timeOut.Value = new System.DateTime(2023, 6, 5, 0, 0, 0, 0);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(83, 17);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(77, 20);
            this.textBox_id.TabIndex = 2;
            this.textBox_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_id_KeyPress);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(179, 24);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "Name";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(220, 16);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(293, 20);
            this.textBox_name.TabIndex = 4;
            this.textBox_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_name_KeyPress);
            // 
            // label_checkin
            // 
            this.label_checkin.AutoSize = true;
            this.label_checkin.Location = new System.Drawing.Point(12, 65);
            this.label_checkin.Name = "label_checkin";
            this.label_checkin.Size = new System.Drawing.Size(49, 13);
            this.label_checkin.TabIndex = 5;
            this.label_checkin.Text = "Checkin:";
            // 
            // label_checkout
            // 
            this.label_checkout.AutoSize = true;
            this.label_checkout.Location = new System.Drawing.Point(12, 110);
            this.label_checkout.Name = "label_checkout";
            this.label_checkout.Size = new System.Drawing.Size(56, 13);
            this.label_checkout.TabIndex = 6;
            this.label_checkout.Text = "Checkout:";
            // 
            // dateTimePicker_DateOut
            // 
            this.dateTimePicker_DateOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DateOut.Location = new System.Drawing.Point(83, 104);
            this.dateTimePicker_DateOut.Name = "dateTimePicker_DateOut";
            this.dateTimePicker_DateOut.Size = new System.Drawing.Size(275, 20);
            this.dateTimePicker_DateOut.TabIndex = 7;
            // 
            // dateTimePicker_timeIn
            // 
            this.dateTimePicker_timeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_timeIn.Location = new System.Drawing.Point(364, 59);
            this.dateTimePicker_timeIn.Name = "dateTimePicker_timeIn";
            this.dateTimePicker_timeIn.ShowUpDown = true;
            this.dateTimePicker_timeIn.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker_timeIn.TabIndex = 1;
            this.dateTimePicker_timeIn.Value = new System.DateTime(2023, 6, 5, 0, 0, 0, 0);
            // 
            // dateTimePicker_dateIn
            // 
            this.dateTimePicker_dateIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dateIn.Location = new System.Drawing.Point(83, 59);
            this.dateTimePicker_dateIn.Name = "dateTimePicker_dateIn";
            this.dateTimePicker_dateIn.Size = new System.Drawing.Size(275, 20);
            this.dateTimePicker_dateIn.TabIndex = 7;
            // 
            // label_services
            // 
            this.label_services.AutoSize = true;
            this.label_services.Location = new System.Drawing.Point(12, 156);
            this.label_services.Name = "label_services";
            this.label_services.Size = new System.Drawing.Size(51, 13);
            this.label_services.TabIndex = 8;
            this.label_services.Text = "Services:";
            // 
            // numericUpDown_Laundry
            // 
            this.numericUpDown_Laundry.Location = new System.Drawing.Point(385, 153);
            this.numericUpDown_Laundry.Name = "numericUpDown_Laundry";
            this.numericUpDown_Laundry.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown_Laundry.TabIndex = 10;
            // 
            // label_food
            // 
            this.label_food.AutoSize = true;
            this.label_food.Location = new System.Drawing.Point(15, 198);
            this.label_food.Name = "label_food";
            this.label_food.Size = new System.Drawing.Size(34, 13);
            this.label_food.TabIndex = 11;
            this.label_food.Text = "Food:";
            // 
            // button_plusFood
            // 
            this.button_plusFood.Location = new System.Drawing.Point(208, 190);
            this.button_plusFood.Name = "button_plusFood";
            this.button_plusFood.Size = new System.Drawing.Size(39, 22);
            this.button_plusFood.TabIndex = 13;
            this.button_plusFood.Text = "+";
            this.button_plusFood.UseVisualStyleBackColor = true;
            this.button_plusFood.Click += new System.EventHandler(this.button_plusFood_Click);
            // 
            // comboBox_Food
            // 
            this.comboBox_Food.FormattingEnabled = true;
            this.comboBox_Food.Items.AddRange(new object[] {
            "Spaghetti",
            "Instant Noodle",
            "Fried Rice",
            "Seaweed Soup",
            "Sushi Pack #1",
            "Sushi Pack #2",
            "Ice Cream Cone"});
            this.comboBox_Food.Location = new System.Drawing.Point(83, 190);
            this.comboBox_Food.Name = "comboBox_Food";
            this.comboBox_Food.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Food.TabIndex = 14;
            // 
            // label_drinks
            // 
            this.label_drinks.AutoSize = true;
            this.label_drinks.Location = new System.Drawing.Point(278, 193);
            this.label_drinks.Name = "label_drinks";
            this.label_drinks.Size = new System.Drawing.Size(37, 13);
            this.label_drinks.TabIndex = 11;
            this.label_drinks.Text = "Drinks";
            // 
            // button_plusDrinks
            // 
            this.button_plusDrinks.Location = new System.Drawing.Point(474, 188);
            this.button_plusDrinks.Name = "button_plusDrinks";
            this.button_plusDrinks.Size = new System.Drawing.Size(39, 22);
            this.button_plusDrinks.TabIndex = 13;
            this.button_plusDrinks.Text = "+";
            this.button_plusDrinks.UseVisualStyleBackColor = true;
            this.button_plusDrinks.Click += new System.EventHandler(this.button_plusDrinks_Click);
            // 
            // comboBox_Drinks
            // 
            this.comboBox_Drinks.FormattingEnabled = true;
            this.comboBox_Drinks.Items.AddRange(new object[] {
            "Coca Cola",
            "Cocktail",
            "Nutri Boost",
            "TEA+ Oolong"});
            this.comboBox_Drinks.Location = new System.Drawing.Point(349, 188);
            this.comboBox_Drinks.Name = "comboBox_Drinks";
            this.comboBox_Drinks.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Drinks.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Services:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Extra Room Services: ";
            // 
            // label_ex_service_count
            // 
            this.label_ex_service_count.AutoSize = true;
            this.label_ex_service_count.Location = new System.Drawing.Point(208, 249);
            this.label_ex_service_count.Name = "label_ex_service_count";
            this.label_ex_service_count.Size = new System.Drawing.Size(21, 13);
            this.label_ex_service_count.TabIndex = 17;
            this.label_ex_service_count.Text = "No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Laundry:";
            // 
            // label_laundry_count
            // 
            this.label_laundry_count.AutoSize = true;
            this.label_laundry_count.Location = new System.Drawing.Point(446, 249);
            this.label_laundry_count.Name = "label_laundry_count";
            this.label_laundry_count.Size = new System.Drawing.Size(13, 13);
            this.label_laundry_count.TabIndex = 17;
            this.label_laundry_count.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Food";
            // 
            // label_listDrinks
            // 
            this.label_listDrinks.AutoSize = true;
            this.label_listDrinks.Location = new System.Drawing.Point(278, 297);
            this.label_listDrinks.Name = "label_listDrinks";
            this.label_listDrinks.Size = new System.Drawing.Size(55, 13);
            this.label_listDrinks.TabIndex = 19;
            this.label_listDrinks.Text = "Drinks list:";
            // 
            // listView_food
            // 
            this.listView_food.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView_food.HideSelection = false;
            this.listView_food.Location = new System.Drawing.Point(83, 297);
            this.listView_food.Name = "listView_food";
            this.listView_food.ShowGroups = false;
            this.listView_food.Size = new System.Drawing.Size(164, 126);
            this.listView_food.TabIndex = 20;
            this.listView_food.UseCompatibleStateImageBehavior = false;
            this.listView_food.View = System.Windows.Forms.View.Tile;
            // 
            // button_add_room
            // 
            this.button_add_room.Location = new System.Drawing.Point(449, 456);
            this.button_add_room.Name = "button_add_room";
            this.button_add_room.Size = new System.Drawing.Size(75, 23);
            this.button_add_room.TabIndex = 21;
            this.button_add_room.Text = "Add Room";
            this.button_add_room.UseVisualStyleBackColor = true;
            this.button_add_room.Click += new System.EventHandler(this.button_add_room_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(368, 456);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 21;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_ldryMinus
            // 
            this.button_ldryMinus.Location = new System.Drawing.Point(474, 150);
            this.button_ldryMinus.Name = "button_ldryMinus";
            this.button_ldryMinus.Size = new System.Drawing.Size(39, 23);
            this.button_ldryMinus.TabIndex = 22;
            this.button_ldryMinus.Text = "-";
            this.button_ldryMinus.UseVisualStyleBackColor = true;
            this.button_ldryMinus.Click += new System.EventHandler(this.button_ldryMinus_Click);
            // 
            // button_ldryPlus
            // 
            this.button_ldryPlus.Location = new System.Drawing.Point(429, 150);
            this.button_ldryPlus.Name = "button_ldryPlus";
            this.button_ldryPlus.Size = new System.Drawing.Size(39, 23);
            this.button_ldryPlus.TabIndex = 22;
            this.button_ldryPlus.Text = "+";
            this.button_ldryPlus.UseVisualStyleBackColor = true;
            this.button_ldryPlus.Click += new System.EventHandler(this.button_ldryPlus_Click);
            // 
            // checkBox_exsrv
            // 
            this.checkBox_exsrv.AutoSize = true;
            this.checkBox_exsrv.Location = new System.Drawing.Point(86, 156);
            this.checkBox_exsrv.Name = "checkBox_exsrv";
            this.checkBox_exsrv.Size = new System.Drawing.Size(120, 17);
            this.checkBox_exsrv.TabIndex = 23;
            this.checkBox_exsrv.Text = "Extra Room Service";
            this.checkBox_exsrv.UseVisualStyleBackColor = true;
            this.checkBox_exsrv.CheckedChanged += new System.EventHandler(this.checkBox_exsrv_CheckedChanged);
            // 
            // checkBox_laundry
            // 
            this.checkBox_laundry.AutoSize = true;
            this.checkBox_laundry.Location = new System.Drawing.Point(299, 154);
            this.checkBox_laundry.Name = "checkBox_laundry";
            this.checkBox_laundry.Size = new System.Drawing.Size(64, 17);
            this.checkBox_laundry.TabIndex = 24;
            this.checkBox_laundry.Text = "Laundry";
            this.checkBox_laundry.UseVisualStyleBackColor = true;
            // 
            // button_removeFood
            // 
            this.button_removeFood.Location = new System.Drawing.Point(83, 430);
            this.button_removeFood.Name = "button_removeFood";
            this.button_removeFood.Size = new System.Drawing.Size(164, 23);
            this.button_removeFood.TabIndex = 25;
            this.button_removeFood.Text = "-";
            this.button_removeFood.UseVisualStyleBackColor = true;
            this.button_removeFood.Click += new System.EventHandler(this.button_removeFood_Click);
            // 
            // button_remove_drinks
            // 
            this.button_remove_drinks.Location = new System.Drawing.Point(349, 427);
            this.button_remove_drinks.Name = "button_remove_drinks";
            this.button_remove_drinks.Size = new System.Drawing.Size(164, 23);
            this.button_remove_drinks.TabIndex = 25;
            this.button_remove_drinks.Text = "-";
            this.button_remove_drinks.UseVisualStyleBackColor = true;
            this.button_remove_drinks.Click += new System.EventHandler(this.button_remove_drinks_Click);
            // 
            // listView_drinks
            // 
            this.listView_drinks.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView_drinks.HideSelection = false;
            this.listView_drinks.Location = new System.Drawing.Point(349, 297);
            this.listView_drinks.Name = "listView_drinks";
            this.listView_drinks.ShowGroups = false;
            this.listView_drinks.Size = new System.Drawing.Size(164, 126);
            this.listView_drinks.TabIndex = 20;
            this.listView_drinks.UseCompatibleStateImageBehavior = false;
            this.listView_drinks.View = System.Windows.Forms.View.Tile;
            // 
            // AddNewRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 491);
            this.Controls.Add(this.button_remove_drinks);
            this.Controls.Add(this.button_removeFood);
            this.Controls.Add(this.checkBox_laundry);
            this.Controls.Add(this.checkBox_exsrv);
            this.Controls.Add(this.button_ldryPlus);
            this.Controls.Add(this.button_ldryMinus);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_add_room);
            this.Controls.Add(this.listView_drinks);
            this.Controls.Add(this.listView_food);
            this.Controls.Add(this.label_listDrinks);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_laundry_count);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_ex_service_count);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Drinks);
            this.Controls.Add(this.comboBox_Food);
            this.Controls.Add(this.button_plusDrinks);
            this.Controls.Add(this.label_drinks);
            this.Controls.Add(this.button_plusFood);
            this.Controls.Add(this.label_food);
            this.Controls.Add(this.numericUpDown_Laundry);
            this.Controls.Add(this.label_services);
            this.Controls.Add(this.dateTimePicker_dateIn);
            this.Controls.Add(this.dateTimePicker_DateOut);
            this.Controls.Add(this.label_checkout);
            this.Controls.Add(this.label_checkin);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.dateTimePicker_timeIn);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.dateTimePicker_timeOut);
            this.Controls.Add(this.label_room_id);
            this.Name = "AddNewRoom";
            this.Text = "AddNewRoom";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Laundry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void RadioButton_roomService_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label_room_id;
        private System.Windows.Forms.DateTimePicker dateTimePicker_timeOut;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_checkin;
        private System.Windows.Forms.Label label_checkout;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateOut;
        private System.Windows.Forms.DateTimePicker dateTimePicker_timeIn;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateIn;
        private System.Windows.Forms.Label label_services;
        private System.Windows.Forms.NumericUpDown numericUpDown_Laundry;
        private System.Windows.Forms.Label label_food;
        private System.Windows.Forms.Button button_plusFood;
        private System.Windows.Forms.ComboBox comboBox_Food;
        private System.Windows.Forms.Label label_drinks;
        private System.Windows.Forms.Button button_plusDrinks;
        private System.Windows.Forms.ComboBox comboBox_Drinks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_ex_service_count;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_laundry_count;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_listDrinks;
        private System.Windows.Forms.ListView listView_food;
        private System.Windows.Forms.Button button_add_room;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ldryMinus;
        private System.Windows.Forms.Button button_ldryPlus;
        private System.Windows.Forms.CheckBox checkBox_exsrv;
        private System.Windows.Forms.CheckBox checkBox_laundry;
        private System.Windows.Forms.Button button_removeFood;
        private System.Windows.Forms.Button button_remove_drinks;
        private System.Windows.Forms.ListView listView_drinks;
    }
}