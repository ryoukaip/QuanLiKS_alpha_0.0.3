namespace QuanLiKS_alpha_0._0._1
{
    partial class RoomCheckout
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
            this.label_roomid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_roomid
            // 
            this.label_roomid.AutoSize = true;
            this.label_roomid.Location = new System.Drawing.Point(26, 24);
            this.label_roomid.Name = "label_roomid";
            this.label_roomid.Size = new System.Drawing.Size(52, 13);
            this.label_roomid.TabIndex = 0;
            this.label_roomid.Text = "Room ID:";
            // 
            // RoomCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 315);
            this.Controls.Add(this.label_roomid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RoomCheckout";
            this.Text = "Room Checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_roomid;
    }
}