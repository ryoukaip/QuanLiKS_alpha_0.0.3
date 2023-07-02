namespace QuanLiKS_alpha_0._0._1
{
    partial class NotifyStaff
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cl_id_room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_id_staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_notify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_id_room,
            this.cl_id_staff,
            this.cl_note});
            this.dataGridView1.Location = new System.Drawing.Point(34, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(434, 537);
            this.dataGridView1.TabIndex = 0;
            // 
            // cl_id_room
            // 
            this.cl_id_room.HeaderText = "ID Room";
            this.cl_id_room.MinimumWidth = 6;
            this.cl_id_room.Name = "cl_id_room";
            this.cl_id_room.Width = 125;
            // 
            // cl_id_staff
            // 
            this.cl_id_staff.HeaderText = "ID Staff";
            this.cl_id_staff.MinimumWidth = 6;
            this.cl_id_staff.Name = "cl_id_staff";
            this.cl_id_staff.Width = 125;
            // 
            // cl_note
            // 
            this.cl_note.HeaderText = "Note";
            this.cl_note.MinimumWidth = 6;
            this.cl_note.Name = "cl_note";
            this.cl_note.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(553, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Staff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Note";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(556, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(556, 253);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(206, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(553, 404);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 22);
            this.textBox1.TabIndex = 4;
            // 
            // btn_notify
            // 
            this.btn_notify.Location = new System.Drawing.Point(605, 474);
            this.btn_notify.Name = "btn_notify";
            this.btn_notify.Size = new System.Drawing.Size(113, 70);
            this.btn_notify.TabIndex = 5;
            this.btn_notify.Text = "Notify";
            this.btn_notify.UseVisualStyleBackColor = true;
            // 
            // NotifyStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 565);
            this.Controls.Add(this.btn_notify);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NotifyStaff";
            this.Text = "NotifyStaff";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_id_room;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_id_staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_note;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_notify;
    }
}