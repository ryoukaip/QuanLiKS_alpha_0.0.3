namespace QuanLiKS_alpha_0._0._1
{
    partial class AddService
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
            this.cl_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_id_room = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add_service = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_id_room,
            this.cl_service,
            this.cl_date,
            this.cl_time,
            this.cl_note});
            this.dataGridView1.Location = new System.Drawing.Point(48, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(693, 486);
            this.dataGridView1.TabIndex = 0;
            // 
            // cl_id_room
            // 
            this.cl_id_room.HeaderText = "ID Room";
            this.cl_id_room.MinimumWidth = 6;
            this.cl_id_room.Name = "cl_id_room";
            this.cl_id_room.Width = 125;
            // 
            // cl_service
            // 
            this.cl_service.HeaderText = "Service";
            this.cl_service.MinimumWidth = 6;
            this.cl_service.Name = "cl_service";
            this.cl_service.Width = 125;
            // 
            // cl_date
            // 
            this.cl_date.HeaderText = "Date";
            this.cl_date.MinimumWidth = 6;
            this.cl_date.Name = "cl_date";
            this.cl_date.Width = 125;
            // 
            // cl_time
            // 
            this.cl_time.HeaderText = "Time";
            this.cl_time.MinimumWidth = 6;
            this.cl_time.Name = "cl_time";
            this.cl_time.Width = 125;
            // 
            // cl_note
            // 
            this.cl_note.HeaderText = "note";
            this.cl_note.MinimumWidth = 6;
            this.cl_note.Name = "cl_note";
            this.cl_note.Width = 125;
            // 
            // lb_id_room
            // 
            this.lb_id_room.AutoSize = true;
            this.lb_id_room.Location = new System.Drawing.Point(778, 117);
            this.lb_id_room.Name = "lb_id_room";
            this.lb_id_room.Size = new System.Drawing.Size(63, 16);
            this.lb_id_room.TabIndex = 1;
            this.lb_id_room.Text = "ID Room:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(778, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Service:";
            // 
            // btn_add_service
            // 
            this.btn_add_service.Location = new System.Drawing.Point(781, 352);
            this.btn_add_service.Name = "btn_add_service";
            this.btn_add_service.Size = new System.Drawing.Size(121, 58);
            this.btn_add_service.TabIndex = 3;
            this.btn_add_service.Text = "Add";
            this.btn_add_service.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(778, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(778, 259);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 549);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_add_service);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_id_room);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddService";
            this.Text = "AddService";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_id_room;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_note;
        private System.Windows.Forms.Label lb_id_room;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add_service;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}