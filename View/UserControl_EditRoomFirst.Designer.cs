namespace AirBNB.View
{
    partial class UserControl_EditRoomFirst
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
            this.flowLayoutPanel_ucrlRoomList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_ucrlRoomList
            // 
            this.flowLayoutPanel_ucrlRoomList.AutoScroll = true;
            this.flowLayoutPanel_ucrlRoomList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel_ucrlRoomList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_ucrlRoomList.Location = new System.Drawing.Point(6, 3);
            this.flowLayoutPanel_ucrlRoomList.Name = "flowLayoutPanel_ucrlRoomList";
            this.flowLayoutPanel_ucrlRoomList.Size = new System.Drawing.Size(650, 454);
            this.flowLayoutPanel_ucrlRoomList.TabIndex = 0;
            this.flowLayoutPanel_ucrlRoomList.WrapContents = false;
            // 
            // UserControl_EditRoomFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.Controls.Add(this.flowLayoutPanel_ucrlRoomList);
            this.Name = "UserControl_EditRoomFirst";
            this.Size = new System.Drawing.Size(660, 460);
            this.Load += new System.EventHandler(this.UserControl_EditRoomFirst_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_ucrlRoomList;
    }
}
