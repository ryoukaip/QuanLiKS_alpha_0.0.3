namespace QuanLiKS_alpha_0._0._1
{
    partial class AddFood
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
            this.cl_food = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_id_room = new System.Windows.Forms.Label();
            this.lb_food = new System.Windows.Forms.Label();
            this.lb_count = new System.Windows.Forms.Label();
            this.lb_note = new System.Windows.Forms.Label();
            this.btn_add_food = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txt_note_food = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_id_room,
            this.cl_food,
            this.cl_count,
            this.cl_note});
            this.dataGridView1.Location = new System.Drawing.Point(46, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(558, 480);
            this.dataGridView1.TabIndex = 0;
            // 
            // cl_id_room
            // 
            this.cl_id_room.HeaderText = "ID Room";
            this.cl_id_room.MinimumWidth = 6;
            this.cl_id_room.Name = "cl_id_room";
            this.cl_id_room.Width = 125;
            // 
            // cl_food
            // 
            this.cl_food.HeaderText = "Food";
            this.cl_food.MinimumWidth = 6;
            this.cl_food.Name = "cl_food";
            this.cl_food.Width = 125;
            // 
            // cl_count
            // 
            this.cl_count.HeaderText = "Count";
            this.cl_count.MinimumWidth = 6;
            this.cl_count.Name = "cl_count";
            this.cl_count.Width = 125;
            // 
            // cl_note
            // 
            this.cl_note.HeaderText = "Note";
            this.cl_note.MinimumWidth = 6;
            this.cl_note.Name = "cl_note";
            this.cl_note.Width = 125;
            // 
            // lb_id_room
            // 
            this.lb_id_room.AutoSize = true;
            this.lb_id_room.Location = new System.Drawing.Point(683, 60);
            this.lb_id_room.Name = "lb_id_room";
            this.lb_id_room.Size = new System.Drawing.Size(60, 16);
            this.lb_id_room.TabIndex = 1;
            this.lb_id_room.Text = "ID Room";
            // 
            // lb_food
            // 
            this.lb_food.AutoSize = true;
            this.lb_food.Location = new System.Drawing.Point(683, 171);
            this.lb_food.Name = "lb_food";
            this.lb_food.Size = new System.Drawing.Size(39, 16);
            this.lb_food.TabIndex = 2;
            this.lb_food.Text = "Food";
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Location = new System.Drawing.Point(689, 268);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(41, 16);
            this.lb_count.TabIndex = 3;
            this.lb_count.Text = "Count";
            // 
            // lb_note
            // 
            this.lb_note.AutoSize = true;
            this.lb_note.Location = new System.Drawing.Point(689, 364);
            this.lb_note.Name = "lb_note";
            this.lb_note.Size = new System.Drawing.Size(36, 16);
            this.lb_note.TabIndex = 4;
            this.lb_note.Text = "Note";
            // 
            // btn_add_food
            // 
            this.btn_add_food.Location = new System.Drawing.Point(733, 464);
            this.btn_add_food.Name = "btn_add_food";
            this.btn_add_food.Size = new System.Drawing.Size(117, 49);
            this.btn_add_food.TabIndex = 5;
            this.btn_add_food.Text = "Add";
            this.btn_add_food.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(687, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(687, 209);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(206, 24);
            this.comboBox2.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(687, 313);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 22);
            this.numericUpDown1.TabIndex = 8;
            // 
            // txt_note_food
            // 
            this.txt_note_food.Location = new System.Drawing.Point(692, 411);
            this.txt_note_food.Name = "txt_note_food";
            this.txt_note_food.Size = new System.Drawing.Size(201, 22);
            this.txt_note_food.TabIndex = 9;
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 565);
            this.Controls.Add(this.txt_note_food);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_add_food);
            this.Controls.Add(this.lb_note);
            this.Controls.Add(this.lb_count);
            this.Controls.Add(this.lb_food);
            this.Controls.Add(this.lb_id_room);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddFood";
            this.Text = "AddFood";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_id_room;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_food;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_note;
        private System.Windows.Forms.Label lb_id_room;
        private System.Windows.Forms.Label lb_food;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.Label lb_note;
        private System.Windows.Forms.Button btn_add_food;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txt_note_food;
    }
}