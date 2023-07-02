namespace QuanLiKS_alpha_0._0._1
{
    partial class MaintenanceRequest
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
            this.cl_date_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_date_finish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_id_room = new System.Windows.Forms.Label();
            this.lb_start = new System.Windows.Forms.Label();
            this.lb_finish = new System.Windows.Forms.Label();
            this.cl_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_note = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_request = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_id_room,
            this.cl_date_start,
            this.cl_date_finish,
            this.cl_note});
            this.dataGridView1.Location = new System.Drawing.Point(2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 527);
            this.dataGridView1.TabIndex = 0;
            // 
            // cl_id_room
            // 
            this.cl_id_room.HeaderText = "ID Room";
            this.cl_id_room.MinimumWidth = 6;
            this.cl_id_room.Name = "cl_id_room";
            this.cl_id_room.Width = 125;
            // 
            // cl_date_start
            // 
            this.cl_date_start.HeaderText = "Date Start";
            this.cl_date_start.MinimumWidth = 6;
            this.cl_date_start.Name = "cl_date_start";
            this.cl_date_start.Width = 125;
            // 
            // cl_date_finish
            // 
            this.cl_date_finish.HeaderText = "Date Finish";
            this.cl_date_finish.MinimumWidth = 6;
            this.cl_date_finish.Name = "cl_date_finish";
            this.cl_date_finish.Width = 125;
            // 
            // lb_id_room
            // 
            this.lb_id_room.AutoSize = true;
            this.lb_id_room.Location = new System.Drawing.Point(616, 12);
            this.lb_id_room.Name = "lb_id_room";
            this.lb_id_room.Size = new System.Drawing.Size(60, 16);
            this.lb_id_room.TabIndex = 1;
            this.lb_id_room.Text = "ID Room";
            // 
            // lb_start
            // 
            this.lb_start.AutoSize = true;
            this.lb_start.Location = new System.Drawing.Point(624, 128);
            this.lb_start.Name = "lb_start";
            this.lb_start.Size = new System.Drawing.Size(66, 16);
            this.lb_start.TabIndex = 1;
            this.lb_start.Text = "Date Start";
            // 
            // lb_finish
            // 
            this.lb_finish.AutoSize = true;
            this.lb_finish.Location = new System.Drawing.Point(623, 257);
            this.lb_finish.Name = "lb_finish";
            this.lb_finish.Size = new System.Drawing.Size(74, 16);
            this.lb_finish.TabIndex = 1;
            this.lb_finish.Text = "Date Finish";
            this.lb_finish.Click += new System.EventHandler(this.label3_Click);
            // 
            // cl_note
            // 
            this.cl_note.HeaderText = "Note";
            this.cl_note.MinimumWidth = 6;
            this.cl_note.Name = "cl_note";
            this.cl_note.Width = 125;
            // 
            // lb_note
            // 
            this.lb_note.AutoSize = true;
            this.lb_note.Location = new System.Drawing.Point(616, 368);
            this.lb_note.Name = "lb_note";
            this.lb_note.Size = new System.Drawing.Size(36, 16);
            this.lb_note.TabIndex = 1;
            this.lb_note.Text = "Note";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(619, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(626, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(627, 301);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(234, 22);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(627, 422);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 22);
            this.textBox1.TabIndex = 5;
            // 
            // btn_request
            // 
            this.btn_request.Location = new System.Drawing.Point(693, 491);
            this.btn_request.Name = "btn_request";
            this.btn_request.Size = new System.Drawing.Size(121, 37);
            this.btn_request.TabIndex = 6;
            this.btn_request.Text = "Request";
            this.btn_request.UseVisualStyleBackColor = true;
            // 
            // MaintenanceRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 570);
            this.Controls.Add(this.btn_request);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lb_note);
            this.Controls.Add(this.lb_finish);
            this.Controls.Add(this.lb_start);
            this.Controls.Add(this.lb_id_room);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MaintenanceRequest";
            this.Text = "MaintenanceRequest";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_id_room;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_date_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_date_finish;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_note;
        private System.Windows.Forms.Label lb_id_room;
        private System.Windows.Forms.Label lb_start;
        private System.Windows.Forms.Label lb_finish;
        private System.Windows.Forms.Label lb_note;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_request;
    }
}