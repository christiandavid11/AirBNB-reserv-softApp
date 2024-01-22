namespace AirBNB.View
{
    partial class Form_customerCommentsRates
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
            this.panel_cusMenuBorder = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_cusLoadComments = new System.Windows.Forms.FlowLayoutPanel();
            this.button_ownManageRoomClose = new System.Windows.Forms.Button();
            this.panel_cusMenuBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_cusMenuBorder
            // 
            this.panel_cusMenuBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(141)))));
            this.panel_cusMenuBorder.Controls.Add(this.button_ownManageRoomClose);
            this.panel_cusMenuBorder.Controls.Add(this.label12);
            this.panel_cusMenuBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_cusMenuBorder.Location = new System.Drawing.Point(0, 0);
            this.panel_cusMenuBorder.Name = "panel_cusMenuBorder";
            this.panel_cusMenuBorder.Size = new System.Drawing.Size(475, 33);
            this.panel_cusMenuBorder.TabIndex = 5;
            this.panel_cusMenuBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_cusMenuBorder_MouseDown);
            this.panel_cusMenuBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_cusMenuBorder_MouseMove);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-1, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(314, 25);
            this.label12.TabIndex = 32;
            this.label12.Text = "Airbnb, OVBS - Comments/Score";
            // 
            // flowLayoutPanel_cusLoadComments
            // 
            this.flowLayoutPanel_cusLoadComments.AutoScroll = true;
            this.flowLayoutPanel_cusLoadComments.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel_cusLoadComments.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_cusLoadComments.Location = new System.Drawing.Point(0, 33);
            this.flowLayoutPanel_cusLoadComments.Name = "flowLayoutPanel_cusLoadComments";
            this.flowLayoutPanel_cusLoadComments.Size = new System.Drawing.Size(475, 362);
            this.flowLayoutPanel_cusLoadComments.TabIndex = 80;
            this.flowLayoutPanel_cusLoadComments.WrapContents = false;
            // 
            // button_ownManageRoomClose
            // 
            this.button_ownManageRoomClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_ownManageRoomClose.FlatAppearance.BorderSize = 0;
            this.button_ownManageRoomClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ownManageRoomClose.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ownManageRoomClose.Location = new System.Drawing.Point(414, 0);
            this.button_ownManageRoomClose.Name = "button_ownManageRoomClose";
            this.button_ownManageRoomClose.Size = new System.Drawing.Size(61, 33);
            this.button_ownManageRoomClose.TabIndex = 33;
            this.button_ownManageRoomClose.Text = "X";
            this.button_ownManageRoomClose.UseVisualStyleBackColor = true;
            this.button_ownManageRoomClose.Click += new System.EventHandler(this.button_ownManageRoomClose_Click);
            this.button_ownManageRoomClose.MouseLeave += new System.EventHandler(this.button_ownManageRoomClose_MouseLeave);
            this.button_ownManageRoomClose.MouseHover += new System.EventHandler(this.button_ownManageRoomClose_MouseHover);
            // 
            // Form_customerCommentsRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(475, 395);
            this.Controls.Add(this.flowLayoutPanel_cusLoadComments);
            this.Controls.Add(this.panel_cusMenuBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_customerCommentsRates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_customerCommentsRates";
            this.Load += new System.EventHandler(this.Form_customerCommentsRates_Load);
            this.panel_cusMenuBorder.ResumeLayout(false);
            this.panel_cusMenuBorder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_cusMenuBorder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_cusLoadComments;
        private System.Windows.Forms.Button button_ownManageRoomClose;
    }
}