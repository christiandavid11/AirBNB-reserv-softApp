namespace AirBNB.View
{
    partial class UserControl_cusRoomList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_userCus = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_userCusAddress = new System.Windows.Forms.Label();
            this.label_userCusRoomID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_Status = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_userCus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox_userCus);
            this.panel1.Location = new System.Drawing.Point(7, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 129);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox_userCus
            // 
            this.pictureBox_userCus.Location = new System.Drawing.Point(13, 17);
            this.pictureBox_userCus.Name = "pictureBox_userCus";
            this.pictureBox_userCus.Size = new System.Drawing.Size(101, 90);
            this.pictureBox_userCus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_userCus.TabIndex = 0;
            this.pictureBox_userCus.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(145, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Room ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Address:";
            // 
            // label_userCusAddress
            // 
            this.label_userCusAddress.AutoSize = true;
            this.label_userCusAddress.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userCusAddress.Location = new System.Drawing.Point(148, 90);
            this.label_userCusAddress.Name = "label_userCusAddress";
            this.label_userCusAddress.Size = new System.Drawing.Size(0, 20);
            this.label_userCusAddress.TabIndex = 22;
            // 
            // label_userCusRoomID
            // 
            this.label_userCusRoomID.AutoSize = true;
            this.label_userCusRoomID.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userCusRoomID.Location = new System.Drawing.Point(229, 28);
            this.label_userCusRoomID.Name = "label_userCusRoomID";
            this.label_userCusRoomID.Size = new System.Drawing.Size(0, 20);
            this.label_userCusRoomID.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(141)))));
            this.panel2.Location = new System.Drawing.Point(7, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 5);
            this.panel2.TabIndex = 24;
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status.Location = new System.Drawing.Point(320, 10);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(0, 20);
            this.label_Status.TabIndex = 25;
            // 
            // UserControl_cusRoomList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_userCusRoomID);
            this.Controls.Add(this.label_userCusAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_cusRoomList";
            this.Size = new System.Drawing.Size(433, 150);
            this.Load += new System.EventHandler(this.UserControl_cusRoomList_Load);
            this.Click += new System.EventHandler(this.UserControl_cusRoomList_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_userCus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_userCus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_userCusAddress;
        private System.Windows.Forms.Label label_userCusRoomID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Status;
    }
}
