namespace AirBNB.View
{
    partial class UserControl_CommentsAndRates
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
            this.richTextBox_Comments = new System.Windows.Forms.RichTextBox();
            this.label_FullName = new System.Windows.Forms.Label();
            this.label_Score = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // richTextBox_Comments
            // 
            this.richTextBox_Comments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.richTextBox_Comments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_Comments.Enabled = false;
            this.richTextBox_Comments.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Comments.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_Comments.Name = "richTextBox_Comments";
            this.richTextBox_Comments.ReadOnly = true;
            this.richTextBox_Comments.Size = new System.Drawing.Size(448, 134);
            this.richTextBox_Comments.TabIndex = 0;
            this.richTextBox_Comments.Text = "";
            // 
            // label_FullName
            // 
            this.label_FullName.AutoSize = true;
            this.label_FullName.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FullName.Location = new System.Drawing.Point(8, 174);
            this.label_FullName.Name = "label_FullName";
            this.label_FullName.Size = new System.Drawing.Size(0, 18);
            this.label_FullName.TabIndex = 60;
            // 
            // label_Score
            // 
            this.label_Score.AutoEllipsis = true;
            this.label_Score.AutoSize = true;
            this.label_Score.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Score.Location = new System.Drawing.Point(8, 141);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(0, 18);
            this.label_Score.TabIndex = 61;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(141)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 5);
            this.panel1.TabIndex = 62;
            // 
            // UserControl_CommentsAndRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.Controls.Add(this.richTextBox_Comments);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_Score);
            this.Controls.Add(this.label_FullName);
            this.Name = "UserControl_CommentsAndRates";
            this.Size = new System.Drawing.Size(448, 217);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Comments;
        private System.Windows.Forms.Label label_FullName;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.Panel panel1;
    }
}
