namespace QuanLiKS_alpha_0._0._1
{
    partial class MainInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInterface));
            this.button_add_room = new System.Windows.Forms.Button();
            this.button_room_checkout = new System.Windows.Forms.Button();
            this.button_add_services = new System.Windows.Forms.Button();
            this.button_drinks = new System.Windows.Forms.Button();
            this.button_food = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.label_staff_info = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Room_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Services = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drinks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Food = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Maintenance_Request = new System.Windows.Forms.Button();
            this.button_notify_staff = new System.Windows.Forms.Button();
            this.button_edit_room = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button_add_room
            // 
            this.button_add_room.Location = new System.Drawing.Point(960, 15);
            this.button_add_room.Name = "button_add_room";
            this.button_add_room.Size = new System.Drawing.Size(161, 36);
            this.button_add_room.TabIndex = 1;
            this.button_add_room.Text = "Add New Room";
            this.button_add_room.UseVisualStyleBackColor = true;
            this.button_add_room.Click += new System.EventHandler(this.button_add_room_Click);
            // 
            // button_room_checkout
            // 
            this.button_room_checkout.Location = new System.Drawing.Point(960, 57);
            this.button_room_checkout.Name = "button_room_checkout";
            this.button_room_checkout.Size = new System.Drawing.Size(161, 36);
            this.button_room_checkout.TabIndex = 1;
            this.button_room_checkout.Text = "Room Checkout";
            this.button_room_checkout.UseVisualStyleBackColor = true;
            // 
            // button_add_services
            // 
            this.button_add_services.Location = new System.Drawing.Point(960, 99);
            this.button_add_services.Name = "button_add_services";
            this.button_add_services.Size = new System.Drawing.Size(161, 36);
            this.button_add_services.TabIndex = 1;
            this.button_add_services.Text = "Add Services";
            this.button_add_services.UseVisualStyleBackColor = true;
            // 
            // button_drinks
            // 
            this.button_drinks.Location = new System.Drawing.Point(960, 141);
            this.button_drinks.Name = "button_drinks";
            this.button_drinks.Size = new System.Drawing.Size(161, 36);
            this.button_drinks.TabIndex = 1;
            this.button_drinks.Text = "Drinks";
            this.button_drinks.UseVisualStyleBackColor = true;
            // 
            // button_food
            // 
            this.button_food.Location = new System.Drawing.Point(960, 183);
            this.button_food.Name = "button_food";
            this.button_food.Size = new System.Drawing.Size(161, 36);
            this.button_food.TabIndex = 1;
            this.button_food.Text = "Food";
            this.button_food.UseVisualStyleBackColor = true;
            // 
            // button_logout
            // 
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_logout.Location = new System.Drawing.Point(960, 393);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(161, 36);
            this.button_logout.TabIndex = 1;
            this.button_logout.Text = "Log Out";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // label_staff_info
            // 
            this.label_staff_info.AutoSize = true;
            this.label_staff_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_staff_info.Location = new System.Drawing.Point(24, 448);
            this.label_staff_info.Name = "label_staff_info";
            this.label_staff_info.Size = new System.Drawing.Size(158, 25);
            this.label_staff_info.TabIndex = 2;
            this.label_staff_info.Text = "label_staff_info";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Room_ID,
            this.Name,
            this.Checkin,
            this.Checkout,
            this.Services,
            this.Drinks,
            this.Food});
            this.dataGridView.Location = new System.Drawing.Point(13, 15);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(941, 414);
            this.dataGridView.TabIndex = 3;
            // 
            // Room_ID
            // 
            this.Room_ID.HeaderText = "Room ID";
            this.Room_ID.MinimumWidth = 50;
            this.Room_ID.Name = "Room_ID";
            this.Room_ID.ReadOnly = true;
            this.Room_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Room_ID.Width = 50;
            // 
            // Name
            // 
            this.Name.HeaderText = "MainInterface";
            this.Name.MinimumWidth = 150;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 150;
            // 
            // Checkin
            // 
            this.Checkin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Checkin.HeaderText = "Checkin";
            this.Checkin.MinimumWidth = 150;
            this.Checkin.Name = "Checkin";
            this.Checkin.ReadOnly = true;
            this.Checkin.Width = 150;
            // 
            // Checkout
            // 
            this.Checkout.HeaderText = "Checkout";
            this.Checkout.MinimumWidth = 150;
            this.Checkout.Name = "Checkout";
            this.Checkout.ReadOnly = true;
            this.Checkout.Width = 150;
            // 
            // Services
            // 
            this.Services.HeaderText = "Services";
            this.Services.MinimumWidth = 150;
            this.Services.Name = "Services";
            this.Services.ReadOnly = true;
            this.Services.Width = 150;
            // 
            // Drinks
            // 
            this.Drinks.HeaderText = "Drinks";
            this.Drinks.MinimumWidth = 150;
            this.Drinks.Name = "Drinks";
            this.Drinks.ReadOnly = true;
            this.Drinks.Width = 150;
            // 
            // Food
            // 
            this.Food.HeaderText = "Food";
            this.Food.MinimumWidth = 150;
            this.Food.Name = "Food";
            this.Food.ReadOnly = true;
            this.Food.Width = 150;
            // 
            // button_Maintenance_Request
            // 
            this.button_Maintenance_Request.Location = new System.Drawing.Point(960, 225);
            this.button_Maintenance_Request.Name = "button_Maintenance_Request";
            this.button_Maintenance_Request.Size = new System.Drawing.Size(161, 34);
            this.button_Maintenance_Request.TabIndex = 4;
            this.button_Maintenance_Request.Text = "Maintenance Request";
            this.button_Maintenance_Request.UseVisualStyleBackColor = true;
            // 
            // button_notify_staff
            // 
            this.button_notify_staff.Location = new System.Drawing.Point(960, 266);
            this.button_notify_staff.Name = "button_notify_staff";
            this.button_notify_staff.Size = new System.Drawing.Size(161, 35);
            this.button_notify_staff.TabIndex = 5;
            this.button_notify_staff.Text = "Notify Staff";
            this.button_notify_staff.UseVisualStyleBackColor = true;
            // 
            // button_edit_room
            // 
            this.button_edit_room.Location = new System.Drawing.Point(960, 308);
            this.button_edit_room.Name = "button_edit_room";
            this.button_edit_room.Size = new System.Drawing.Size(161, 37);
            this.button_edit_room.TabIndex = 6;
            this.button_edit_room.Text = "Edit Room Info";
            this.button_edit_room.UseVisualStyleBackColor = true;
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 511);
            this.Controls.Add(this.button_edit_room);
            this.Controls.Add(this.button_notify_staff);
            this.Controls.Add(this.button_Maintenance_Request);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label_staff_info);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_food);
            this.Controls.Add(this.button_drinks);
            this.Controls.Add(this.button_add_services);
            this.Controls.Add(this.button_room_checkout);
            this.Controls.Add(this.button_add_room);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainInterface";
            this.Text = "Hotel Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainInterface_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_add_room;
        private System.Windows.Forms.Button button_room_checkout;
        private System.Windows.Forms.Button button_add_services;
        private System.Windows.Forms.Button button_drinks;
        private System.Windows.Forms.Button button_food;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label_staff_info;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button_Maintenance_Request;
        private System.Windows.Forms.Button button_notify_staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Services;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drinks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Food;
        private System.Windows.Forms.Button button_edit_room;
    }
}